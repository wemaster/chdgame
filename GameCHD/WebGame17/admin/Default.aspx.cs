using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppCHD.admin
{
    public partial class Default : System.Web.UI.Page
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
        protected void btnsave_Click(object sender, EventArgs e)
        {
            string str = CKEditor1.Text;
            string str1 = Server.HtmlEncode(str);
            string str2 = Server.HtmlDecode(str);
            lbltext.Text = str2;
            try
            {
                TblTest_BLL.INSERT(int.Parse(DrSub.SelectedValue.ToString()), lbltext.Text, txtDAA.Text, txtDAB.Text, txtDAC.Text, txtDAD.Text, drTest.SelectedValue.ToString(), txtminnutes.Text,int.Parse(drdloai.SelectedValue.ToString()), int.Parse(DrPhan.SelectedValue.ToString()), int.Parse(DrChuong.SelectedValue.ToString()));
                lbltext.Text = "Lưu thành công";
                txtDAA.Text = "";
                txtDAB.Text = "";
                txtDAC.Text = "";
                txtDAD.Text = "";
                ViewTest();
            }
            catch (Exception)
            {

                lbltext.Text = "lưu thất bại";
            }
        }

        protected void RptTest_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                HiddenField HDTestct = e.Item.FindControl("lblcontent") as HiddenField;
                Label lbct = e.Item.FindControl("lblct") as Label;
                lbltext.Text = HDTestct.Value;
                lbltext.Text = "Đã chọn câu hỏi thứ : " + e.CommandArgument;
            }
        }

        protected void btnreview_Click(object sender, EventArgs e)
        {
            string str = CKEditor1.Text;
            string str1 = Server.HtmlEncode(str);
            string str2 = Server.HtmlDecode(str);
            lbltext.Text = str2.ToString();
        }
    }
}