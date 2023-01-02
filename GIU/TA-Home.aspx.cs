using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class TA_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PR_click(object sender, EventArgs e)
        {
            Response.Redirect("TACreatePR.aspx");
        }

        protected void addtodo_click(object sender, EventArgs e)
        {
            Response.Redirect("TAAddToDo.aspx");

        }
    }
}