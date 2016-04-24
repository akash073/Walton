using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Services;

using StackOverflow_Solve.DAL;


namespace StackOverflow_Solve.jQueryUIAutocomplete
{
    public class Select2Data
    {
        public long id { get; set; }
        public String text { get; set; }
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static List<Select2Data> getSpareParts(string searchsearchString)
        {
            //q	2term	2
            var db = new WaltonCrmEntities();
            var dataOfSelect = db.SpareParts.Select(x => new Select2Data
            {
                id = x.ItemID,
                text = x.ItemName
            }).ToList();
            JavaScriptSerializer js = new JavaScriptSerializer();
            return dataOfSelect;

        }
    }
}