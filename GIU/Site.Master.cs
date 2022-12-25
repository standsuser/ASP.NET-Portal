using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIU
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(string.Compare(Request.Url.LocalPath, "/Default.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/") == 0)
            {
                sh.Visible = false;
                profile.Visible = false;
                lognav.Visible = true;
                regnav.Visible = true;
                homenav.Visible = true;
                bp.Visible = false;


            }
            if (string.Compare(Request.Url.LocalPath, "/Student-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Student-Home") == 0|| string.Compare(Login.type, "Students") ==0)
            {
                sh.Visible = true;
                profile.Visible = true;
                lognav.Visible = false;
                regnav.Visible = false;
                homenav.Visible = false;
                bp.Visible = true;
               
            }

        }
    }
}