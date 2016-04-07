using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.POST
{
    public partial class ReceivePostData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String email = Request["email"];
            String password = Request["password"];

        }
    }
}