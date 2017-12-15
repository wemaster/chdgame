using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGame17
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"].ToString() == "Khách")
            {
                //btnWarnotlogin.Visible = true;
                btnwarlogin.Visible = false;
            }
            else
            {
                //btnWarnotlogin.Visible = false;
                btnwarlogin.Visible = true;
                Response.Redirect("mem-login.aspx");
            }
        }
        protected void btnwarlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("mem-login.aspx");
        }
    }
}