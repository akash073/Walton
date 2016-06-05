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
    /// <summary>
    /// Summary description for SpareInfos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SpareInfos : System.Web.Services.WebService
    {

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
