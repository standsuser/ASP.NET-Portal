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
    public partial class ViewRecomendations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void viewRec(object sender, EventArgs e)
        {
         //   try
         //   {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string maincommand = "Exec ViewRecommendation @lecturer_id = @l_id";

                SqlCommand comm = new SqlCommand(maincommand, sqlconn);
                comm.Parameters.AddWithValue("@l_id", lec_id.Text);

                sqlconn.Open();

                comm.ExecuteNonQuery();
                SqlDataReader reader = comm.ExecuteReader();
                RecGrid.DataSource = reader;
                RecGrid.DataBind();
        //        int id = Convert.ToInt32(comm.ExecuteScalar());


         //       if (id == 1)
         //      {
         //           Response.Write("<script>alert('Success!')</script>");

         //       }
         //       else if (id == 0)
         //       {
         //           Response.Write("<script>alert('Failed to view lecturer. Please check your information.')</script>");

         //       }


                sqlconn.Close();
            //}
           // catch
           // {
           //     Response.Write("<script>alert('Failed to Assign Students. Please check your information.')</script>");
           // }

        }
    }
}