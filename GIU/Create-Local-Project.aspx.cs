using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class Create_Local_Porject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createproj_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            try { 
            string addempquery = "EXEC CompanyCreateLocalProject @company_id=@cid, @proj_code=@projcode, @title=@ptitle, @description=@pdesc, @major_code=@majorcode";




            SqlCommand sqlcomm = new SqlCommand(addempquery, sqlconn);

            sqlcomm.Parameters.AddWithValue("@cid", cidtextbox.Text);
            sqlcomm.Parameters.AddWithValue("@projcode", projbox.Text);
            sqlcomm.Parameters.AddWithValue("@ptitle", titlebox.Text);
            sqlcomm.Parameters.AddWithValue("@pdesc", descbox.Text);
            sqlcomm.Parameters.AddWithValue("@majorcode", majorcodebox.Text);



            sqlconn.Open();


            sqlcomm.ExecuteNonQuery();


            Response.Write("<script>alert('Created Project Successfully!')</script>");

        }


        catch{
                Response.Write("<script>alert('Failed to Create Project. Please Check Inputted Information.')</script>");
            
        }
        




        sqlconn.Close();







        }
    }
}