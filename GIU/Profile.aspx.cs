using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Configuration;
using System.Data.SqlClient;

namespace GIU
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {







            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);


            //string viewprofile = "SELECT (users_id, username,email,user_role,phone_number from users WHERE users_id= @userid";
            string viewprofile = "EXEC ViewProfile @user_id= @userid";

            SqlCommand sqlcomm = new SqlCommand(viewprofile, sqlconn);
            sqlcomm.Parameters.AddWithValue("@userid", Login.userid);
      

          

            sqlconn.Open();


             sqlcomm.ExecuteNonQuery();
            SqlDataReader reader = sqlcomm.ExecuteReader();
            profile.DataSource = reader;
            profile.DataBind();


            sqlconn.Close();

        }
    }
}