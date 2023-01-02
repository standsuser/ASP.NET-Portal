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
    public partial class _5l : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LecGradePR5l(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec  LecGradePR @Lecturer_id = @L_id,    @sid = @s_id ,    @date = @d,   @lecturer_grade = @LG";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@L_id", L_id.Text);
                comm.Parameters.AddWithValue("@s_id", s_id.Text);
                comm.Parameters.AddWithValue("@d", Convert.ToDateTime(d.Text));
                comm.Parameters.AddWithValue("@LG", LG.Text);



                sqlconn.Open();

                comm.ExecuteNonQuery();


          
                    Response.Write("<script>alert('Graded Progress Report Succesfully!')</script>");



                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Grade Progress Report. Please Check Your Information')</script>");


            }




        }
    }
}
