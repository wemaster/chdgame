using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGame17
{
    public partial class index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"].ToString() == "Khách")
            {
                Logbtn();
                lbluser.Text = Session["Username"].ToString();
            }
            else
            {
                if (Session["Quyen"].ToString() == "1")
                {
                    UnogbtnAdmin();
                    lbluser.Text = lbluser.Text = Session["Username"].ToString() + " - " + Session["NameQuyen"].ToString();
                }
                else
                {
                    unlogbtn();
                    lbluser.Text = lbluser.Text = Session["Username"].ToString() + " - " + Session["NameQuyen"].ToString();
                }
            }
        }
        private void unlogbtn()
        {
            lkbLogin.Visible = false;
            lkbOut.Visible = true;
        }

        private void Logbtn()
        {
            lkbLogin.Visible = true;
            lkbOut.Visible = false;
        }
        private void UnogbtnAdmin()
        {
            lkbLogin.Visible = false;
            lkbOut.Visible = true;
            lkbAdmin.Visible = true;
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtAcc = new DataTable();
                dtAcc = TblAcc_BLL.CheckLogin(txtusername.Text, txtpwd.Text);
                if (dtAcc.Rows.Count > 0)
                {
                    Session["IDAcc"] = dtAcc.Rows[0][0].ToString();
                    Session["Username"] = dtAcc.Rows[0][2].ToString();
                    Session["IDClass"] = dtAcc.Rows[0][1].ToString();
                    Session["Quyen"] = dtAcc.Rows[0][3].ToString();
                    Session["NameQuyen"] = dtAcc.Rows[0][4].ToString();
                    if (Session["Quyen"].ToString() == "1")
                    {
                        UnogbtnAdmin();
                        lbluser.Text = Session["Username"].ToString() + " - " + Session["NameQuyen"].ToString();
                        Response.Redirect("mem-login.aspx");
                    }
                    else
                    {
                        Response.Redirect("mem-login.aspx");
                    }
                }
                else
                {
                    lbltb.Visible = true;
                    lbltb.Text = "*Sai Username hoặc Password.  ";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "document.getElementById('id01').style.display='block';", true);
                }
            }
            catch (Exception)
            {

                lbltb.Visible = true;
                lbltb.Text = "*Sai Username hoặc Password.  ";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "document.getElementById('id01').style.display='block';", true);
            }

        }

        protected void lbtHome_Click(object sender, EventArgs e)
        {
            if (Session["Username"].ToString() == "Khách")
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("mem-login.aspx");
            }
        }

        protected void lkbOut_Click(object sender, EventArgs e)
        {
            Logbtn();
            Session["Username"] = "Khách";
            lbluser.Text = Session["Username"].ToString();
            Response.Redirect("Default.aspx");
        }

        protected void lkbAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/admin/Default.aspx");
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserReg.Text == "")
                {
                    lblreg.Visible = true;
                    lblreg.Text = "*Lỗi #102. Tên đăng nhập không để trống ";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "document.getElementById('id01').style.display='block';", true);
                }
                else
                {
                    string dt = DateTime.Now.ToString("yyyy-MM-dd");
                    TblAcc_BLL.RegTaiKhoan(txtUserReg.Text, txtconfirmPwd.Text, txtemail.Text, dt);
                    DataTable dtAcc = new DataTable();
                    dtAcc = TblAcc_BLL.CheckLogin(txtUserReg.Text, txtconfirmPwd.Text);
                    if (dtAcc.Rows.Count > 0)
                    {
                        Session["IDAcc"] = dtAcc.Rows[0][0].ToString();
                        Session["Username"] = dtAcc.Rows[0][2].ToString();
                        Session["IDClass"] = dtAcc.Rows[0][1].ToString();
                        Session["Quyen"] = dtAcc.Rows[0][3].ToString();
                        Session["NameQuyen"] = dtAcc.Rows[0][4].ToString();
                        if (Session["Quyen"].ToString() == "1")
                        {
                            UnogbtnAdmin();
                            lbluser.Text = Session["Username"].ToString() + " - " + Session["NameQuyen"].ToString();
                            Response.Redirect("mem-login.aspx");
                        }
                        else
                        {
                            Response.Redirect("mem-login.aspx");
                        }
                    }
                }

            }
            catch (Exception)
            {
                lblreg.Visible = true;
                lblreg.Text = "*Đăng ký không thành công.Lỗi #101.  ";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "document.getElementById('id01').style.display='block';", true);
            }
        }
    }
}