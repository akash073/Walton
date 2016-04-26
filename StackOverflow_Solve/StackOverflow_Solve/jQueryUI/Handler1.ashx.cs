using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using StackOverflow_Solve.DAL;

namespace StackOverflow_Solve.jQueryUI
{
    [Serializable]
    public class data
    {
        public long id { get; set; }
        public String text { get; set; }
    }
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {


        public void ProcessRequest(HttpContext context)
        {

            List<data> search;
            using (var db = new WaltonCrmEntities())
            {
                var spareParts =
                    db.SpareParts.Select(x => new data
                    {
                        id = x.ItemID,
                        text = x.ItemName
                    }).ToList();
                search = spareParts;
            }
            if (context.Request.QueryString["term"] != null)
            {
                var term = context.Request.QueryString["term"].ToString();

                context.Response.Clear();
                context.Response.ContentType = "application/json";
                
                //q	2term	2

                search = search.Where(x => x.text.ToLower().Contains(term)).ToList();
            }
            

        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        string json = jsSerializer.Serialize(search);
        context.Response.Write(json);
        context.Response.End();
    }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}