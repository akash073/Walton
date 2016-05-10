using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.jQueryAjax
{
    public partial class jQueryAjaxForStack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string copyData(string name, string msg, string sing_cal1, string timepick, string timepickst, string sing_cal4, string step)
        {
            //if (step == "3")
            //{
            //    if (HttpContext.Current != null)
            //    {
            //        Page page = (Page)HttpContext.Current.Handler;
            //        TextBox txtCampaignNameEditC = (TextBox)page.FindControl("txtCampaignNameEdit");
            //        TextBox txtMsgEditC = (TextBox)page.FindControl("txtMsgEdit");
            //        TextBox txtSentFromC = (TextBox)page.FindControl("txtSentFrom");
            //        Label lblScheduledTimeC = (Label)page.FindControl("lblScheduledTime");


            //        txtCampaignNameEditC.Text = name; // Here I am getting error as "Object reference not set to an instance of an object."
            //    }

            //}

            return "";
        }
    }
}