using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCHD
{
    public partial class view_mem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewMem();
        }

        private void ViewMem()
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = TblAcc_BLL.SelectAccViewMem();
                Repeater1.DataBind();
            }
        }
    }
}