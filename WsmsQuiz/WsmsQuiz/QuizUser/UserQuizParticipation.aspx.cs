using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WsmsQuiz.QuizUser
{
    public partial class UserQuizParticipation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var div = new Panel();
            div.Controls.Add(new LiteralControl("<h1>hallo</h1>"));
            div.Controls.Add(new Image());
            phDynamicQuestion.Controls.Add(div);
        }
    }
}