using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class Rate
    {
        public static long GetMaxRate(SqlConnection sqlConnection, SqlTransaction transaction)
        {
            long maxRateId = 0;
            string maxDistributionQuery = String.Format(@"SELECT MAX([incentive_rate_id]) as maxRateId
      
  FROM [WSMS].[dbo].[incentive_rates]");
            SqlDataAdapter distributionAdapter = new SqlDataAdapter(maxDistributionQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            DataTable maxDistributionTable = new DataTable();
            distributionAdapter.Fill(maxDistributionTable);
            foreach (DataRow dr in maxDistributionTable.Rows)
            {
                maxRateId = Convert.ToInt64(dr["maxRateId"]);
            }

            return maxRateId;
        }
    }
}
