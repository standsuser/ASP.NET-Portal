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
    public partial class Update_My_Defense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updatedefense_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC UpdateMyDefense @student_id= @studentid , @defense_content = @content";
            try
            {
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);



                    sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);

                if (String.Compare(studentidbox.Text, "") == 0)
                    sqlcomm.Parameters.AddWithValue("@content", DBNull.Value);
                else
                    sqlcomm.Parameters.AddWithValue("@content", contentbox.Text);

                sqlconn.Open();

                int i = sqlcomm.ExecuteNonQuery();
                if (i != 0)
                {

                    Response.Write("<script>alert('Defense Updated Successfully.')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Failed to Update Defense. Please make sure all your entered data is correct.')</script>");

                }

                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Update Defense. Please make sure all your entered data is correct.')</script>");
            }










        }
    }
}