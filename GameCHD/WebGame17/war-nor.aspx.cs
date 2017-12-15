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
    public partial class war_nor : System.Web.UI.Page
    {
        private static int NumFalse = 0;
        private static Boolean Flag = false;
        private static int NumTrue = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["TrangThai"].Equals("notlogin"))
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    if (Session["TrangThai"].ToString() == "Nor")
                    {
                        DataTable dtAcc = new DataTable();
                        dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                        string iDRoom = dtAcc.Rows[0][17].ToString();
                        string rques = Request.QueryString["id"].ToString();
                        if (iDRoom != rques)
                        {
                            Response.Redirect("chd-join.aspx");
                        }
                        else
                        {
                            ViewAcc1();
                            ViewTest();
                            RptAcc2.DataSource = TblAcc_BLL.ViewBoss();
                            RptAcc2.DataBind();
                        }
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
        }
        private void ViewAcc1()
        {
            RptAcc1.DataSource = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            RptAcc1.DataBind();

        }
        DataTable dtacc = new DataTable();
        private void XuLyTH()
        {

            dtacc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            //Tính điểm Đúng 5 câu
            if (NumTrue == 5)
            {
                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 1, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 20);
                UpLevel();
                UpNumWin();
                lblthongbao.Visible = true;
                lblthongbao.Text = "Chúc mừng bạn đã chiến thắng, bạn nhận được +20 Point +1 DKN";
            }
            else
            {
                //Tinh 4 câu đúng
                if (NumTrue == 4)
                {
                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 0.75, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 15);
                    UpLevel();
                    UpNumWin();
                    lblthongbao.Visible = true;
                    lblthongbao.Text = "Chúc mừng bạn đã chiến thắng, bạn nhận được + 15 Point +0.75 DKN";
                }
                else
                {
                    //Tính 3 câu đúng
                    if (NumTrue == 3)
                    {
                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 0.5, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 10);
                        UpLevel();
                        UpNumWin();
                        lblthongbao.Visible = true;
                        lblthongbao.Text = "Chúc mừng bạn đã chiến thắng, bạn nhận được +10 Exp +0.5 DKN";
                    }
                    else
                    {
                        //Tính 2 câu đúng
                        if (NumTrue == 2)
                        {
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 0.25, Convert.ToDouble(dtacc.Rows[0][3].ToString()) + 5);
                            UpLevel();
                            UpNumLose();
                            lblthongbao.Visible = true;
                            lblthongbao.Text = "Thất bại, bạn nhận được +0.25 DKN";
                        }
                        else
                        {
                            //Tính 1 câu đúng
                            if (NumTrue == 1)
                            {
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtacc.Rows[0][2].ToString()) + 0.25, Convert.ToDouble(dtacc.Rows[0][3].ToString()));
                                UpLevel();
                                UpNumLose();
                                lblthongbao.Visible = true;
                                lblthongbao.Text = "Thất bại, bạn nhận được +0.25 DKN";
                            }
                            else
                            {
                                UpNumLose();
                                lblthongbao.Visible = true;
                                lblthongbao.Text = "Thất bại...:(";
                            }
                        }
                    }
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
        private void AddrowkotaeTrue()
        {
            DataTable dtkotae = new DataTable();
            dtkotae.Columns.Add("kotae", typeof(string));
            DataRow dr = dtkotae.NewRow();
            dr["kotae"] = "yes";
            dtkotae.Rows.Add(dr);
            ViewState["CurrentTable"] = dtkotae;
            rptchecktrue.DataSource = dtkotae;
            rptchecktrue.DataBind();
        }
        private void AddrowkotaeFalse()
        {
            DataTable dtkotae = new DataTable();
            dtkotae.Columns.Add("kotae", typeof(string));
            DataRow dr = dtkotae.NewRow();
            dr["kotae"] = "False";
            dtkotae.Rows.Add(dr);
            ViewState["CurrentTable"] = dtkotae;
            rptchecktrue.DataSource = dtkotae;
            rptchecktrue.DataBind();
            NumFalse++;
        }

        private void AddKotaeNor()
        {
            for (int item = 0; item < RptTest.Items.Count; item++)
            {
                CheckBox ck = RptTest.Items[item].FindControl("ckcA") as CheckBox;
                CheckBox ck1 = RptTest.Items[item].FindControl("ckcB") as CheckBox;
                CheckBox ck2 = RptTest.Items[item].FindControl("ckcC") as CheckBox;
                CheckBox ck3 = RptTest.Items[item].FindControl("ckcD") as CheckBox;
                HiddenField hdkq = RptTest.Items[item].FindControl("HiddenField1") as HiddenField;
                Label lblNo = RptTest.Items[item].FindControl("lblcau") as Label;
                //Check đáp án A
                if (ck.Checked == true)
                {
                    string DA = "A";
                    if (hdkq.Value == DA)
                    {
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                            DataRow drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["kotae"] = "yes";
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            rptchecktrue.DataSource = dtCurrentTable;
                            rptchecktrue.DataBind();
                            NumTrue++;

                        }
                        else
                        {
                            AddrowkotaeTrue();
                            NumTrue++;

                        }
                    }
                    else
                    {
                        if (Flag == false)
                        {
                            if (ViewState["CurrentTable"] != null)
                            {
                                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                                DataRow drCurrentRow = dtCurrentTable.NewRow();
                                drCurrentRow["kotae"] = "False";
                                dtCurrentTable.Rows.Add(drCurrentRow);
                                rptchecktrue.DataSource = dtCurrentTable;
                                rptchecktrue.DataBind();
                                NumFalse++;

                            }
                            else
                            {
                                AddrowkotaeFalse();
                                NumFalse++;

                            }
                        }
                        else
                        {
                            Flag = false;
                            //EndWar();
                        }
                    }
                }
                //check B
                if (ck1.Checked == true)
                {
                    string DA = "B";
                    if (hdkq.Value == DA)
                    {
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                            DataRow drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["kotae"] = "yes";
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            rptchecktrue.DataSource = dtCurrentTable;
                            rptchecktrue.DataBind();
                            NumTrue++;
                            ViewTest();
                        }
                        else
                        {
                            AddrowkotaeTrue();
                            NumTrue++;
                            ViewTest();
                        }
                    }
                    else
                    {
                        if (Flag == false)
                        {
                            if (ViewState["CurrentTable"] != null)
                            {
                                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                                DataRow drCurrentRow = dtCurrentTable.NewRow();
                                drCurrentRow["kotae"] = "False";
                                dtCurrentTable.Rows.Add(drCurrentRow);
                                rptchecktrue.DataSource = dtCurrentTable;
                                rptchecktrue.DataBind();
                                NumFalse++;
                                ViewTest();
                            }
                            else
                            {
                                AddrowkotaeFalse();
                                ViewTest();
                            }
                        }
                        else
                        {
                            Flag = false;
                            //EndWar();
                        }
                    }
                }
                //Check C
                if (ck2.Checked == true)
                {
                    string DA = "C";
                    if (hdkq.Value == DA)
                    {
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                            DataRow drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["kotae"] = "yes";
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            rptchecktrue.DataSource = dtCurrentTable;
                            rptchecktrue.DataBind();
                            NumTrue++;

                        }
                        else
                        {
                            AddrowkotaeTrue();
                            NumTrue++;

                        }
                    }
                    else
                    {
                        if (Flag == false)
                        {
                            if (ViewState["CurrentTable"] != null)
                            {
                                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                                DataRow drCurrentRow = dtCurrentTable.NewRow();
                                drCurrentRow["kotae"] = "False";
                                dtCurrentTable.Rows.Add(drCurrentRow);
                                rptchecktrue.DataSource = dtCurrentTable;
                                rptchecktrue.DataBind();
                                NumFalse++;

                            }
                            else
                            {
                                AddrowkotaeFalse();
                                ViewTest();
                            }
                        }
                        else
                        {
                            Flag = false;
                            //EndWar();
                        }
                    }
                }
                //Check D
                if (ck3.Checked == true)
                {
                    string DA = "D";
                    if (hdkq.Value == DA)
                    {
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                            DataRow drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["kotae"] = "yes";
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            rptchecktrue.DataSource = dtCurrentTable;
                            rptchecktrue.DataBind();
                            NumTrue++;

                        }
                        else
                        {
                            AddrowkotaeTrue();
                            NumTrue++;

                        }
                    }
                    else
                    {
                        if (Flag == false)
                        {
                            if (ViewState["CurrentTable"] != null)
                            {
                                DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                                DataRow drCurrentRow = dtCurrentTable.NewRow();
                                drCurrentRow["kotae"] = "False";
                                dtCurrentTable.Rows.Add(drCurrentRow);
                                rptchecktrue.DataSource = dtCurrentTable;
                                rptchecktrue.DataBind();
                                NumFalse++;

                            }
                            else
                            {
                                AddrowkotaeFalse();

                            }
                        }
                        else
                        {
                            Flag = false;
                            // EndWar();
                        }
                    }
                }
                //Check Not tick
                if (ck.Checked == false && ck1.Checked == false && ck2.Checked == false && ck3.Checked == false)
                {
                    if (Flag == false)
                    {
                        if (ViewState["CurrentTable"] != null)
                        {
                            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
                            DataRow drCurrentRow = dtCurrentTable.NewRow();
                            drCurrentRow["kotae"] = "False";
                            dtCurrentTable.Rows.Add(drCurrentRow);
                            rptchecktrue.DataSource = dtCurrentTable;
                            rptchecktrue.DataBind();
                            NumFalse++;

                        }
                        else
                        {
                            AddrowkotaeFalse();

                        }
                    }
                    else
                    {
                        Flag = false;
                        //EndWar();
                    }
                }
                //End Check not check
            }
        }

        private void ViewTest()
        {
            if (!IsPostBack)
            {
                DataTable dtAcc = new DataTable();
                dtAcc = TblAcc_BLL.SelectCauTest(int.Parse(Session["IDSub"].ToString()));
                int IDcau = int.Parse(dtAcc.Rows[0][0].ToString());
                RptTest.DataSource = TblTest_BLL.ViewTestID(int.Parse(Session["IDSub"].ToString()), 6, IDcau);
                RptTest.DataBind();

            }
        }
        private void TotalTenNor()
        {

            //Tính điểm thoát trận 1 0.75, 0,5 ,0,25

            // Exp, Point 
            // NumWin , NumLose
            // Up Level

        }
        protected void btnfinish_Click(object sender, EventArgs e)
        {
            if (btnfinish.Text == "Finish")
            {
                if (Session["TrangThai"].ToString() == "Nor")
                {
                    AddKotaeNor();
                    DataTable dt = new DataTable();
                    RptTest.DataSource = dt;
                    RptTest.DataBind();
                    btnfinish.Text = "Thoát";
                    Endwar();

                    string close = @"<script type='text/javascript'>
                                window.returnValue = true;
                                window.close();
                                </script>";
                    base.Response.Write(close);
                    myform.Visible = false;

                }
            }
            else
            {
                if (btnfinish.Text == "Thoát")
                {
                    Response.Redirect("mem-login.aspx");
                }
            }
        }

        private void Endwar()
        {
            XuLyTH();
            string rques = Request.QueryString["id"].ToString();
            string idq = Request.QueryString["idf"].ToString();
            TblRoom_BLL.UPDATE_Chuong_Note(int.Parse(rques),int.Parse(idq),0);
            TblRoom_BLL.UPDATE_Chuong_NameAcc1(int.Parse(rques),int.Parse(idq),"");
            TblRoom_BLL.UPDATE_chuongAcc(int.Parse(Session["IDAcc"].ToString()),0);
            NumTrue = 0;
            NumFalse = 0;
        }
    }
}