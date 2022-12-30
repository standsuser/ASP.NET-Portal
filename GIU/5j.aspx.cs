using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class _5j : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LecGradedefense5j(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec  LecGradedefense @Lecturer_id = @L_id, @sid = @s_id ,@defense_location= @DL, @Lecturer_grade =@LG";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@L_id", L_id.Text);
                comm.Parameters.AddWithValue("@ @s_id", @s_id.Text);
                comm.Parameters.AddWithValue("@DL", DL.Text);
                comm.Parameters.AddWithValue("@LG", LG.Text);


                sqlconn.Open();

                comm.ExecuteNonQuery();


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
 