using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;
using StackOverflow_Solve.select2;

public partial class DATATABLE_plugin_CHOSEN : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static List<Select2Data> getSpareParts(string search, string page)
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