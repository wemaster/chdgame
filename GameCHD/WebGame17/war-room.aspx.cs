using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChDGame
{
    public partial class war_room : System.Web.UI.Page
    {
        DataTable dtAccWar = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TrangThai"].Equals("notlogin"))
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (Session["TrangThai"].ToString() == "DD")
                {
                    DataTable dtAcc = new DataTable();
                    dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                    string iDRoom = dtAcc.Rows[0][16].ToString();
                    string rques = Request.QueryString["id"].ToString();
                    if(iDRoom != rques)
                    {
                        Response.Redirect("join-room.aspx");
                    }
                    ViewAcc();

                }
                if (Session["TrangThai"].ToString() == "Nor")
                {
                    Response.Redirect("mem-login.aspx");
                }
                else
                {
                    if (Session["TrangThai"].ToString() == "XH")
                    {
                        Response.Redirect("mem-login.aspx");
                    }
                }
            }

        }

        private void ViewAcc()
        {
            try
            {

                DataTable dtPhong = new DataTable();
                dtPhong = TblRoom_BLL.SelectRoom_ID(int.Parse(Request.QueryString["id"].ToString()));
                int SoNguoi = int.Parse(dtPhong.Rows[0][0].ToString());

                if (SoNguoi == 1)//Hiên thị nhân vật bên phải và trái
                {
                    DataTable dtWarRoom = new DataTable();
                    dtWarRoom = TblRoom_BLL.SelectWarRoom(int.Parse(Request.QueryString["id"].ToString()));
                    int IDAcc = int.Parse(dtWarRoom.Rows[0][1].ToString());
                    RptAcc1.DataSource = TblAcc_BLL.ViewAccID(IDAcc);
                    RptAcc1.DataBind();
                    Timer1.Enabled = true;
                    lblTime.Visible = false;
                }
                else
                {
                    //Hiển thị từ dữ liệu.
                    if (SoNguoi == 2)
                    {
                        DataTable dtWarRoom = new DataTable();
                        dtWarRoom = TblRoom_BLL.SelectWarRoom(int.Parse(Request.QueryString["id"].ToString()));
                        int IDAcc = int.Parse(dtWarRoom.Rows[0][1].ToString());
                        int IDAcc2 = int.Parse(dtWarRoom.Rows[0][2].ToString());
                        RptAcc1.DataSource = TblAcc_BLL.ViewAccID(IDAcc);
                        RptAcc1.DataBind();
                        RptAcc2.DataSource = TblAcc_BLL.ViewAccID(IDAcc2);
                        RptAcc2.DataBind();
                        Timer1.Enabled = false;
                        Panel1.Visible = true;
                        lblTime.Visible = true;
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "lblTime", "countDownTimer()", true);
                    }
                }
            }
            catch (Exception)
            {

                //Label1.Visible = true;
                //Label1.Text = "Chờ chút";
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            //if(btnNext.Text == "Next")
            //{
            //    AddKotaeNor();
            //}
            //if (btnNext.Text == "Finish")
            //{
            //    if (Session["TrangThai"].ToString() == "Nor")
            //    {
                    
            //        DataTable dt = new DataTable();
                    btnNext.Text = "Thoát";
                    //Endwar();

                    string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
                    base.Response.Write(close);
                    lblTime.Visible = false;

            //    //}
            //}
            //else
            //{
            //    if (btnNext.Text == "Thoát")
            //    {
            //        Response.Redirect("mem-login.aspx");
            //    }
            //}
        }

        private void Endwar()
        {
            XuLyTH();
            string rques = Request.QueryString["id"].ToString();
            TblRoom_BLL.UPDATE(int.Parse(Session["IDAcc"].ToString()), 0);
            TblRoom_BLL.UPDATE_NameAcc1(int.Parse(Request.QueryString["id"].ToString()),0,"");
            TblRoom_BLL.UPDATE_NameAcc2(int.Parse(Request.QueryString["id"].ToString()),0, "");
            TblRoom_BLL.deleteAL_TblwarRoom(int.Parse(Request.QueryString["id"].ToString()));
            TblRoom_BLL.deleteAL_TblTraLoi(int.Parse(Session["IDAcc"].ToString()));
            string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
            base.Response.Write(close);
            lblTime.Visible = false;
            if (btnNext.Text == "Finish")
            {
                if (Session["TrangThai"].ToString() == "DD")
                {
                    btnNext.Text = "Thoát";
                }
            }
            else
            {
                if (btnNext.Text == "Thoát")
                {
                    Response.Redirect("mem-login.aspx");
                }
            }
        }
        private void UpLevel()
        {
            dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            if (Convert.ToDouble(dtacc.Rows[0][2].ToString()) >= 100)
            {
                TblAcc_BLL.UpdateLevel(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtacc.Rows[0][4].ToString()) + 1);
                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), 0, Convert.ToDouble(dtacc.Rows[0][3].ToString()));
            }

        }
        private void UpNumWin()
        {
            dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtacc.Rows[0][6].ToString()) + 1);
        }
        private void UpNumLose()
        {
            dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtacc.Rows[0][7].ToString()) + 1);
        }
        DataTable dtacc = new DataTable();
        private void XuLyTH()
        {
             dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
             DataTable dtWarRoom = new DataTable();
             dtWarRoom = TblRoom_BLL.SelectWarRoom(int.Parse(Request.QueryString["id"].ToString()));
             int IDAcc = int.Parse(dtWarRoom.Rows[0][1].ToString());
             int IDAcc2 = int.Parse(dtWarRoom.Rows[0][2].ToString());
             int AccTrue = int.Parse(dtWarRoom.Rows[0][3].ToString());
            //Tính điểm Đúng 5 câu
             if (IDAcc == int.Parse(Session["IDAcc"].ToString()))
             {
                 if (AccTrue == 3)
                 {
                     TblAcc_BLL.UpdateExpPoint(IDAcc, Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 1, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 20);
                     if (Convert.ToDouble(dtacc.Rows[0][2].ToString()) >= 100)
                     {
                         TblAcc_BLL.UpdateLevel(IDAcc, int.Parse(dtacc.Rows[0][4].ToString()) + 1);
                         TblAcc_BLL.UpdateExpPoint(IDAcc, 0, Convert.ToDouble(dtacc.Rows[0][3].ToString()));
                     }
                     TblAcc_BLL.UpdateNumLose(IDAcc, int.Parse(dtacc.Rows[0][6].ToString()) + 1);
                     lblthongbao.Visible = true;
                     lblthongbao.Text = "Chúc mừng bạn đã chiến thắng, bạn nhận được +20 Point +20 ĐXH";
                 }
                 else
                 {
                     dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                     TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtacc.Rows[0][7].ToString()) + 1); 
                     lblthongbao.Visible = true;
                     lblthongbao.Text = "Thất bại. Bạn bị  -18 ĐXH";
                 }
             }
            else
             {
                 if (AccTrue == 3)
                 {
                     TblAcc_BLL.UpdateExpPoint(IDAcc2, Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 1, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 20);
                     if (Convert.ToDouble(dtacc.Rows[0][2].ToString()) >= 100)
                     {
                         TblAcc_BLL.UpdateLevel(IDAcc2, int.Parse(dtacc.Rows[0][4].ToString()) + 1);
                         TblAcc_BLL.UpdateExpPoint(IDAcc2, 0, Convert.ToDouble(dtacc.Rows[0][3].ToString()));
                     }
                     TblAcc_BLL.UpdateNumLose(IDAcc2, int.Parse(dtacc.Rows[0][6].ToString()) + 1);
                     lblthongbao.Visible = true;
                     lblthongbao.Text = "Chúc mừng bạn đã chiến thắng, bạn nhận được +20 Point +20 ĐXH";
                 }
                 else
                 {
                     dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                     TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtacc.Rows[0][7].ToString()) + 1);
                     lblthongbao.Visible = true;
                     lblthongbao.Text = "Thất bại. Bạn bị  -18 ĐXH";
                 }
             }
        }

        private void AddKotaeNor()
        {
            DataTable dtWarRoom = new DataTable();
            dtWarRoom = TblRoom_BLL.SelectWarRoom(int.Parse(Request.QueryString["id"].ToString()));
            int IDAcc = int.Parse(dtWarRoom.Rows[0][1].ToString());
            int IDAcc2 = int.Parse(dtWarRoom.Rows[0][2].ToString());
            int AccTrue = int.Parse(dtWarRoom.Rows[0][3].ToString());
            //Check đáp án A
            if (ckcA.Checked == true)
            {
                string DA = "A";
                if (hdflbl.Value == DA)
                {
                    TblRoom_BLL.Insert_traloi("yes", int.Parse(Session["IDAcc"].ToString()));
                    //đếm
                    if (IDAcc == int.Parse(Session["IDAcc"].ToString()))
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc1(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                            RpTDoi1.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                    else
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc2(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                            RptDoi2.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                }
                else
                {
                    TblRoom_BLL.Insert_traloi("False", int.Parse(Session["IDAcc"].ToString()));
                    RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                    RpTDoi1.DataBind();
                    RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                    RptDoi2.DataBind();
                }
            }
            //check B
            if (ckcB.Checked == true)
            {
                string DA = "B";
                if (hdflbl.Value == DA)
                {
                    TblRoom_BLL.Insert_traloi("yes", int.Parse(Session["IDAcc"].ToString()));
                    //đếm
                    if (IDAcc == int.Parse(Session["IDAcc"].ToString()))
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc1(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                            RpTDoi1.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                    else
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc2(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                            RptDoi2.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                }
                else
                {
                    TblRoom_BLL.Insert_traloi("False", int.Parse(Session["IDAcc"].ToString()));
                    RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                    RpTDoi1.DataBind();
                    RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                    RptDoi2.DataBind();
                }
            }
            //Check C
            if (ckcC.Checked == true)
            {
                string DA = "C";
                if (hdflbl.Value == DA)
                {
                    TblRoom_BLL.Insert_traloi("yes", int.Parse(Session["IDAcc"].ToString()));
                    //đếm
                    if (IDAcc == int.Parse(Session["IDAcc"].ToString()))
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc1(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                            RpTDoi1.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                    else
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc2(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                            RptDoi2.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                }
                else
                {
                    TblRoom_BLL.Insert_traloi("False", int.Parse(Session["IDAcc"].ToString()));
                    RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                    RpTDoi1.DataBind();
                    RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                    RptDoi2.DataBind();
                }
            }
            //Check D
            if (ckcD.Checked == true)
            {
                string DA = "D";
                if (hdflbl.Value == DA)
                {
                    TblRoom_BLL.Insert_traloi("yes", int.Parse(Session["IDAcc"].ToString()));
                    //đếm
                    if (IDAcc == int.Parse(Session["IDAcc"].ToString()))
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc1(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                            RpTDoi1.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                    else
                    {
                        if (AccTrue < 3)
                        {
                            TblRoom_BLL.Update_traloiAcc2(int.Parse(Request.QueryString["id"].ToString()), AccTrue++);
                            RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                            RptDoi2.DataBind();
                        }
                        else
                        {
                            Endwar();
                        }
                    }
                }
                else
                {
                    TblRoom_BLL.Insert_traloi("False", int.Parse(Session["IDAcc"].ToString()));
                    RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                    RpTDoi1.DataBind();
                    RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                    RptDoi2.DataBind();
                }
            }
            //Check Not tick
            if (ckcA.Checked == false && ckcB.Checked == false && ckcC.Checked == false && ckcD.Checked == false)
            {
                TblRoom_BLL.Insert_traloi("False", int.Parse(Session["IDAcc"].ToString()));
                RpTDoi1.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc);
                RpTDoi1.DataBind();
                RptDoi2.DataSource = TblRoom_BLL.SelectTraLoi(IDAcc2);
                RptDoi2.DataBind();
            }
            //End Check not check
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl); 
        }
    }
}