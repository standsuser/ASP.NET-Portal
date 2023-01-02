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
    public partial class _5d : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LaddToDoList5d(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec LecturerAddToDo @meeting_id = @m_id, @to_do_list= @TDL ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@m_id", m_id.Text);
                comm.Parameters.AddWithValue("@TDL", @TDL.Text);



                sqlconn.Open();

                comm.ExecuteNonQuery();

                    Response.Write("<script>alert('Added To-Do List Succesfully!')</script>");




                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Todo list addition failed. Please check your information.')</script>");


            }


        }
    }
}
