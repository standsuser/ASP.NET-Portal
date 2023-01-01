using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Student_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void makepref_click(object sender, EventArgs e)
        {
            Response.Redirect("Make-Pref.aspx");

        }

        protected void viewthesis_click(object sender, EventArgs e)
        {
            Response.Redirect("View-My-Thesis.aspx");

        }

        protected void submitthesis_click(object sender, EventArgs e)
        {
            Response.Redirect("Submit-My-Thesis.aspx");

        }

        protected void viewpr_click(object sender, EventArgs e)
        {
            Response.Redirect("View-My-PR.aspx");

        }

        protected void viewdefense_click(object sender, EventArgs e)
        {
            Response.Redirect("View-My-Defense.aspx");

        }

        protected void updatedefense_click(object sender, EventArgs e)
        {
            Response.Redirect("Update-My-Defense.aspx");

        }

        protected void viewbpgrade_click(object sender, EventArgs e)
        {
            Response.Redirect("View-BP-Grade.aspx");

        }

        protected void viewnotbooked_click(object sender, EventArgs e)
        {
            Response.Redirect("View-Unbooked.aspx");

        }

        protected void book_click(object sender, EventArgs e)
        {
            Response.Redirect("Book-Meeting.aspx");

        }

        protected void viewbook_click(object sender, EventArgs e)
        {
            Response.Redirect("View-Meeting.aspx");

        }

        protected void todo_click(object sender, EventArgs e)
        {
            Response.Redirect("Student-AddToDo.aspx");
        }
    }
}