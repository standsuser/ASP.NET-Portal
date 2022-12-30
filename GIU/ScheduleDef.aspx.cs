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
    public partial class ScheduleDef : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ScheduleDefense(object sender, EventArgs e)
        {
            try
            {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "EXEC ScheduleDefense @sid = @student_id, @date = @d, @time = @t, @location = @loc";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);

                comm.Parameters.AddWithValue("@student_id", student_id.Text);
                comm.Parameters.AddWithValue("@d", d.Text);
                comm.Parameters.AddWithValue("@t", t.Text);
                comm.Parameters.AddWithValue("@loc", loc.Text);

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