using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.EMBERjs
{
    public partial class EmberJsForAsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<SparePart> ajaxcall(string text)
        {
            
            var spareParts = new WaltonCrmEntities().SpareParts.ToList();
            return spareParts;
        }
    }
}