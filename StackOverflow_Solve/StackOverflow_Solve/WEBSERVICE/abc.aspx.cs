using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.WEBSERVICE
{
    public partial class abc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string MyFunction1(string parameter)
        {
            //try
            //{
            //    if (true)
            //    {
            //        return "test";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
            return parameter;
        }
    }
}