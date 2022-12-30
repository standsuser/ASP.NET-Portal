
using System.Configuration;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace GIU
{
    public partial class UserSeeAll : System.Web.UI.Page
    {
        public static int userid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void see_All(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string maincommand = "Exec ViewUsers @User_type = @usertype, @User_id = @userid";

            SqlCommand comm = new SqlCommand(maincommand, sqlconn);
            comm.Parameters.AddWithValue("@userid", userident.Text);
            comm.Parameters.AddWithValue("@usertype", userType.Text);

            sqlconn.Open();

            comm.ExecuteNonQuery();
            SqlDataReader reader = comm.ExecuteReader();
            Users_grid.DataSource = reader;
            Users_grid.DataBind();


            sqlconn.Close();


        }
    }
}