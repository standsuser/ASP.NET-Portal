using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Make_Pref : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitpref_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            try
            {

                string makeprefquery = "EXEC MakePreferencesLocalProject @student_id=@sid, @bachelor_code=@bcode, @preference_number=@pnum";
               


                SqlCommand sqlcomm = new SqlCommand(makeprefquery, sqlconn);

                sqlcomm.Parameters.AddWithValue("@sid", sidtextbox.Text);
                sqlcomm.Parameters.AddWithValue("@bcode", bachelorcodebox.Text);
                sqlcomm.Parameters.AddWithValue("@pnum", prefnumbox.Text);



                sqlconn.Open();


                sqlcomm.ExecuteNonQuery();
                int id = Convert.ToInt32(sqlcomm.ExecuteScalar());


                if (id == 1)
                {
                    Response.Write("<script>alert('Making Preference Successful!')</script>");

                }
                else if (id == 0)
                {
                    Response.Write("<script>alert(' Failed to make preference. Please check your information.')</script>");

                }
                else
                {
                    Response.Write("<script>alert(' Failed to make preference. Please check your information.')</script>");

                }


                sqlconn.Close();

              

            }
            catch
            {
                Response.Write("<script>alert('Making Preference Successful!')</script>");



            }
        }
    }
}