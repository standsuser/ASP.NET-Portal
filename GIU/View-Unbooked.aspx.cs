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
    public partial class View_Unbooked : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC ViewNotBookedMeetings @student_id= @studentid";
            SqlCommand sqlcomm = new SqlCommand(command, sqlconn);

            sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);




            sqlconn.Open();


            int i = sqlcomm.ExecuteNonQuery();

            SqlDataReader reader = sqlcomm.ExecuteReader();
            unbooked.DataSource = reader;
            unbooked.DataBind();

            if (i != 0)
            {

                Response.Write("<script>alert('Viewed Successfully.')</script>");

            }
            else
            {
                Response.Write("<script>alert('Failed to View Unbooked Meetings. Please make sure all your entered data is correct.')</script>");

            }
            sqlconn.Close();
        }
    }
}