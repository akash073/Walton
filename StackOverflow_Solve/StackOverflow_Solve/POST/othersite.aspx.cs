using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.POST
{
    public class personnel
    {
        public String Name { get; set; }
        public String Family { get; set; }
        public String EmployTypecode { get; set; }
        public String employtypeName { get; set; }
        public String EmplytyppeTye { get; set; }
    }
    public partial class ReceivePostData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String email = Request["email"];
            String password = Request["password"];

            using (var dataContext=new WaltonCrmEntities())
            {
                
                

            }
        }
    }
}