using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChDGame
{
    public partial class mem_login : System.Web.UI.Page
    {
        private static int Key = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"].ToString() == "Khách")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                ViewAccLogin();
            }
        }
        private void ViewAccLogin()
        {
            RptViewAcclogin.DataSource = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            RptViewAcclogin.DataBind();
        }
        protected void btndanhnor_Click(object sender, EventArgs e)
        {
            Session["TrangThai"] = "Nor";
            Response.Redirect("chd-join.aspx");
        }
        protected void btntoan_Click(object sender, EventArgs e)
        {
            Session["IDSub"] = "1";
            btndanhnor.Visible = true;
            btnxephang.Visible = true;
            btnevent.Visible = true;
            btndanhdon.Visible = true;
            btnevent.Visible = true;
            btntoan.Attributes.Add("class", "btn w3-tag w3-round w3-green w3-border w3-border-white w3-disabled");
            btnly.Attributes.Add("class", "btn w3-tag w3-round w3-teal w3-border w3-border-white");
            btnhoa.Attributes.Add("class", "btn w3-tag w3-round w3-indigo w3-border w3-border-white");
            btntin.Attributes.Add("class", "btn w3-tag w3-round w3-red w3-border w3-border-white");

        }
        protected void btnly_Click(object sender, EventArgs e)
        {
            Session["IDSub"] = "2";
            btndanhnor.Visible = true;
            btnxephang.Visible = true;
            btnevent.Visible = true;
            btndanhdon.Visible = true;
            btnevent.Visible = true;
            btntoan.Attributes.Add("class", "btn w3-tag w3-round w3-green w3-border w3-border-white");
            btnly.Attributes.Add("class", "btn w3-tag w3-round w3-teal w3-border w3-border-white w3-disabled");
            btnhoa.Attributes.Add("class", "btn w3-tag w3-round w3-indigo w3-border w3-border-white");
            btntin.Attributes.Add("class", "btn w3-tag w3-round w3-red w3-border w3-border-white");
        }
        protected void btnhoa_Click(object sender, EventArgs e)
        {
            Session["IDSub"] = "3";
            btndanhnor.Visible = true;
            btnxephang.Visible = true;
            btnevent.Visible = true;
            btndanhdon.Visible = true;
            btnevent.Visible = true;
            btntoan.Attributes.Add("class", "btn w3-tag w3-round w3-green w3-border w3-border-white");
            btnly.Attributes.Add("class", "btn w3-tag w3-round w3-teal w3-border w3-border-white");
            btnhoa.Attributes.Add("class", "btn w3-tag w3-round w3-indigo w3-border w3-border-white w3-disabled");
            btntin.Attributes.Add("class", "btn w3-tag w3-round w3-red w3-border w3-border-white");
        }
        protected void btntin_Click(object sender, EventArgs e)
        {
            Session["IDSub"] = "4";
            btndanhnor.Visible = true;
            btnxephang.Visible = true;
            btnevent.Visible = true;
            btndanhdon.Visible = true;
            btnevent.Visible = true;
            btntoan.Attributes.Add("class", "btn w3-tag w3-round w3-green w3-border w3-border-white");
            btnly.Attributes.Add("class", "btn w3-tag w3-round w3-teal w3-border w3-border-white");
            btnhoa.Attributes.Add("class", "btn w3-tag w3-round w3-indigo w3-border w3-border-white");
            btntin.Attributes.Add("class", "btn w3-tag w3-round w3-red w3-border w3-border-white w3-disabled");
        }
        protected void btnxephang_Click(object sender, EventArgs e)
        {
            //Session["TrangThai"] = "XH";
            //Response.Redirect("war-xh.aspx");
        }
        protected void btnChangePwd_Click(object sender, EventArgs e)
        {
            btnEditInfo.Visible = false;
            btnhuy.Visible = true;
            btnluu.Visible = true;
            lblmkcu.Visible = true;
            lblmkm.Visible = true;
            txtmkcu.Visible = true;
            txtmkm.Visible = true;
        }
        protected void btnhuy_Click(object sender, EventArgs e)
        {
            btnhuy.Visible = false;
            btnluu.Visible = false;
            btnEditInfo.Visible = true;
            btnChangePwd.Visible = true;
            lbllop.Visible = false;
            lblmkcu.Visible = false;
            lblmkm.Visible = false;
            txtmkcu.Visible = false;
            txtmkm.Visible = false;
            drdclass.Visible = false;
        }
        protected void btnEditInfo_Click(object sender, EventArgs e)
        {
            btnhuy.Visible = true;
            btnluu.Visible = true;
            lbllop.Visible = true;
            btnChangePwd.Visible = false;
            drdclass.Visible = true;
            ViewDrop();
            Key = 1;
        }

        private void ViewDrop()
        {
            drdclass.DataSource = TbLClass_BLL.ViewClass();
            drdclass.DataTextField = "NameClass";
            drdclass.DataValueField = "IDClass";
            drdclass.DataBind();
            drdclass.SelectedValue = Session["IDClass"].ToString();
        }
        protected void btnluu_Click(object sender, EventArgs e)
        {
            btnhuy.Visible = false;
            btnluu.Visible = false;
            btnEditInfo.Visible = true;
            btnChangePwd.Visible = true;
            lbllop.Visible = false;
            lblmkcu.Visible = false;
            lblmkm.Visible = false;
            txtmkcu.Visible = false;
            txtmkm.Visible = false;
            drdclass.Visible = false;
            if(Key == 1)
            {
                try
                {
                    TblAcc_BLL.UpdateClass(int.Parse(Session["IDAcc"].ToString()), int.Parse(drdclass.SelectedValue.ToString()));
                    lblthongbao.Visible = true;
                    lblthongbao.Text = "Đã cập nhật lớp thành công";
                }
                catch (Exception)
                {

                    lblthongbao.Visible = true;
                    lblthongbao.Text = "Chưa cập nhật";
                }
                
            }
        }

        protected void btndanhdon_Click(object sender, EventArgs e)
        {
            Session["TrangThai"] = "DD";
            Response.Redirect("join-room.aspx");
        }

        protected void btnevent_Click(object sender, EventArgs e)
        {
            Session["TrangThai"] = "EV";
            Response.Redirect("chd-event.aspx");
        }
    }
}