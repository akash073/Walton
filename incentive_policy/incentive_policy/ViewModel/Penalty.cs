using System;
using System.Data;
using System.Data.SqlClient;

namespace incentive_policy.ViewModel
{
    class Penalty
    {
        public static void CalculateTechnicianQcBounce(int servicePointId, string toDate, long penaltyDay, SqlConnection sqlConnection, long incentive_master_id, SqlTransaction transaction)
        {

            string techQcBounceQuery =
                String.Format(
                    @"select X.ServiceID_previous,X.ServiceID_next,STL.TechnicianID,STL.QCID,STL.QCReleaseStatus 
from (
			select IME,COUNT(*) as total
			,(select MAX(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}') as ServiceID_next
			,(select MIN(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}') as ServiceID_previous
			from ServiceMaster SM
			where ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}'
			and Sm.ServiceID not in (
					select DISTINCT ServiceID 
					from ServiceIssue Si 
					where si.IssueID in ('4','9','32','36','37')
			)
            and SM.ServiceStatus not in ('Replacement','ReplacementDelivered','Terminated')
            and SM.ServicePointID={2}
			group by IME
			having COUNT(*)>1
) X inner join ServiceTimeLog STL on X.ServiceID_previous=STL.ServiceID 
where STL.QCReleaseStatus='QCPassed'", penaltyDay, toDate, servicePointId);

            techQcBounceQuery =
                String.Format(
                    @"select  X.ServiceID_previous,X.ServiceID_next,STL.TechnicianID,STL.QCID,STL.QCReleaseStatus 
from (
select IME,COUNT(*) as Toatl,
(select MAX(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1} 23:59:59') as ServiceID_next,
(select MIN(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1} 23:59:59') as ServiceID_previous
from ServiceMaster SM
			where ServicePlaceDate between '{1}' and '{1} 23:59:59'
			and Sm.ServiceID not in (
					select DISTINCT ServiceID 
					from ServiceIssue Si 
					where si.IssueID in ('4','9','32','36','37')
			)
			and SM.ServiceStatus not in ('Replacement','ReplacementDelivered','Terminated')
            and SM.ServicePointID={2}
			group by IME
			having COUNT(*)>1 

		) X join 
		ServiceTimeLog stl
		on X.ServiceID_next=stl.ServiceID
		where stl.QCReleaseStatus='QCPassed'", penaltyDay, toDate, servicePointId);
            SqlDataAdapter techQcDataAdapter = new SqlDataAdapter(techQcBounceQuery, sqlConnection);
            techQcDataAdapter.SelectCommand.Transaction = transaction;
            techQcDataAdapter.SelectCommand.CommandTimeout = 6000;
            DataTable techQcTable = new DataTable();
            techQcDataAdapter.Fill(techQcTable);
            foreach (DataRow dr in techQcTable.Rows)
            {
                long ServiceID_previous = Convert.ToInt64(dr["ServiceID_previous"]);
                long ServiceID_next = Convert.ToInt64(dr["ServiceID_next"]);
                long TechnicianID = Convert.ToInt64(dr["TechnicianID"]);
                long QCID = Convert.ToInt64(dr["QCID"]);

                var insertPenlaty = String.Format("  insert into incentive_penalties([incentive_master_id],[technicianId],[qcid],[serviceid_previous],[serviceid_next]) values({0},{1},{2},{3},{4})", incentive_master_id, TechnicianID, QCID, ServiceID_previous, ServiceID_next);
                var insertCommand = new SqlCommand(insertPenlaty, sqlConnection, transaction);
                insertCommand.ExecuteNonQuery();
            }

        }


        public static void CalculateReceiverBounce(int servicePointId, string toDate, long penaltyDay, SqlConnection sqlConnection, long incentive_master_id, SqlTransaction transaction)
        {

            string receiverBounceQuery =
                String.Format(@"select X.ServiceID_next,X.ServiceID_previous,SM.AddedBy as receiverId from (
select Sm.IME,COUNT(*) as Total,(select MAX(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}') as ServiceID_next
			,(select MIN(ServiceID) from ServiceMaster ss where ss.IME=SM.IME and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}') as ServiceID_previous
from ServiceMaster SM
where ServiceStatus='SetReturned'
and ServicePlaceDate between DATEADD(day,-{0},'{1}') and '{1}'
 and SM.ServicePointID={2}
group by SM.IME
having COUNT(*)>1
) X join ServiceMaster SM on Sm.ServiceID=X.ServiceID_next", penaltyDay, toDate, servicePointId);
            SqlDataAdapter receiverDataAdapter = new SqlDataAdapter(receiverBounceQuery, sqlConnection);
            receiverDataAdapter.SelectCommand.Transaction = transaction;
            receiverDataAdapter.SelectCommand.CommandTimeout = 6000;
            DataTable receiverTable = new DataTable();
            receiverDataAdapter.Fill(receiverTable);
            foreach (DataRow dr in receiverTable.Rows)
            {
                long ServiceID_previous = Convert.ToInt64(dr["ServiceID_previous"]);
                long ServiceID_next = Convert.ToInt64(dr["ServiceID_next"]);
                long receiverId = Convert.ToInt64(dr["receiverId"]);


                var insertReceiverPenlaty = String.Format(@" insert into incentive_receiver_penalties([incentive_master_id],[receiver],[serviceid_previous],[serviceid_next]) values({0},{1},{2},{3})", incentive_master_id, receiverId, ServiceID_previous, ServiceID_next);
                var insertCommand = new SqlCommand(insertReceiverPenlaty, sqlConnection, transaction);
                insertCommand.ExecuteNonQuery();
            }

        }

        public static void CalculateCorporateBounce(int servicePointId, string fromDate, string toDate, SqlConnection sqlConnection, long incentive_master_id, SqlTransaction transaction)
        {

            string corporateBounceQuery =
                String.Format(@"select X.ServiceID,X.ServicePointID,X.Model,Y.Price 
from
(
	select * from ServiceMaster where ServiceStatus='Replacement'   and 
UpdatedDate between '{0}' and '{1}' and ServicePointID={2}
) X join
(
	select * from RBSYNERGY.dbo.tblCellPhonePricing 
) Y
on X.Model=Y.Model
where X.Model not like '%WPB%'", fromDate, toDate, servicePointId);
            SqlDataAdapter corporateDataAdapter = new SqlDataAdapter(corporateBounceQuery, sqlConnection);
            corporateDataAdapter.SelectCommand.Transaction = transaction;
            corporateDataAdapter.SelectCommand.CommandTimeout = 6000;
            DataTable corporateTable = new DataTable();
            corporateDataAdapter.Fill(corporateTable);
            foreach (DataRow dr in corporateTable.Rows)
            {
                long ServiceID = Convert.ToInt64(dr["ServiceID"]);
                try
                {
                    double Price = Convert.ToInt64(dr["Price"]);


                    var insertCorporatePenlaty = String.Format(@" insert into incentive_corporate_penalties([incentive_master_id],[serviceId],[cell_current_price]) values({0},{1},{2})", incentive_master_id, ServiceID, Price);
                    var insertCommand = new SqlCommand(insertCorporatePenlaty, sqlConnection, transaction);
                    insertCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {


                }

            }

        }
    }
}
