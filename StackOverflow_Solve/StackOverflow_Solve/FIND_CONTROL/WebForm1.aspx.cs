using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.FIND_CONTROL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            UpdateTimeLog("1");
        }

        public void UpdateTimeLog(string input)
        {
            string timeNumber = "txtTime" + input;
           // TextBox myTextbox = (TextBox)FindControl(timeNumber);
            Control[] allControls = FlattenHierachy(Page);
            foreach (Control control in allControls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null && textBox.ID == timeNumber)
                {
                    textBox.Text = "Hello";
                }
            }

          //Rest is ommited
        }
        public static Control[] FlattenHierachy(Control root)
        {
            List<Control> list = new List<Control>();
            list.Add(root);
            if (root.HasControls())
            {
                foreach (Control control in root.Controls)
                {
                    list.AddRange(FlattenHierachy(control));
                }
            }
            return list.ToArray();
        }
    }
}