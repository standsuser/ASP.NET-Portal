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
    public partial class AssignStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Assign_students(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec AssignAllStudentsToLocalProject";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);

                sqlconn.Open();

                comm.ExecuteNonQuery();
                SqlDataReader reader = comm.ExecuteReader();
                Students_grid.DataSource = reader;
                Students_grid.DataBind();

                int id = Convert.ToInt32(comm.ExecuteScalar());


                if (id == 1)
                {
                    Response.Write("<script>alert('Student Assigning Succesful!')</script>");

                }
                else if (id == 0)
                {
                    Response.Write("<script>alert('Failed to Assign Students. Please check your information.')</script>");

                }


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to make preference. Please check your information.')</script>");


            }
        }
    }
}
