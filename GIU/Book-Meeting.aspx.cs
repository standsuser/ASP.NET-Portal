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
    public partial class Book_Meeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void book_Click(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string command = "EXEC BookMeeting @sid= @studentid, @meeting_id=@meetingid";
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);

                sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);
                sqlcomm.Parameters.AddWithValue("@meetingid", meetingidbox.Text);




                sqlconn.Open();


                int i = sqlcomm.ExecuteNonQuery();


                if (i != 0)
                {

                    Response.Write("<script>alert('Meeting Booked Successfully.')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Failed to Book Meeting. Please make sure all your entered data is correct.')</script>");

                }
                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed to Book Meeting. Please make sure all your entered data is correct.')</script>");


            }
        }
    }
}