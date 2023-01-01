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
    public partial class View_BP_Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewbpgrade_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC ViewMyBachelorProjectGrade @student_id= @studentid";
            SqlCommand sqlcomm = new SqlCommand(command, sqlconn);

            sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);




            sqlconn.Open();


            int i = sqlcomm.ExecuteNonQuery();

            SqlDataReader reader = sqlcomm.ExecuteReader();
            bpgrade.DataSource = reader;
            bpgrade.DataBind();

            if (i != 0)
            {

                Response.Write("<script>alert('Viewed Successfully.')</script>");

            }
            else
            {
                Response.Write("<script>alert('Failed to View Bachelor Project Grade. Please make sure all your entered data is correct.')</script>");

            }
            sqlconn.Close();
        }
    }
}