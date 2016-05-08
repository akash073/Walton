using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WsmsQuiz.Admin
{
    public class JsGridData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Country { get; set; }
        public string Address { get; set; }
        public bool Married { get; set; }
    }

    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string GetGridData(JsGridData jsGridData)
        {
            return "Ok";
        }
    }
}