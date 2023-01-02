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
    public partial class assignEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void assign_Employee(object sender, EventArgs e)
        {

            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec AssignEmployee @bachelor_code=@b_code ,@staff_id=@s_id ,@Company_id= @c_cid";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@b_code", b_code.Text);
                comm.Parameters.AddWithValue("@s_id", s_id.Text);
                comm.Parameters.AddWithValue("@c_cid", c_cid.Text);
                sqlconn.Open();

                comm.ExecuteNonQuery();
          
                SqlDataReader reader = comm.ExecuteReader();
                assigndetails.DataSource = reader;
                assigndetails.DataBind();


                Response.Write("<script>alert('Student Assigning Succesful!')</script>");


                


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to Assign Employee. Please check your information.')</script>");


            }
        }
    }

}
