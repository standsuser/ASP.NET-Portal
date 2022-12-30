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
    public partial class EmpThesisGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EmployeeGradeThesis(object sender, EventArgs e)
        {

            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec EmployeeGradeThesis @Employee_id=@emp_id,@sid=@s_sid,@thesis_title=@t_title,@Employee_grade=@emp_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@emp_id", emp_id.Text);
                comm.Parameters.AddWithValue("@s_sid", s_sid.Text);
                comm.Parameters.AddWithValue("@t_title", t_title.Text);
                comm.Parameters.AddWithValue("@emp_grade", emp_grade.Text);
                sqlconn.Open();

                comm.ExecuteNonQuery();

                int id = Convert.ToInt32(comm.ExecuteScalar());


                if (id == 1)
                {
                    Response.Write("<script>alert('Student Assigning Succesful!')</script>");


                }
                else if (id == 0)
                {
                    Response.Write("<script>alert('Failed to Assign Students. Please check your information.')</script>");

                }


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to make preference. Please check your information.')</script>");


            }
        }

    }
}