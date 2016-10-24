using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class Technician
    {/*
      
            ,[incentive_master_Id]
      ,[techinican_id]
      ,[total_phone_distributable]
      ,[total_phone_nondistributable]
      
      
      */

        public static void CalculateTechnicianAmmount(int servicePointId, string fromDate, string toDate, SqlConnection sqlConnection,
             long incentive_master_id,SqlTransaction transaction)
        {
            string totalTechQuery = String.Format(@"select TechnicianID,count(*) as total_phone_distributable,(
					select COUNT(*) 
					from ServiceIssue SI
					where ServiceID in (
							select SM.ServiceID 
							from ServiceMaster Sm,ServiceTimeLog STL
							where Sm.ServiceID=Stl.ServiceID
							and Sm.ServicePointID={0}
							and STL.QCReleaseStatus='QCPassed' 
							and QCEndTime between '{1}' and '{2}'
					)
					and Si.IssueID in (6,20,27,16,15)
					and TechnicianID=STL.TechnicianID
) as total_phone_nondistributable
from ServiceMaster Sm,ServiceTimeLog STL
where Sm.ServiceID=Stl.ServiceID
and Sm.ServicePointID={0}
and STL.QCReleaseStatus='QCPassed' 
and QCEndTime between '{1}' and '{2}'
group by TechnicianID ",servicePointId, fromDate, toDate);

            SqlDataAdapter distributionAdapter = new SqlDataAdapter(totalTechQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            distributionAdapter.SelectCommand.CommandTimeout = 6000;
            DataTable techTable = new DataTable();
            distributionAdapter.Fill(techTable);
            foreach (DataRow dr in techTable.Rows)
            {
                int TechnicianID = Convert.ToInt32(dr["TechnicianID"]);
                int total_phone_distributable = Convert.ToInt32(dr["total_phone_distributable"]);
                int total_phone_nondistributable = Convert.ToInt32(dr["total_phone_nondistributable"]);

                var insertTechcmd = String.Format(@"INSERT INTO incentive_technicians ([incentive_master_Id],[techinican_id],[total_phone_distributable],[total_phone_nondistributable]) VALUES ({0},{1},{2},{3})", incentive_master_id, TechnicianID, total_phone_distributable, total_phone_nondistributable);
                SqlCommand insertCommand = new SqlCommand(insertTechcmd, sqlConnection, transaction);
                insertCommand.ExecuteNonQuery();

            }
        }
    }
}
