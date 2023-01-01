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
    public partial class View_Meeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string command = "EXEC ViewMeeting @sid= @studentid, @meeting_id=@meetingid";
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);


                sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);

                if (String.Compare(meetingidbox.Text, "") == 0)
                    sqlcomm.Parameters.AddWithValue("@meetingid", DBNull.Value);
                else
                sqlcomm.Parameters.AddWithValue("@meetingid", meetingidbox.Text);




                sqlconn.Open();


               sqlcomm.ExecuteNonQuery();
                SqlDataReader reader = sqlcomm.ExecuteReader();
                booked.DataSource = reader;
                booked.DataBind();


                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed to Book Meeting. Please make sure all your entered data is correct.')</script>");


            }
        }
    }
}