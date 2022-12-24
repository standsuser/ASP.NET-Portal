using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  
        protected void login_Click(object sender, EventArgs e)
        {



            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            try
            {

                string studentsqlquery = "EXEC UserLogin @email=@inputemail, @password=@inputpassword";

                SqlCommand sqlcomm = new SqlCommand(studentsqlquery, sqlconn);

                sqlcomm.Parameters.AddWithValue("@inputemail", email.Text);
                sqlcomm.Parameters.AddWithValue("@inputpassword", password.Text);



                sqlconn.Open();


                sqlcomm.Parameters.Add("@ReturnValue", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
               sqlcomm.ExecuteNonQuery();
                int id = Convert.ToInt32(sqlcomm.ExecuteScalar());

                if (id == 1)
                {

                    Response.Write("<script>alert('Login Successful')</script>");

                }
                else if (id==0)
                {
                    Response.Write("<script>alert('Failed to Login. Email or passsword is incorrect.')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Failed to Login. Please Try Again.')</script>");

                }


                sqlconn.Close();




            }
            catch
            {
                Response.Write("<script>alert('Failed to Login. Email or passsword is incorrect.')</script>");


            }


        }
    }
}

