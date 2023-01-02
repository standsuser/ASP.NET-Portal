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

        protected void assignTA_click(object sender, EventArgs e)
        {
            Response.Redirect("AssignTAToProject.aspx");

        }

        protected void EERec_click(object sender, EventArgs e)
        {
            Response.Redirect("ViewRecLec.aspx");

        }

        protected void AssignEE_click(object sender, EventArgs e)
        {
            Response.Redirect("AssignEE.aspx");

        }

        protected void scheduledef_click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleDef.aspx");

        }
    }
}