using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.FileDownload
{
    public partial class StoredProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var email = "1";
            var connectionString = ConfigurationManager.ConnectionStrings["WSMSConnectionString"].ToString();
            GetUser(email,connectionString);

        }
        public void GetUser(string email, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetRegisterUsers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();

                param = cmd.Parameters.Add("@email", SqlDbType.NVarChar);
               param.Direction = ParameterDirection.Input;
               param.Value = email;
                
                
                conn.Open();
                try
                {
                    var reader = cmd.ExecuteReader();
                    String returnValue = String.Empty;
                    while (reader.Read())
                    {
                       returnValue =Convert.ToString( reader.GetValue(0));
                       break;
                    }
                    Console.WriteLine(returnValue);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}