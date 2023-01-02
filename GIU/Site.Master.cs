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
                companyhome.Visible = false;// company home
                lecturerhome.Visible = false; //lecturer home
                employeehome.Visible = false; //employee home
                coordinatorhome.Visible = false; //coordinatorhome



            }
            if (string.Compare(Request.Url.LocalPath, "/Student-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Student-Home") == 0|| string.Compare(Login.type, "Students") ==0)
            {
                sh.Visible = true;//student home
                profile.Visible = true;// profile view
                lognav.Visible = false;// loginpage
                regnav.Visible = false;//registerpage
                homenav.Visible = false; //main old page
                bp.Visible = true; //view bachelor projects
                companyhome.Visible = false;// company home
                employeehome.Visible = false; //employee home
                lecturerhome.Visible = false; //lecturer home
                coordinatorhome.Visible = false; //coordinatorhome


            }
            if (string.Compare(Request.Url.LocalPath, "/Company-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Company-Home") == 0 || string.Compare(Login.type, "Companies") == 0)
            {
                sh.Visible = false;//student home
                profile.Visible = true;// profile view
                lognav.Visible = false;// loginpage
                regnav.Visible = false;//registerpage
                homenav.Visible = false; //main old page
                bp.Visible = true; //view bachelor projects
                companyhome.Visible = true; // company home
                employeehome.Visible = false; //employee home
                lecturerhome.Visible = false; //lecturer home
                coordinatorhome.Visible = false; //coordinatorhome


            }
            if (string.Compare(Request.Url.LocalPath, "/Employee-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Employee-Home") == 0 || string.Compare(Login.type, "Employee") == 0)
            {
                sh.Visible = false;//student home
                profile.Visible = true;// profile view
                lognav.Visible = false;// loginpage
                regnav.Visible = false;//registerpage
                homenav.Visible = false; //main old page
                bp.Visible = true; //view bachelor projects
                companyhome.Visible = false; // company home
                employeehome.Visible = true; //employee home
                lecturerhome.Visible = false; //lecturer home
                coordinatorhome.Visible = false; //coordinatorhome


            }
            if (string.Compare(Request.Url.LocalPath, "/Lecturer-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Lecturer-Home") == 0 || string.Compare(Login.type, "Lecturers") == 0)
            {
                sh.Visible = false;//student home
                profile.Visible = true;// profile view
                lognav.Visible = false;// loginpage
                regnav.Visible = false;//registerpage
                homenav.Visible = false; //main old page
                bp.Visible = true; //view bachelor projects
                companyhome.Visible = false; // company home
                employeehome.Visible = false; //employee home
                lecturerhome.Visible = true; //lecturer home
                coordinatorhome.Visible = false; //coordinatorhome


            }
            if (string.Compare(Request.Url.LocalPath, "/Coordinator-Home.aspx") == 0 || string.Compare(Request.Url.LocalPath, "/Coordinator-Home") == 0 || string.Compare(Login.type, "Coordinators") == 0)
            {
                sh.Visible = false;//student home
                profile.Visible = true;// profile view
                lognav.Visible = false;// loginpage
                regnav.Visible = false;//registerpage
                homenav.Visible = false; //main old page
                bp.Visible = true; //view bachelor projects
                companyhome.Visible = false; // company home
                employeehome.Visible = false; //employee home
                lecturerhome.Visible = false; //lecturer home
                coordinatorhome.Visible = true; //coordinatorhome


            }

        }
    }
}