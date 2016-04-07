using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.VerifyJS
{
    public partial class verify_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = 0;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("PSOTBACK");
            Label3.Text = TextBox1.Text;
            Label2.Text = TextBox2.Text;
        }
    }
}