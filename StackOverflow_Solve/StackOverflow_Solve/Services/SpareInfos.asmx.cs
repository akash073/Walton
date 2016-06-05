using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.Services
{
    public class DropDownListBinding
    {
        public long Id { get; set; }
        public String ItemName { get; set; }
    }
    /// <summary>
    /// Summary description for SpareInfos
    /// </summary>
   // [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SpareInfos : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetDropDownListBindings()
        {
            List<DropDownListBinding> downList;
            using (var db = new WaltonCrmEntities())
            {
                downList = db.SpareParts.Where(x => x.ItemID < 100).Select(x => new DropDownListBinding
                {
                    Id = x.ItemID,
                    ItemName = x.ItemName + "_" + x.ItemCode
                }).ToList();
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            HttpContext.Current.Response.Write(js.Serialize(downList));
            //return js.Serialize(downList);
        }
        
        
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public String getSpareParts()
        {

            List<String> spareParts;
            //q	2term	2
            using (var db = new WaltonCrmEntities())
            {
                spareParts = db.SpareParts.Select(x => x.ItemName).Take(1000).ToList();
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(spareParts);
            //return spareParts;

        }
    }
}
