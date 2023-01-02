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
    public partial class EmpProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Emp_ProgressReport(object sender, EventArgs e)
        {

        
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec EmployeeCreatePR @Employee_id=@e_eid, @sid=@s_sid, @date=@d_location, @content=@emp_grade";
                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@e_eid", e_eid.Text);
                comm.Parameters.AddWithValue("@s_sid", s_sid.Text);
                comm.Parameters.AddWithValue("@d_location", d_location.Text);
                comm.Parameters.AddWithValue("@emp_grade", emp_grade.Text);
           
                sqlconn.Open();

                comm.ExecuteNonQuery();


                    Response.Write("<script>alert('Progress Report Created Successfully!')</script>");






                sqlconn.Close();
            

        }
 
    }
}