using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class EmpGradeDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Emp_GradeDefense(object sender, EventArgs e)
        {

            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec EmployeeGradedefense @Employee_id=@e_eid,@sid=@s_sid,@defense_location=@d_location,@Employee_grade=@emp_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@e_eid", e_eid.Text);
                comm.Parameters.AddWithValue("@s_sid", s_sid.Text);
                comm.Parameters.AddWithValue("@d_location", d_location.Text);
                comm.Parameters.AddWithValue("@emp_grade", emp_grade.Text);
                sqlconn.Open();

                comm.ExecuteNonQuery();

                int id = Convert.ToInt32(comm.ExecuteScalar());


           
                    Response.Write("<script>alert('Grading Defense Successful!')</script>");


              

                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Grade Defense. Please check your information.')</script>");


            }
        }

    }
}