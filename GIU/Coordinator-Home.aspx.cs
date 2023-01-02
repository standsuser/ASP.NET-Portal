using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Coordinator_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void seeuser_click(object sender, EventArgs e)
        {
            Response.Redirect("CoSeeAll.aspx");

        }

        protected void assignstudents_click(object sender, EventArgs e)
        {
            Response.Redirect("AssignStudentToProject.aspx");

        }
    }
}