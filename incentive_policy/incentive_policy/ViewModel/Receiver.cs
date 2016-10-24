using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class Receiver
    {
        private int total_receive;
        private int receiver;
        public static void CalculateReceiverAmmount(int servicePointId, string fromDate, string toDate, SqlConnection connection, long incentive_master_id,SqlTransaction transaction)
        {
            //String 
            #region ReceiveAmmount
            DataTable receiveTable=new DataTable();
            String recieveQuery = String.Format(@"  select AddedBy as receiver,COUNT(*) As total_receive,(
				select ISNULL(SUM(X.Software),0) from (
				select ServiceID,ISNULL(COUNT(*),0) as Software
				from ServiceIssue 
				where (IssueID =27 or IssueID=35 or IssueID=26)
                and IssueID!=0
				and ServiceID in 
				(
						select ServiceID from ServiceMaster SSm 
						where SSm.AddedBy=sm.AddedBy
						and SSm.ServicePlaceDate between '{0}' and '{1}'
                        and SSm.AddedBy is not null
				 )
				  Group By ServiceID
				 ) X
  ) as total_software,
  (
				select COUNT(*)
				from ServiceMaster SSMM
				where DATEDIFF(Hour,ServicePlaceDate,DeliveryDate)<=24
				and SSMM.ServicePlaceDate between '{0}' and '{1}'
				and SSMM.AddedBy=Sm.AddedBy
                and SSMM.AddedBy is not null
  ) as total_24_delivery

from ServiceMaster Sm
where Sm.ServicePlaceDate between '{0}' and '{1}'
and ServicePointId={2}
and AddedBy is not null
and AddedBy<>''
Group by AddedBy", fromDate,toDate,servicePointId);
            var receiveAdapter=new SqlDataAdapter(recieveQuery,connection);
            receiveAdapter.SelectCommand.Transaction = transaction;
            receiveAdapter.SelectCommand.CommandTimeout = 6000;
            receiveAdapter.Fill(receiveTable);

            foreach (DataRow dr in receiveTable.Rows)
            {/*
              * SELECT 
      ,[incentive_master_id]==from param
      ,[receiver]
      ,[total_receive]
      ,[total_software]
      ,[total_24_delivery]
  FROM [WSMS].[dbo].[incentive_receivers]
              */
                int receiver = Convert.ToInt32(dr["receiver"]);
                int total_receive = Convert.ToInt32(dr["total_receive"]);

                int total_software = Convert.ToInt32(dr["total_software"]);
                int total_24_delivery = Convert.ToInt32(dr["total_24_delivery"]);
                string insertQuery = String.Format(@"insert into incentive_receivers([incentive_master_id],[receiver],[total_receive],[total_software],[total_24_delivery]) values({0},{1},{2},{3},{4})", incentive_master_id, receiver, total_receive, total_software, total_24_delivery);
                var insertReceiverCommand = new SqlCommand(insertQuery, connection, transaction);
                insertReceiverCommand.ExecuteNonQuery();
                
            }

            #endregion
        }
    }
}
