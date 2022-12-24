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
        string role;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection("Data Source = (localdb)\\ProjectModels;Initial Catalog = Bachelor; Integrated Security = True\r\n");
            SqlCommand cmd = new SqlCommand(@"EXEC PROC UserRegister @usertype = '"+role+"' ");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('user is registered successfully')</script>");*/

        }
        protected void SelectedType(object sender, EventArgs e)
        {
            role = "Students";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
           // string sqlquery = "Insert into [dbo].[users] (user_role) values (@role)";
            string sqlquery = "EXEC UserRegister @usertype= @role , @username=NULL, @email=NULL,@first_name=NULL, @last_name=NULL, @birth_date=NULL, @GPA=NULL, @semester =NULL, @address =NULL, @faculty_code=NULL, @major_code =NULL, @company_name =NULL, @representative_name =NULL, @representative_email =NULL, @phone_number =NULL, @country_of_residence=NULL , @users_id=NULL, @password=NULL";

            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
            sqlcomm.Parameters.AddWithValue("@role", usertype.SelectedItem.Value);
            sqlconn.Open();
            int i = sqlcomm.ExecuteNonQuery();
            if (i != 0)
            {
                Response.Write("<script>alert('user is registered successfully')</script>"); 
            }
            else
            {
                Response.Write("<script>alert('Failed to Insert')</script>");

            }
            sqlconn.Close();


        }
    }
}