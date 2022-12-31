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
    public partial class Submit_My_Thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitthesis_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string command = "EXEC SubmitMyThesis @student_id= @studentid, @title=@thesistitle, @pdf_doc=@pdf";
            SqlCommand sqlcomm = new SqlCommand(command, sqlconn);

            sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);


            sqlcomm.Parameters.AddWithValue("@thesistitle", titlebox.Text);

            sqlcomm.Parameters.AddWithValue("@pdf", pdf.Text);

            sqlconn.Open();


            int i = sqlcomm.ExecuteNonQuery();
            if (i != 0)
            {
                
                    Response.Write("<script>alert('Thesis Submitted Successfully.')</script>");
                
            }
            else
            {
                Response.Write("<script>alert('Failed to Submit Thesis. Please make sure all your entered data is correct.')</script>");

            }
            sqlconn.Close();
        }
    }
}