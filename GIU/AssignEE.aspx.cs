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
    public partial class AssignEE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void assign_EE(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string maincommand = "EXEC AssignEE @coordinator_id = @coordinator, @EE_id = @ee_id, @proj_code = @p_code";

            SqlCommand comm = new SqlCommand(maincommand, sqlconn);
            comm.Parameters.AddWithValue("@coordinator", coord_id.Text);
            comm.Parameters.AddWithValue("@ee_id", ee_id.Text);
            comm.Parameters.AddWithValue("@p_code", p_code.Text);

            sqlconn.Open();

            comm.ExecuteNonQuery();



            sqlconn.Close();
        }

    }
}