using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Employee_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void thesis_click(object sender, EventArgs e)
        {
            Response.Redirect("EmpThesisGrade.aspx");

        }

        protected void defense_click(object sender, EventArgs e)
        {
            Response.Redirect("EmpGradeDefense.aspx");

            
        }

        protected void pr_click(object sender, EventArgs e)
        {
            Response.Redirect("EmpProgressReport.aspx");

       
        }
    }
}