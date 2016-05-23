using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.AngularJS
{
    public class Items
    {
        public int Id { get; set; }
        public String Name { get; set; }

    }
    public partial class ListOfItemsByAngularJSAjaxNgRepeat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Items> GetItemList(int id)
        {
            List<Items> itemses=new List<Items>();
            Items items = new Items
            {
                Id = 1,
                Name = "cake"
            };
            itemses.Add(items);
            items = new Items
            {
                Id = 2,
                Name = "banaa"
            };
            itemses.Add(items);
            return itemses;
        }
        [WebMethod]
        public static List<Items> RemoveItemList(int id)
        {
            List<Items> itemses = new List<Items>();
            Items items = new Items
            {
                Id = 1,
                Name = "cake"
            };
            itemses.Add(items);
            items = new Items
            {
                Id = 2,
                Name = "banaa"
            };
            //itemses.Add(items);
            return itemses;
        }
    }
}