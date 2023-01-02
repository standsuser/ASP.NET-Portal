using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Lecturer_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void creatproj_click(object sender, EventArgs e)
        {
            Response.Redirect("CreatingBP.aspx");

        }

        protected void deadline_click(object sender, EventArgs e)
        {
            Response.Redirect("5b.aspx");

        }

        protected void createmeeting_click(object sender, EventArgs e)
        {
            Response.Redirect("5c.aspx");

        }

        protected void addtodo_click(object sender, EventArgs e)
        {
            Response.Redirect("5d.aspx");

        }

        protected void viewmeetings_click(object sender, EventArgs e)
        {
            Response.Redirect("5e.aspx");

        }

        protected void viewEE_click(object sender, EventArgs e)
        {
            Response.Redirect("5f.aspx");

        }

        protected void recEE_click(object sender, EventArgs e)
        {
            Response.Redirect("5g.aspx");

        }

        protected void supervise_click(object sender, EventArgs e)
        {
            Response.Redirect("5h.aspx");

        }

        protected void gradethesis_click(object sender, EventArgs e)
        {
            Response.Redirect("5i.aspx");

        }

        protected void gradedefense_click(object sender, EventArgs e)
        {
            Response.Redirect("5j.aspx");

        }

        protected void createPR_click(object sender, EventArgs e)
        {
            Response.Redirect("5k.aspx");

        }

        protected void gradePR_click(object sender, EventArgs e)
        {
            Response.Redirect("5l.aspx");

        }
    }
}