using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.DATATABLE
{
    public class Box
    {
        public double length { get; set; }   // Length of a box
        public double breadth { get; set; }  // Breadth of a box
        public double height { get; set; }   // Height of a box
    }
    public partial class DatatableRefreshedByTimeInterValAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Box> GetBoxes()
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box();   // Declare Box2 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            // box 2 specification
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            List<Box> boxs=new List<Box>();
            boxs.Add(Box1);
            boxs.Add(Box2);
            return boxs;
        } 
    }
}