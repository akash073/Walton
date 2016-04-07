using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FILEDOWNLOAD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = "~/Files/Mastering MeteorJS Application Development.pdf";
            String _fileName = "akash";
            string path = MapPath(filename);
            //byte[] bts = System.IO.File.ReadAllBytes(path);
            Response.Buffer = true;
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition:", "attachment;filename=" + _fileName + ".pdf");
            Response.TransmitFile(path);
            //Response.Close();
        }
    }
}