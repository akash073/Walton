using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class ServicePoints
    {
        public static List<int> GetServicePointsId(SqlConnection sqlConnection,SqlTransaction transaction)
        {
            var servicePoints=new List<int>();
            string servicePointQuery = String.Format(@"SELECT [ServicePointID]
      
  FROM [WSMS].[dbo].[ServicePoint]");
            SqlDataAdapter distributionAdapter = new SqlDataAdapter(servicePointQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            DataTable servicePointTable = new DataTable();
            distributionAdapter.Fill(servicePointTable);
            foreach (DataRow dr in servicePointTable.Rows)
            {
                int ServicePointID = Convert.ToInt32(dr["ServicePointID"]);
                servicePoints.Add(ServicePointID);
            }

            return servicePoints;
        }
    }
}
