﻿using System;
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
    }
}