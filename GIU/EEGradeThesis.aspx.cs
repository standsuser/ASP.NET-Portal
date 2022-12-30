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
    public partial class EEGradeThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GradeThesis(object sender, EventArgs e)
        {
  
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "EXEC EEGradeThesis @EE_id = @ee_id, @sid = @student_id , @thesis_title = @tt, @EE_grade = @ee_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);

                comm.Parameters.AddWithValue("@ee_id", ee_id.Text);
                comm.Parameters.AddWithValue("@student_id", student_id.Text);
                comm.Parameters.AddWithValue("@tt", tt.Text);
                comm.Parameters.AddWithValue("@ee_grade", ee_grade.Text);

                sqlconn.Open();
                comm.ExecuteNonQuery();
                sqlconn.Close();    
            }
            }
}