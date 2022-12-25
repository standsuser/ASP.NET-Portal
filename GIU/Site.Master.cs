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
            if (string.Compare(Request.Url.LocalPath, "/Student-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Student-Home") == 0)
            {
                sh.Visible = true;
                lognav.Visible = false;
                regnav.Visible = false;
                homenav.Visible = false;
            }
        }
    }
}