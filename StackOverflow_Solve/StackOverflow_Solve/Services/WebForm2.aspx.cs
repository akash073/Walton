using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackOverflow_Solve.UserControl;

namespace StackOverflow_Solve.Services
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String json = "{ \"Id\": 123, \"FirstName\": \"fName\", \"LastName\": \"lName\" }";

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Student student = serializer.Deserialize<Student>(json);

            List<Student> students = new List<Student>();
            students.Add(student);


            String serializedStudentList = serializer.Serialize(students);
            var d = serializedStudentList;

            students = serializer.Deserialize<List<Student>>(serializedStudentList);

            var s = students;
        }
    }
}