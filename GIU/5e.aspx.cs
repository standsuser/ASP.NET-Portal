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
    public partial class _5e : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ViewMeetingLecturer5e(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec ViewMeetingLecturer @Lecturer_id=@L_id, @meeting_id = @m_id ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue(" @L_id", L_id.Text);
                comm.Parameters.AddWithValue(" @m_id", m_id.Text);



                sqlconn.Open();

                comm.ExecuteNonQuery();
                SqlDataReader reader = comm.ExecuteReader();
              

                int id = Convert.ToInt32(comm.ExecuteScalar());


                if (id == 1)
                {
                    Response.Write("<script>alert('Project created Succesfully!')</script>");

                }
                else if (id == 0)
                {
                    Response.Write("<script>alert('Project creation failed. Please check your information.')</script>");

                }


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('error!')</script>");


            }


        }
    }
}