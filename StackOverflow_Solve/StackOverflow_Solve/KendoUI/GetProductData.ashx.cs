using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackOverflow_Solve.KendoUI
{
    public class DropDownListBinding
    {
        public long Id { get; set; }
        public String ItemName { get; set; }
    }
    /// <summary>
    /// Summary description for GetProductData
    /// </summary>
    public class GetProductData : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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