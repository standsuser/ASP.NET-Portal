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
    public partial class _5k : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LecCreatePR5k(object sender, EventArgs e)
        {
 
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec  LecCreatePR @Lecturer_id = @L_id,    @sid = @s_id ,    @date = @d,   @content = @c ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@L_id", L_id.Text);
                comm.Parameters.AddWithValue("@s_id", s_id.Text);
                comm.Parameters.AddWithValue("@d", Convert.ToDateTime(d.Text));
                comm.Parameters.AddWithValue("@c", c.Text);
               


                sqlconn.Open();

                comm.ExecuteNonQuery();


            
                    Response.Write("<script>alert('Progress Report created Succesfully!')</script>");



                sqlconn.Close();



        }
    }
}
