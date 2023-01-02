using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GIU
{
    public partial class Add_Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addemp_Click(object sender, EventArgs e)
        {

            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);

                string addempquery = "EXEC AddEmployee @CompanyID=@cid, @email=@mail, @name=@empname, @phone_number=@phonenum, @field=@empfield";



                SqlCommand sqlcomm = new SqlCommand(addempquery, sqlconn);

                sqlcomm.Parameters.AddWithValue("@cid", cidtextbox.Text);
                sqlcomm.Parameters.AddWithValue("@mail", emailbox.Text);
                sqlcomm.Parameters.AddWithValue("@empname", namebox.Text);
                sqlcomm.Parameters.AddWithValue("@phonenum", phonebox.Text);
                sqlcomm.Parameters.AddWithValue("@empfield", fieldbox.Text);



                sqlconn.Open();


                SqlDataReader reader = sqlcomm.ExecuteReader();
                employeegenerated.DataSource = reader;
                employeegenerated.DataBind();


                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed to Add. Recheck Data Entered.')</script>");

            }

        }
        




        
    }
}