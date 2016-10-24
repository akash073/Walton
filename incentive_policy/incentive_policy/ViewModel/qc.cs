using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incentive_policy.ViewModel
{
    class qc
    {
        public static void CalculateQcAmmount(int servicePointId, string fromDate, string toDate, SqlConnection sqlConnection,
            long incentive_master_id,SqlTransaction transaction)
        {
            string totalTechQuery = String.Format(@"select STL.QCID,count(*) as qc_total_phone
from ServiceMaster Sm,ServiceTimeLog STL
where Sm.ServiceID=Stl.ServiceID
and Sm.ServicePointID={0}
and STL.QCReleaseStatus='QCPassed' 
and QCEndTime between '{1}' and '{2}'
and STL.QCID is not null
group by STL.QCID ",servicePointId,fromDate,toDate);

            SqlDataAdapter distributionAdapter = new SqlDataAdapter(totalTechQuery, sqlConnection);
            distributionAdapter.SelectCommand.Transaction = transaction;
            distributionAdapter.SelectCommand.CommandTimeout = 6000;
            DataTable qcTable = new DataTable();
            distributionAdapter.Fill(qcTable);
            foreach (DataRow dr in qcTable.Rows)
            {
                int QCID = Convert.ToInt32(dr["QCID"]);
                int qc_total_phone = Convert.ToInt32(dr["qc_total_phone"]);


                var insertTechcmd = String.Format(@"INSERT INTO incentive_qcs ([incentive_master_id],[qc_id],[qc_total_phone]) VALUES ({0},{1},{2})", incentive_master_id, QCID, qc_total_phone);
                var insertCommand = new SqlCommand(insertTechcmd, sqlConnection, transaction);
                insertCommand.ExecuteNonQuery();

            }
        }
    }
}
