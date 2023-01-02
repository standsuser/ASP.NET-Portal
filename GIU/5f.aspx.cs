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
    public partial class _5f : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            string viewbp = "EXEC ViewEE";
            try
            {
                SqlCommand sqlcomm = new SqlCommand(viewbp, sqlconn);


                sqlconn.Open();


                sqlcomm.ExecuteNonQuery();
                SqlDataReader reader = sqlcomm.ExecuteReader();
                freeEE.DataSource = reader;
                freeEE.DataBind();


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to View External Examiners Please retry .')</script>");

            }
        }
    }
}