using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.telericUI
{
    public partial class Autocomplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)] 
        public static List<data> getSpareParts(string value)
        {
            List<data> spareParts;
            using (var db = new WaltonCrmEntities())
            {
                spareParts = db.SpareParts.Select(x => new data
                {
                    id = x.ItemID,
                    text = x.ItemName
                }).ToList();
            }
            return spareParts;

        }
    }
}