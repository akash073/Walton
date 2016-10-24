using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class Limits
    {
        public static long GetMaxLimitId(SqlConnection sqlConnection,SqlTransaction transaction)
        {
            long maxlimitid = 0;
            string maxDistributionQuery = String.Format(@"SELECT max([incentive_limit_id]) as maxlimitid
      
  FROM [WSMS].[dbo].[incentive_limits]");
            SqlDataAdapter distributionAdapter = new SqlDataAdapter(maxDistributionQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            DataTable maxDistributionTable = new DataTable();
            distributionAdapter.Fill(maxDistributionTable);
            foreach (DataRow dr in maxDistributionTable.Rows)
            {
                maxlimitid = Convert.ToInt64(dr["maxlimitid"]);
            }

            return maxlimitid;
        }
        public static long GetpenaltydayLimit(long incentiveLimitID, SqlConnection sqlConnection,SqlTransaction transaction)
        {
            long penaltyDay = 0;
            string maxDistributionQuery = String.Format(@"SELECT penalty_day
      
  FROM [WSMS].[dbo].[incentive_limits] where incentive_limit_id={0}",incentiveLimitID);
            SqlDataAdapter distributionAdapter = new SqlDataAdapter(maxDistributionQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            DataTable maxDistributionTable = new DataTable();
            distributionAdapter.Fill(maxDistributionTable);
            foreach (DataRow dr in maxDistributionTable.Rows)
            {
                penaltyDay = Convert.ToInt64(dr["penalty_day"]);
            }

            return penaltyDay;
        }
    }
}
