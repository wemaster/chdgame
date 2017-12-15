using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCHD.admin
{
    public partial class chcheck_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewTest();
        }
        private void ViewTest()
        {
            RptTest.DataSource = TblTest_BLL.ViewTest_update();
            RptTest.DataBind();
        }
    }
}