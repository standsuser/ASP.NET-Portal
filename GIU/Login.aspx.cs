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
        public static int userid;
        public static String type;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  
        protected void login_Click(object sender, EventArgs e)
        {



            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            try
            {

                string mainsqlquery = "EXEC UserLogin @email=@inputemail, @password=@inputpassword";
                string helpersqlquery = "EXEC LoginHelper @email=@inputemail, @password=@inputpassword";
                string gettypequery = "SELECT user_role FROM users WHERE users_id=@tmpid";


                SqlCommand sqlcomm = new SqlCommand(mainsqlquery, sqlconn);

                sqlcomm.Parameters.AddWithValue("@inputemail", email.Text);
                sqlcomm.Parameters.AddWithValue("@inputpassword", password.Text);



                sqlconn.Open();


                sqlcomm.Parameters.Add("@success", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
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

                SqlCommand helper = new SqlCommand(helpersqlquery, sqlconn);

                helper.Parameters.AddWithValue("@inputemail", email.Text);
                helper.Parameters.AddWithValue("@inputpassword", password.Text);

                sqlconn.Open();

                helper.Parameters.Add("@tmp_id", SqlDbType.Int, 4).Direction = ParameterDirection.ReturnValue;
                helper.ExecuteNonQuery();
                 userid = Convert.ToInt32(helper.ExecuteScalar());
                sqlconn.Close();



                SqlCommand gettype = new SqlCommand(gettypequery, sqlconn);
                sqlconn.Open();

                gettype.Parameters.AddWithValue("@tmpid", userid);
                gettype.ExecuteNonQuery();
                 type = Convert.ToString(gettype.ExecuteScalar());

                if (id == 1 && type == "Students")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if(id==1 && type == "Companies")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if (id == 1 && type == "Lecturers")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if (id == 1 && type == "Lecturers")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if (id == 1 && type == "Coordinators")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if (id == 1 && type == "Teaching assistants")
                {
                    Response.Redirect("Profile.aspx");

                }
                else if (id == 1 && type == "External examiners")
                {
                    Response.Redirect("Profile.aspx");

                }
                else
                {
                    type = "Employee";
                    Response.Redirect("Profile.aspx");

                }

            }
            catch
            {
                Response.Write("<script>alert('Failed to Login. Email or passsword is incorrect.')</script>");


            }


        }
    }
}

