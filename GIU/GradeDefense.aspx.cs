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
    public partial class GradeDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CompanyGradedefense(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec CompanyGradedefense @Company_id =@c_cid, @sid=@s_sid, @defense_location=@d_location,@Company_grade= @c_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@c_cid", c_cid.Text);
                comm.Parameters.AddWithValue("@s_id", s_id.Text);
                comm.Parameters.AddWithValue("@d_location", d_location.Text);
                comm.Parameters.AddWithValue("@c_grade", c_grade.Text);
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
