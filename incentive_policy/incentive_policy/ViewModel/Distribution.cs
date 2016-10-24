using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class Distribution
    {
        /*
         ,[cellphone_incharge]
      ,[corporate]
      ,[technician]
      ,[main_incharge]
      ,[others]
         */
        //public double cellphone_incharge { get; set; }
        //public double corporate { get; set; }
        //public double technician { get; set; }
        //public double main_incharge { get; set; }
        //public double others { get; set; }

        //public Distribution(SqlConnection connection)
        //{
        //    long currentDistribution = GetMaxDistribution(connection);


        //}
        public static long GetMaxDistribution(SqlConnection sqlConnection,SqlTransaction transaction)
        {
            long maxid = 0;
            string maxDistributionQuery = String.Format(@"SELECT MAX([incentive_distribution_percentage_id]) as maxid
      
  FROM [WSMS].[dbo].[incentive_distribution_percentages]");
            SqlDataAdapter distributionAdapter=new SqlDataAdapter(maxDistributionQuery,sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            DataTable maxDistributionTable=new DataTable();
            distributionAdapter.Fill(maxDistributionTable);
            foreach (DataRow dr in maxDistributionTable.Rows)
            {
                maxid = Convert.ToInt64(dr["maxid"]);
            }

            return maxid;
        }
    }
}
