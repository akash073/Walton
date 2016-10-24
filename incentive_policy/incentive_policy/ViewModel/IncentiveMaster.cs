using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class IncentiveMaster
    {
        /*
         ,[servicepointId]
      ,[incentive_distribution_percentage_id]
      ,[incentive_limit_id]
      ,[incentive_rate_id]
      ,[calculated_date]
         */

        public static long InsertIntoMasterTable(int servicepointId, long incentive_distribution_percentage_id,
            long incentive_limit_id, long incentive_rate_id, string calculated_date,SqlConnection con,SqlTransaction transaction)
        {
            long newID;
            var insertcmd = @"INSERT INTO incentive_master ([servicepointId]
      ,[incentive_distribution_percentage_id]
      ,[incentive_limit_id]
      ,[incentive_rate_id]
      ,[calculated_date])VALUES (@servicepointId,@incentive_distribution_percentage_id,@incentive_limit_id,@incentive_rate_id,@calculated_date);SELECT CAST(scope_identity() AS bigint)";
            using (var insertCommand = new SqlCommand(insertcmd, con, transaction))
            {
                insertCommand.Parameters.AddWithValue("@servicepointId", servicepointId);
                insertCommand.Parameters.AddWithValue("@incentive_distribution_percentage_id", incentive_distribution_percentage_id);
                insertCommand.Parameters.AddWithValue("@incentive_limit_id", incentive_limit_id);
                insertCommand.Parameters.AddWithValue("@incentive_rate_id", incentive_rate_id);
                insertCommand.Parameters.AddWithValue("@calculated_date", calculated_date);
                newID = (long)insertCommand.ExecuteScalar();
            }
            return newID;
        }
    }
}
