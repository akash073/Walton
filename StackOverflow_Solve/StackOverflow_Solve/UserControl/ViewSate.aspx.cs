using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.UserControl
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }

    }
    public partial class ViewSate : System.Web.UI.Page
    {
        private List<Student> students;

        public List<Student> Collection()
        {
            students = new List<Student>
    {
        new Student {Id = 1, Name = "Name1"},
        new Student {Id = 2, Name = "Name2"},
        new Student {Id = 3, Name = "Name3"},
    };
            return students;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Student> students = Collection();
           // ViewState["students"] = students;
            HttpCookie myCookie = new HttpCookie("MyTestCookie");
            DateTime now = DateTime.Now;
            JavaScriptSerializer serializer=new JavaScriptSerializer();
            var data = serializer.Serialize(students);
            // Set the cookie value.
            myCookie.Value = data;
            // Set the cookie expiration date.
            myCookie.Expires = now.AddHours(1); // For a cookie to effectively never expire

            // Add the cookie.
            Response.Cookies.Add(myCookie);

            //Response.Write("<p> The cookie has been written.");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["MyTestCookie"];
            IList<Student> persons = new JavaScriptSerializer()
                .Deserialize<IList<Student>>(myCookie.Value);

        }
    }
}