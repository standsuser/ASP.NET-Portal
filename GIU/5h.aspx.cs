using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class _5h : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SuperviseIndustrial5h(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec  SuperviseIndustrial @Lecturer_id = @L_id,    @proj_code = @P_code ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@L_id", L_id.Text);
                comm.Parameters.AddWithValue("@P_code", P_code.Text);
               

                sqlconn.Open();

                comm.ExecuteNonQuery();


                    Response.Write("<script>alert('Project Supervised Succesfully!')</script>");



                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Project supervision failed. Please check your information.')</script>");


            }


        }
    }
}