using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.FIXEDHEADERWITHDATATABLE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db=new WaltonCrmEntities())
            {
                var dataToBing = db.SpareParts.Take(1000).ToList();
                GridView1.DataSource = dataToBing;
                GridView1.DataBind();
            }
            GridView1.UseAccessibleHeader = true;
            GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
    }
}