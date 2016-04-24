using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using StackOverflow_Solve.DAL;
using StackOverflow_Solve.select2;

namespace StackOverflow_Solve
{
    public class data
    {
        public long id { get; set; }
        public String text { get; set; }
    }
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Sum(string []a)
        {
            string b = "12";
            return (Convert.ToInt64(a[0]) + Convert.ToInt64(a[1])).ToString();
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)] 
        public List<data> getSpareParts(string value)
        {
            List<data> spareParts;
            //q	2term	2
            using ( var db = new WaltonCrmEntities())
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
