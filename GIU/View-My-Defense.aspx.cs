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
    public partial class View_My_Defense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC ViewMyDefense @student_id= @studentid";
            try
            {
                SqlCommand sqlcomm = new SqlCommand(command, sqlconn);



                if (String.Compare(studentidbox.Text, "") == 0)
                    sqlcomm.Parameters.AddWithValue("@studentid", DBNull.Value);
                else
                    sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);


                sqlconn.Open();


                sqlcomm.ExecuteNonQuery();
                SqlDataReader reader = sqlcomm.ExecuteReader();
                mydefense.DataSource = reader;
                mydefense.DataBind();


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to View Defense Please retry and doublecheck data entered.')</script>");
            }
        }
    }
}