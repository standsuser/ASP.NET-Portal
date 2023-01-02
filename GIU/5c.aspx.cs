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
    public partial class _5c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void meetingcreation5c(object sender, EventArgs e)
        {
            try { 
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string maincommand = "Exec  CreateMeeting @Lecturer_id = @L_id , @start_time= @ST  , @end_time =@ET , @date =@d , @meeting_point = @MT ";

            SqlCommand comm = new SqlCommand(maincommand, sqlconn);
            comm.Parameters.AddWithValue("@L_id", L_id.Text);
            comm.Parameters.AddWithValue("@ST", Convert.ToDateTime(ST.Text));
            comm.Parameters.AddWithValue("@ET", Convert.ToDateTime(ET.Text));
            comm.Parameters.AddWithValue("@d", d.Text);
            comm.Parameters.AddWithValue("@MT", MT.Text);


            sqlconn.Open();

            comm.ExecuteNonQuery();






            Response.Write("<script>alert('Meeting created Succesfully!')</script>");








            sqlconn.Close();
        }
            catch
            {
                    Response.Write("<script>alert('Meeting creation failed. Please check your information.')</script>");

            }


        }
    }
}
