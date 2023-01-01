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
    public partial class View_My_PR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC ViewMyProgressReport @student_id= @studentid, @date=@PRdate";
            try
            {
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);



                if (String.Compare(studentidbox.Text, "") == 0)
                    sqlcomm.Parameters.AddWithValue("@studentid", DBNull.Value);
                else
                sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);

                if (String.Compare(datebox.Text, "") == 0)
                    sqlcomm.Parameters.AddWithValue("@PRdate", DBNull.Value);
                else
                    sqlcomm.Parameters.AddWithValue("@PRdate", datebox.Text);





                sqlconn.Open();


                sqlcomm.ExecuteNonQuery();
                SqlDataReader reader = sqlcomm.ExecuteReader();
                PR.DataSource = reader;
                PR.DataBind();


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to View Progress Report Please retry and doublecheck data entered.')</script>");
            }
        }
    }
}