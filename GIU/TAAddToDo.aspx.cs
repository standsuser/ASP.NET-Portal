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
    public partial class TAAddToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddTODO(object sender, EventArgs e)
        {


            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string maincommand = "EXEC TAAddToDo @meeting_id= @m_id , @to_do_list = @tdl";
            SqlCommand comm = new SqlCommand(maincommand, sqlconn);

            comm.Parameters.AddWithValue("@m_id", m_id.Text);
            comm.Parameters.AddWithValue("@tdl", tdl.Text);


            sqlconn.Open();
            comm.ExecuteNonQuery();
            sqlconn.Close();


        }
    }
}