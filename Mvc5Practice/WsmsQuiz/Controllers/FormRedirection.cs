using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace WSMSCRM.Login
{
    public class FormRedirection
    {
       
        public void Post(string url,string userName,string password)
        {
            NameValueCollection collections = new NameValueCollection();
            collections.Add("userName", userName);
            collections.Add("password", password);
            //xyz
            //collections.Add("xyz", "xyz");
            //string remoteUrl = System.Web.VirtualPathUtility.ToAbsolute("~/Redirection/Redirected_to.aspx"); 
           // string remoteUrl = System.Web.VirtualPathUtility.ToAbsolute(url);
            string remoteUrl = url;

            string html = "<html><head>";
            html += "</head><body onload='document.forms[0].submit()'>";
            html += string.Format("<form name='PostForm' method='POST' action='{0}'>", remoteUrl);
            foreach (string key in collections.Keys)
            {
                html += string.Format("<input name='{0}' type='password' value='{1}'>", key, collections[key]);
            }
            html += "</form></body></html>";
           // System.Web.HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.ContentEncoding = Encoding.GetEncoding("ISO-8859-1");
            HttpContext.Current.Response.HeaderEncoding = Encoding.GetEncoding("ISO-8859-1");
            HttpContext.Current.Response.Charset = "ISO-8859-1";
            HttpContext.Current.Response.Write(html);
            HttpContext.Current.Response.End();
        }
    }
    
}