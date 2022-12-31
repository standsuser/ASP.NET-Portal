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
    public partial class View_My_Thesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string viewbp = "EXEC ViewMyThesis @sid= @studentid, @title=@thesistitle";
            try
            {
                SqlCommand sqlcomm = new SqlCommand(viewbp, sqlconn);


                sqlcomm.Parameters.AddWithValue("@studentid", studentidbox.Text);


                sqlcomm.Parameters.AddWithValue("@thesistitle", titlebox.Text);





                sqlconn.Open();


                sqlcomm.ExecuteNonQuery();
                SqlDataReader reader = sqlcomm.ExecuteReader();
                mythesis.DataSource = reader;
                mythesis.DataBind();


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to View Thesis Please retry and doublecheck data entered.')</script>");
            }
        }
    }
}