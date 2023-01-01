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
    public partial class Student_AddToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string command = "EXEC StudentAddToDo @meeting_id=@meetingid, @to_do_list = @todolist";
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);

                sqlcomm.Parameters.AddWithValue("@meetingid", meetingidbox.Text);
                sqlcomm.Parameters.AddWithValue("@todolist", todobox.Text);




                sqlconn.Open();


                int i = sqlcomm.ExecuteNonQuery();


                if (i != 0)
                {

                    Response.Write("<script>alert('To-Do List Added Successfully.')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Failed to Add To-Do List. Please make sure all your entered data is correct.')</script>");

                }
                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed to Add To-Do List. Please make sure all your entered data is correct.')</script>");


            }
        }
    }
}