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
    public partial class EEGradeDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GradeDefense(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "EXEC EEGradeDefense @EE_id = @ee_id, @sid = @student_id , @defense_location = @dl, @EE_grade = @ee_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);

                comm.Parameters.AddWithValue("@ee_id", ee_id.Text);
                comm.Parameters.AddWithValue("@student_id", student_id.Text);
                comm.Parameters.AddWithValue("@dl", dl.Text);
                comm.Parameters.AddWithValue("@ee_grade", ee_grade.Text);

                sqlconn.Open();
                comm.ExecuteNonQuery();
                Response.Write("<script>alert('Defense Graded Succesfully!')</script>");

                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed To Grade Defens. Check the Information')</script>");

            }

        }
    }
}