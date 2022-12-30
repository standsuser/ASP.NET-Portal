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
    public partial class AssignTa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Assign_tas(object sender, EventArgs e)
        {
            try
            {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "EXEC AssignTAs @coordinator_id = @c_id, @TA_id = @t_id, @proj_code = @p_code";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);

                comm.Parameters.AddWithValue("@c_id", coordinator_id.Text);
                comm.Parameters.AddWithValue("@t_id", TA_id.Text);
                comm.Parameters.AddWithValue("@p_code", pc.Text);

                sqlconn.Open();
                comm.ExecuteNonQuery();

                int id = Convert.ToInt32(comm.ExecuteScalar());


                if (id == 1)
                {
                    Response.Write("<script>alert('TA Assigning Succesful!')</script>");

                }
                else if (id == 0)
                {
                    Response.Write("<script>alert('Failed to Assign TA.')</script>");

                }


                sqlconn.Close();
            }
            catch
            {
                Response.Write("<script>alert('Failed to make preference.')</script>");


            }


        }
    }
}