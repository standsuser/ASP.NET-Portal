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

                if (usertype.SelectedItem.Text == "Select")
                    Response.Write("<script>alert('Please Select a User Type')</script>");

                if (usertype.SelectedItem.Text == "Students") //students start
                {
                        string studentsqlquery = "EXEC UserRegister @usertype= @role , @username=@user, @email=@email,@first_name=@fname, @last_name=@lname, @birth_date=@dateofbirth, @GPA=@inputgpa, @semester =@inputsemester, @address =@inputaddress, @faculty_code=NULL, @major_code =@majorcode, @company_name =NULL, @representative_name =NULL, @representative_email =NULL, @phone_number =@phonenumber, @country_of_residence=NULL";

                        SqlCommand sqlcomm = new SqlCommand(studentsqlquery, sqlconn);
                        sqlcomm.Parameters.AddWithValue("@role", usertype.SelectedItem.Value);
                        sqlcomm.Parameters.AddWithValue("@user", username.Text);
                        sqlcomm.Parameters.AddWithValue("@email", email.Text);
                        sqlcomm.Parameters.AddWithValue("@phonenumber", phonenumber.Text);
                        sqlcomm.Parameters.AddWithValue("@fname", fname.Text);
                        sqlcomm.Parameters.AddWithValue("@lname", lname.Text);
                        sqlcomm.Parameters.AddWithValue("@majorcode", majorcode.Text);
                        sqlcomm.Parameters.AddWithValue("@dateofbirth", dateofbirth.Text);
                        sqlcomm.Parameters.AddWithValue("@inputaddress", inputaddress.Text);
                        sqlcomm.Parameters.AddWithValue("@inputsemester", inputsemester.Text);
                        sqlcomm.Parameters.AddWithValue("@inputgpa", inputgpa.Text);


                    string getid = "SELECT max(users_id) FROM users";
                    SqlCommand showresult = new SqlCommand(getid, sqlconn);
                 

                    sqlconn.Open();


                        int i = sqlcomm.ExecuteNonQuery();
                    if (i != 0)
                    {
                        if (usertype.SelectedItem.Text == "Select")
                            Response.Write("<script>alert('Please Select a User Type')</script>");
                        else { 
                            Response.Write("<script>alert('Registered Successfully.')</script>");
                            idpass.Visible = true;

                            idpasslabel.Text = " Now you can Login. Your ID and Password is: " + showresult.ExecuteScalar().ToString();
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

                        }
                        sqlconn.Close();
                }
                else if(usertype.SelectedItem.Text == "Companies") //COMPANIES START
                    {
                        string studentsqlquery = "EXEC UserRegister @usertype= @role , @username=@user, @email=@email,@first_name=NULL, @last_name=NULL, @birth_date=NULL, @GPA=NULL, @semester =NULL, @address =@companylocation, @faculty_code=NULL, @major_code =NULL, @company_name =@companyname, @representative_name =@representativename, @representative_email =@representativeemail, @phone_number =@phonenumber, @country_of_residence=NULL";

                        SqlCommand sqlcomm = new SqlCommand(studentsqlquery, sqlconn);
                        sqlcomm.Parameters.AddWithValue("@role", usertype.SelectedItem.Value);
                        sqlcomm.Parameters.AddWithValue("@user", username.Text);
                        sqlcomm.Parameters.AddWithValue("@email", email.Text);
                        sqlcomm.Parameters.AddWithValue("@phonenumber", phonenumber.Text);


                        sqlcomm.Parameters.AddWithValue("@companylocation", companylocation.Text);
                        sqlcomm.Parameters.AddWithValue("@companyname", companyname.Text);
                        sqlcomm.Parameters.AddWithValue("@representativeemail", representativeemail.Text);
                        sqlcomm.Parameters.AddWithValue("@representativename", representativename.Text);



                        string getid = "SELECT max(users_id) FROM users";
                        SqlCommand showresult = new SqlCommand(getid, sqlconn);


                        sqlconn.Open();


                        int i = sqlcomm.ExecuteNonQuery();
                        if (i != 0)
                    {
                            if (usertype.SelectedItem.Text == "Select")
                                Response.Write("<script>alert('Please Select a User Type')</script>");
                            else
                        {
                                Response.Write("<script>alert('Registered Successfully.')</script>");
                                idpass.Visible = true;

                                idpasslabel.Text = " Now you can Login. Your ID and Password is: " + showresult.ExecuteScalar().ToString();
                         }
                            }
                        else
                        {
                            Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

                        }
                        sqlconn.Close();

                }
                else if(usertype.SelectedItem.Text == "Lecturers" || usertype.SelectedItem.Text == "Teaching assistants" || usertype.SelectedItem.Text == "External examiners" || usertype.SelectedItem.Text == "Coordinators") //LECTURERS ,TA, COORDINATOR, EXTERNALEXAMINER
                {
                    string studentsqlquery = "EXEC UserRegister @usertype= @role , @username=@user, @email=@email,@first_name=NULL, @last_name=NULL, @birth_date=NULL, @GPA=NULL, @semester =NULL, @address =NULL, @faculty_code=NULL, @major_code =NULL, @company_name =NULL, @representative_name =NULL, @representative_email =NULL, @phone_number =@phonenumber, @country_of_residence=NULL";

                    SqlCommand sqlcomm = new SqlCommand(studentsqlquery, sqlconn);
                    sqlcomm.Parameters.AddWithValue("@role", usertype.SelectedItem.Value);
                    sqlcomm.Parameters.AddWithValue("@user", username.Text);
                    sqlcomm.Parameters.AddWithValue("@email", email.Text);
                    sqlcomm.Parameters.AddWithValue("@phonenumber", phonenumber.Text);



                    string getid = "SELECT max(users_id) FROM users";
                    SqlCommand showresult = new SqlCommand(getid, sqlconn);


                    sqlconn.Open();


                    int i = sqlcomm.ExecuteNonQuery();
                    if (i != 0)
                    {
                        if (usertype.SelectedItem.Text == "Select")
                            Response.Write("<script>alert('Please Select a User Type')</script>");
                        else
                        {
                            Response.Write("<script>alert('Registered Successfully.')</script>");
                            idpass.Visible = true;

                            idpasslabel.Text = " Now you can Login. Your ID and Password is: " + showresult.ExecuteScalar().ToString();
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

                    }
                    sqlconn.Close();

                }







            }
                    catch
                    {
                        Response.Write("<script>alert('Failed to Register. Please make sure all your entered data is correct.')</script>");

                    }




        }//end of button click

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList_Changed(object sender, EventArgs e)
        {

       
                if (usertype.SelectedItem.Text == "Students")
                {
                    student.Visible = true;
                }
                else if(usertype.SelectedItem.Text == "Companies")
                {
                    companypanel.Visible = true;
                    student.Visible = false;

            }
            else 
            {
                companypanel.Visible = false;
                student.Visible = false;

            }


        }
    }
}