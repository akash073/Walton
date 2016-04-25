using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.telericUI
{
    public partial class autocompletWithWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static string getSpareParts()
        {
            List<String> spareParts;
            using (var db = new WaltonCrmEntities())
            {
                spareParts = db.SpareParts.Select(x =>x.ItemName).ToList();
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(spareParts);
            //return spareParts;

        }
    }
}