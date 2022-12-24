using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace GIU
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            // string sqlquery = "Insert into [dbo].[users] (user_role) values (@role)";
            try
            {
                string sqlquery = "EXEC UserRegister @usertype= @role , @username=@user, @email=@email,@first_name=@fname, @last_name=NULL, @birth_date=NULL, @GPA=NULL, @semester =NULL, @address =NULL, @faculty_code=NULL, @major_code =@majorcode, @company_name =NULL, @representative_name =NULL, @representative_email =NULL, @phone_number =NULL, @country_of_residence=NULL";

                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("@role", usertype.SelectedItem.Value);
                sqlcomm.Parameters.AddWithValue("@user", username.Text);
                sqlcomm.Parameters.AddWithValue("@email", email.Text);
                sqlcomm.Parameters.AddWithValue("@fname", fname.Text);
                sqlcomm.Parameters.AddWithValue("@lname", lname.Text);
                sqlcomm.Parameters.AddWithValue("@majorcode", majorcode.Text);


                sqlconn.Open();
                int i = sqlcomm.ExecuteNonQuery();
                if (i != 0)
                {
                    if (usertype.SelectedItem.Text == "Select")
                        Response.Write("<script>alert('Please Select a User Type')</script>");
                    else
                        Response.Write("<script>alert('Registered Successfully.')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

                }
                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList_Changed(object sender, EventArgs e)
        {

       
                if (usertype.SelectedItem.Text == "Students")
                {
                    student.Visible = true;
                }
                else
                {
                    student.Visible = false;
                }
            

        }
    }
}