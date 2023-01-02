using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Company_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addemp_click(object sender, EventArgs e)
        {

            Response.Redirect("Add-Employee.aspx");



        }

        protected void creatproj_click(object sender, EventArgs e)
        {
            Response.Redirect("Create-Local-Project.aspx");


        }

        protected void assignemp_click(object sender, EventArgs e)
        {
            Response.Redirect("assignEmp.aspx");

        }

        protected void thesis_click(object sender, EventArgs e)
        {
            Response.Redirect("thesisGrade.aspx");
        }

        protected void defense_click(object sender, EventArgs e)
        {
            Response.Redirect("GradeDefense.aspx");

        }

        protected void pr_click(object sender, EventArgs e)
        {
            Response.Redirect("GradeProgressReport.aspx");

        }
    }
}