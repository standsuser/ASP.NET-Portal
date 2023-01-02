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
    public partial class CreatingBP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LecturerCreateBP(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec  LecturerCreateLocalProject @Lecturer_id = @L_id,    @proj_code = @P_code ,    @title = @t,   @description = @d,    @major_code =@m_code ";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@L_id", L_id.Text);
                comm.Parameters.AddWithValue("@P_code", P_code.Text);
                comm.Parameters.AddWithValue("@t", t.Text);
                comm.Parameters.AddWithValue("@m_code", m_code.Text);
                comm.Parameters.AddWithValue("@d", d.Text);


                sqlconn.Open();

                comm.ExecuteNonQuery();


                Response.Write("<script>alert('Project created Succesfully!')</script>");




                sqlconn.Close();

            }
            catch
            {
                Response.Write("<script>alert('Failed to Create Project. Please Check Information Inputted')</script>");

            }

        }
    }
}