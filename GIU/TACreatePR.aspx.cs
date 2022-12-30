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
    public partial class TACreatePR : System.Web.UI.Page
    {
        protected void CreatePR(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string maincommand = "TACreatePR @student_id = @s_id,@teaching_assistant_id = @ta_id,@date = @d,@content = @c";
            SqlCommand comm = new SqlCommand(maincommand, sqlconn);

            comm.Parameters.AddWithValue("@s_id", s_id.Text);
            comm.Parameters.AddWithValue("@ta_id", ta_id.Text);
            comm.Parameters.AddWithValue("@d", d.Text);
            comm.Parameters.AddWithValue("@c", c.Text);

            sqlconn.Open();
            comm.ExecuteNonQuery();
            sqlconn.Close();

        }
    }
}