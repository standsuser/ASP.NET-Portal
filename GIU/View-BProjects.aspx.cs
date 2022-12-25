using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class View_BProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);


            string viewbp = "EXEC ViewBachelorProjects @user_id= @userid, @project_type=@projecttype";

            SqlCommand sqlcomm = new SqlCommand(viewbp, sqlconn);
            sqlcomm.Parameters.AddWithValue("@userid", userids.Text);
            sqlcomm.Parameters.AddWithValue("@projecttype", ptypes.SelectedItem.Text);





            sqlconn.Open();


            sqlcomm.ExecuteNonQuery();
            SqlDataReader reader = sqlcomm.ExecuteReader();
            bprojects.DataSource = reader;
            bprojects.DataBind();


            sqlconn.Close();

        }

        protected void bprojects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}