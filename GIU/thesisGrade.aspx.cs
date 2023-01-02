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
    public partial class thesisGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void thesis_Grade(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec CompanyGradeThesis @Company_id = @c_cid, @sid= @s_id , @thesis_title= @t_title, @Company_grade=@c_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@c_cid", c_cid.Text);
                comm.Parameters.AddWithValue("@s_id", s_id.Text);
                comm.Parameters.AddWithValue("@t_title", t_title.Text);
                comm.Parameters.AddWithValue("@c_grade", c_grade.Text);
                sqlconn.Open();

                comm.ExecuteNonQuery();

            

                    Response.Write("<script>alert('Graded Thesis Successfully!')</script>");


            


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Grade Thesis. Please check your information.')</script>");


            }
        }



    }


    }
