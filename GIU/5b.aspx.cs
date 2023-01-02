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
    public partial class _5b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void deadlineofallstudents5b(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec   SpecifyThesisDeadline @deadline = @dt ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@dt", dt.Text);
             


                sqlconn.Open();

                comm.ExecuteNonQuery();



                    Response.Write("<script>alert('Deadline Specified Successfully!')</script>");



                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed To Specify Deadline. Please Check Information Inputted!')</script>");


            }


        }
    }

}
