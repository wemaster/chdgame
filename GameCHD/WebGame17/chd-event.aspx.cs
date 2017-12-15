using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
namespace WebGame17
{
    public partial class chd_event : System.Web.UI.Page
    {
        private static string Cau;
        private static Boolean Flag = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"].ToString() == "Khách" || Session["IDAcc"].ToString() == "")
            {
                Response.Redirect("Default.aspx");
            }
        }

        DataTable dtAcc = new DataTable();
        protected void Imbtcau1_Click(object sender, ImageClickEventArgs e)
        {
                myform.Visible = true;
                Panel1.Visible = true;
                Image1.Visible = false;
                Panel2.Visible = true;
                lbladmin.Visible = false;
                lblketqua.Visible = false;
                RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                RptTest.DataBind();
                Cau = "Câu 1";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }
        private void XLTHFalse()
        {
            UpNumLose();
        }

        private void XuLYTHTrue()
        {
            UpLevel();
            UpNumWin();
        }

        private void UpLevel()
        {
            dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            if (Convert.ToDouble(dtAcc.Rows[0][2].ToString()) >= 100)
            {
                TblAcc_BLL.UpdateLevel(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtAcc.Rows[0][4].ToString()) + 1);
                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), 0, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
            }

        }
        private void UpNumWin()
        {
            dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtAcc.Rows[0][6].ToString()) + 1);
        }
        private void UpNumLose()
        {
            dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            TblAcc_BLL.UpdateNumLose(int.Parse(Session["IDAcc"].ToString()), int.Parse(dtAcc.Rows[0][7].ToString()) + 1);
        }

        protected void ImageBtcau2_Click(object sender, ImageClickEventArgs e)
        {

                dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                int Level = int.Parse(dtAcc.Rows[0][4].ToString());
                if (Level > 5)
                {
                    myform.Visible = true;
                    Panel1.Visible = true;
                    Image1.Visible = false;
                    Panel2.Visible = true;
                    lbladmin.Visible = false;
                    lblketqua.Visible = false;
                        RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                        RptTest.DataBind();

                    Cau = "Câu 2";

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
                else
                {
                    myform.Visible = false;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    lbladmin.Visible = true;
                    lblketqua.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Text = "Thông báo:";
                    lblketqua.Text = "Yêu cầu cấp 6";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }


        }

        protected void ImgBTcau3_Click(object sender, ImageClickEventArgs e)
        {

                dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                int Level = int.Parse(dtAcc.Rows[0][4].ToString());
                if (Level > 6)
                {
                    myform.Visible = true;
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Visible = false;
                    lblketqua.Visible = false;

                        RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                        RptTest.DataBind();
                    Cau = "Câu 3";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
                else
                {
                    myform.Visible = false;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    lbladmin.Visible = true;
                    lblketqua.Visible = true;
                    lbladmin.Text = "Thông báo:";
                    lblketqua.Text = "Yêu cầu cấp 6";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }

        }

        protected void Imcau4_Click(object sender, ImageClickEventArgs e)
        {

                dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                int Level = int.Parse(dtAcc.Rows[0][4].ToString());
                if (Level > 7)
                {
                    myform.Visible = true;
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Visible = false;
                    lblketqua.Visible = false;
                        RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                        RptTest.DataBind();

                    Cau = "Câu 4";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
                else
                {
                    myform.Visible = false;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    lbladmin.Visible = true;
                    lblketqua.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Text = "Thông báo:";
                    lblketqua.Text = "Yêu cầu cấp 6";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }

        }

        protected void Imgcau5_Click(object sender, ImageClickEventArgs e)
        {

                dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                int Level = int.Parse(dtAcc.Rows[0][4].ToString());
                if (Level >= 10)
                {
                    myform.Visible = true;
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Visible = false;
                    lblketqua.Visible = false;

                        RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                        RptTest.DataBind();

                    Cau = "Câu 5";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
                else
                {
                    myform.Visible = false;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    lbladmin.Visible = true;
                    lblketqua.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Text = "Thông báo:";
                    lblketqua.Text = "Yêu cầu cấp 10";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }

        }

        protected void Imgcau6_Click(object sender, ImageClickEventArgs e)
        {

                dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                int Level = int.Parse(dtAcc.Rows[0][4].ToString());
                if (Level >= 12)
                {
                    myform.Visible = true;
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Visible = false;
                    lblketqua.Visible = false;

                        RptTest.DataSource = TblTest_BLL.ViewTestIDTT(6);
                        RptTest.DataBind();

                    Cau = "Câu 6";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
                else
                {
                    myform.Visible = false;
                    Panel2.Visible = false;
                    Panel1.Visible = false;
                    lbladmin.Visible = true;
                    lblketqua.Visible = true;
                    Image1.Visible = false;
                    lbladmin.Text = "Thông báo:";
                    lblketqua.Text = "Yêu cầu cấp 12";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }
        }

        protected void btnfinish_Click(object sender, EventArgs e)
        {
            AddKotaeTrue();
        }
        #region
        private void AddKotaeTrue()
        {
            dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
            for (int item = 0; item < RptTest.Items.Count; item++)
            {
                CheckBox ck = RptTest.Items[item].FindControl("ckcA") as CheckBox;
                CheckBox ck1 = RptTest.Items[item].FindControl("ckcB") as CheckBox;
                CheckBox ck2 = RptTest.Items[item].FindControl("ckcC") as CheckBox;
                CheckBox ck3 = RptTest.Items[item].FindControl("ckcD") as CheckBox;
                HiddenField hdkq = RptTest.Items[item].FindControl("hdflbl") as HiddenField;
                //Check đáp án A
                if (ck.Checked == true)
                {
                    string DA = "A";
                    if (hdkq.Value == DA)
                    {
                        XuLYTHTrue();
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            Panel2.Visible = false;
                            lbladmin.Visible = true;
                            lblketqua.Visible = true;
                            Image1.Visible = true;
                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                            lblketqua.Text = "Bạn nhận được +50 Exp +200 ";
                            Image1.Visible = true;
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 200);
                            MoButtonCau1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                Panel2.Visible = false;
                                lbladmin.Visible = true;
                                lblketqua.Visible = true;
                                Image1.Visible = true;
                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                lblketqua.Text = "Bạn nhận được +60Exp  +1 Pet  +300 ";
                                Image1.Visible = true;
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 60, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 300);
                                MoButtonCau2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    Panel2.Visible = false;
                                    lbladmin.Visible = true;
                                    lblketqua.Visible = true;
                                    Image1.Visible = true;
                                    lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                    lblketqua.Text = "Bạn nhận được +70Exp  +1Champ  +400 ";
                                    Image1.Visible = true;
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 70, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 400);
                                    MoButtonCau3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        Panel2.Visible = false;
                                        lbladmin.Visible = true;
                                        lblketqua.Visible = true;
                                        Image1.Visible = true;
                                        lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                        lblketqua.Text = "Bạn nhận được +80Exp  +1 Pet  +500 ";
                                        Image1.Visible = true;
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 80, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 500);
                                        MoButtonCau4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            Panel2.Visible = false;
                                            lbladmin.Visible = true;
                                            lblketqua.Visible = true;
                                            Image1.Visible = true;
                                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                            lblketqua.Text = "Bạn nhận được +90Exp  +1 Champ +1Pet  +600 ";
                                            Image1.Visible = true;
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 600);
                                            MoButtonCau5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                Panel2.Visible = false;
                                                lbladmin.Visible = true;
                                                lblketqua.Visible = true;
                                                Image1.Visible = true;
                                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                                lblketqua.Text = "Bạn nhận được +100Exp  +1 Champ +2Pet  +700 ";
                                                Image1.Visible = true;
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 700);
                                                MoButtonCau6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            lbladmin.Visible = true;
                            lblketqua.Visible = true;
                            Panel2.Visible = false;
                            myform.Visible = false;
                            lbladmin.Text = "Bạn đã thua!";
                            lblketqua.Text = "Bạn bị -25Exp ";
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 25, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
                            XLTHFalse();
                            DongButton1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                lbladmin.Visible = true;
                                Panel2.Visible = false;
                                myform.Visible = false;
                                lblketqua.Visible = true;
                                lbladmin.Text = "Bạn đã thua!";
                                lblketqua.Text = "Bạn bị -50Exp -100 Point";
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 100);
                                XLTHFalse();
                                DongButton2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    lbladmin.Visible = true;
                                    Panel2.Visible = false;
                                    myform.Visible = false;
                                    lblketqua.Visible = true;
                                    lbladmin.Text = "Bạn đã thua!";
                                    lblketqua.Text = "Bạn bị -50Exp -200 Point";
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 200);
                                    XLTHFalse();
                                    DongButton3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        lbladmin.Visible = true;
                                        Panel2.Visible = false;
                                        myform.Visible = false;
                                        lblketqua.Visible = true;
                                        lbladmin.Text = "Bạn đã thua!";
                                        lblketqua.Text = "Bạn bị -50Exp -300 Point";
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 300);
                                        XLTHFalse();
                                        DongButton4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            lbladmin.Visible = true;
                                            Panel2.Visible = false;
                                            myform.Visible = false;
                                            lblketqua.Visible = true;
                                            lbladmin.Text = "Bạn đã thua!";
                                            lblketqua.Text = "Bạn bị -50Exp -400 Point";
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 400);
                                            XLTHFalse();
                                            DongButton5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                lbladmin.Visible = true;
                                                Panel2.Visible = false;
                                                myform.Visible = false;
                                                lblketqua.Visible = true;
                                                lbladmin.Text = "Bạn đã thua!";
                                                lblketqua.Text = "Bạn bị -50Exp -500 Point";
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 500);
                                                XLTHFalse();
                                                DongButton6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //check B
                if (ck1.Checked == true)
                {
                    string DA = "B";
                    if (hdkq.Value == DA)
                    {
                        XuLYTHTrue();
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            Panel2.Visible = false;
                            lbladmin.Visible = true;
                            lblketqua.Visible = true;
                            Image1.Visible = true;
                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                            lblketqua.Text = "Bạn nhận được +50 Exp +200 ";
                            Image1.Visible = true;
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 200);
                            MoButtonCau1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                Panel2.Visible = false;
                                lbladmin.Visible = true;
                                lblketqua.Visible = true;
                                Image1.Visible = true;
                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                lblketqua.Text = "Bạn nhận được +60Exp  +1 Pet  +300 ";
                                Image1.Visible = true;
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 60, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 300);
                                MoButtonCau2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    Panel2.Visible = false;
                                    lbladmin.Visible = true;
                                    lblketqua.Visible = true;
                                    Image1.Visible = true;
                                    lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                    lblketqua.Text = "Bạn nhận được +70Exp  +1Champ  +400 ";
                                    Image1.Visible = true;
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 70, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 400);
                                    MoButtonCau3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        Panel2.Visible = false;
                                        lbladmin.Visible = true;
                                        lblketqua.Visible = true;
                                        Image1.Visible = true;
                                        lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                        lblketqua.Text = "Bạn nhận được +80Exp  +1 Pet  +500 ";
                                        Image1.Visible = true;
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 80, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 500);
                                        MoButtonCau4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            Panel2.Visible = false;
                                            lbladmin.Visible = true;
                                            lblketqua.Visible = true;
                                            Image1.Visible = true;
                                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                            lblketqua.Text = "Bạn nhận được +90Exp  +1 Champ +1Pet +600 ";
                                            Image1.Visible = true;
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 600);
                                            MoButtonCau5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                Panel2.Visible = false;
                                                lbladmin.Visible = true;
                                                lblketqua.Visible = true;
                                                Image1.Visible = true;
                                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                                lblketqua.Text = "Bạn nhận được +100Exp  +1 Champ +2Pet +700 ";
                                                Image1.Visible = true;
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 700);
                                                MoButtonCau6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            lbladmin.Visible = true;
                            Panel2.Visible = false;
                            myform.Visible = false;
                            lblketqua.Visible = true;
                            lbladmin.Text = "Bạn đã thua!";
                            lblketqua.Text = "Bạn bị -25Exp ";
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 25, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
                            XLTHFalse();
                            DongButton1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                lbladmin.Visible = true;
                                Panel2.Visible = false;
                                myform.Visible = false;
                                lblketqua.Visible = true;
                                lbladmin.Text = "Bạn đã thua!";
                                lblketqua.Text = "Bạn bị -50Exp -100 Point";
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 100);
                                XLTHFalse();
                                DongButton2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    lbladmin.Visible = true;
                                    Panel2.Visible = false;
                                    myform.Visible = false;
                                    lblketqua.Visible = true;
                                    lbladmin.Text = "Bạn đã thua!";
                                    lblketqua.Text = "Bạn bị -50Exp -200 Point";
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 200);
                                    XLTHFalse();
                                    DongButton3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        lbladmin.Visible = true;
                                        Panel2.Visible = false;
                                        lblketqua.Visible = true;
                                        myform.Visible = false;
                                        lbladmin.Text = "Bạn đã thua!";
                                        lblketqua.Text = "Bạn bị -50Exp -300 Point";
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 300);
                                        XLTHFalse();
                                        DongButton4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            lbladmin.Visible = true;
                                            Panel2.Visible = false;
                                            myform.Visible = false;
                                            lblketqua.Visible = true;
                                            lbladmin.Text = "Bạn đã thua!";
                                            lblketqua.Text = "Bạn bị -50Exp -400 Point";
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 400);
                                            XLTHFalse();
                                            DongButton5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                lbladmin.Visible = true;
                                                Panel2.Visible = false;
                                                lblketqua.Visible = true;
                                                myform.Visible = false;
                                                lbladmin.Text = "Bạn đã thua!";
                                                lblketqua.Text = "Bạn bị -50Exp -500 Point";
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 500);
                                                XLTHFalse();
                                                DongButton6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Check C
                if (ck2.Checked == true)
                {
                    string DA = "C";
                    if (hdkq.Value == DA)
                    {
                        XuLYTHTrue();
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            Panel2.Visible = false;
                            lbladmin.Visible = true;
                            lblketqua.Visible = true;
                            Image1.Visible = true;
                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                            lblketqua.Text = "Bạn nhận được +50 Exp +200 ";
                            Image1.Visible = true;
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 200);
                            MoButtonCau1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                Panel2.Visible = false;
                                lbladmin.Visible = true;
                                lblketqua.Visible = true;
                                Image1.Visible = true;
                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                lblketqua.Text = "Bạn nhận được +60Exp  +1 Pet  +300 ";
                                Image1.Visible = true;
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 60, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 300);
                                MoButtonCau2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    Panel2.Visible = false;
                                    lbladmin.Visible = true;
                                    lblketqua.Visible = true;
                                    Image1.Visible = true;
                                    lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                    lblketqua.Text = "Bạn nhận được +70Exp  +1Champ  +400 ";
                                    Image1.Visible = true;
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 70, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 400);
                                    MoButtonCau3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        Panel2.Visible = false;
                                        lbladmin.Visible = true;
                                        lblketqua.Visible = true;
                                        Image1.Visible = true;
                                        lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                        lblketqua.Text = "Bạn nhận được +80Exp  +1 Pet  +500 ";
                                        Image1.Visible = true;
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 80, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 500);
                                        MoButtonCau4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            Panel2.Visible = false;
                                            lbladmin.Visible = true;
                                            lblketqua.Visible = true;
                                            Image1.Visible = true;
                                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                            lblketqua.Text = "Bạn nhận được +90Exp  +1 Champ +1Pet +600 ";
                                            Image1.Visible = true;
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 600);
                                            MoButtonCau5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                Panel2.Visible = false;
                                                lbladmin.Visible = true;
                                                lblketqua.Visible = true;
                                                Image1.Visible = true;
                                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                                lblketqua.Text = "Bạn nhận được +100Exp  +1 Champ +2Pet  +700 ";
                                                Image1.Visible = true;
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 700);
                                                MoButtonCau6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            lbladmin.Visible = true;
                            Panel2.Visible = false;
                            myform.Visible = false;
                            lblketqua.Visible = true;
                            lbladmin.Text = "Bạn đã thua!";
                            lblketqua.Text = "Bạn bị -25Exp ";
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 25, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
                            XLTHFalse();
                            DongButton1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                lbladmin.Visible = true;
                                Panel2.Visible = false;
                                lblketqua.Visible = true;
                                myform.Visible = false;
                                lbladmin.Text = "Bạn đã thua!";
                                lblketqua.Text = "Bạn bị -50Exp -100 Point";
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 100);
                                XLTHFalse();
                                DongButton2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    lbladmin.Visible = true;
                                    Panel2.Visible = false;
                                    myform.Visible = false;
                                    lblketqua.Visible = true;
                                    lbladmin.Text = "Bạn đã thua!";
                                    lblketqua.Text = "Bạn bị -50Exp -200 Point";
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 200);
                                    XLTHFalse();
                                    DongButton3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        lbladmin.Visible = true;
                                        Panel2.Visible = false;
                                        lblketqua.Visible = true;
                                        myform.Visible = false;
                                        lbladmin.Text = "Bạn đã thua!";
                                        lblketqua.Text = "Bạn bị -50Exp -300 Point";
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 300);
                                        XLTHFalse();
                                        DongButton4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            lbladmin.Visible = true;
                                            Panel2.Visible = false;
                                            lblketqua.Visible = true;
                                            myform.Visible = false;
                                            lbladmin.Text = "Bạn đã thua!";
                                            lblketqua.Text = "Bạn bị -50Exp -400 Point";
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 400);
                                            XLTHFalse();
                                            DongButton5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                lbladmin.Visible = true;
                                                Panel2.Visible = false;
                                                lblketqua.Visible = true;
                                                myform.Visible = false;
                                                lbladmin.Text = "Bạn đã thua!";
                                                lblketqua.Text = "Bạn bị -50Exp -500 Point";
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 500);
                                                XLTHFalse();
                                                DongButton6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Check D
                if (ck3.Checked == true)
                {
                    string DA = "D";
                    if (hdkq.Value == DA)
                    {
                        XuLYTHTrue();
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            Panel2.Visible = false;
                            lbladmin.Visible = true;
                            lblketqua.Visible = true;
                            Image1.Visible = true;
                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                            lblketqua.Text = "Bạn nhận được +50 Exp +200 ";
                            Image1.Visible = true;
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 200);
                            MoButtonCau1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                Panel2.Visible = false;
                                lbladmin.Visible = true;
                                lblketqua.Visible = true;
                                Image1.Visible = true;
                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                lblketqua.Text = "Bạn nhận được +60Exp  +1 Pet  +300 ";
                                Image1.Visible = true;
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 60, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 300);
                                MoButtonCau2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    Panel2.Visible = false;
                                    lbladmin.Visible = true;
                                    lblketqua.Visible = true;
                                    Image1.Visible = true;
                                    lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                    lblketqua.Text = "Bạn nhận được +70Exp  +1Champ  +400 ";
                                    Image1.Visible = true;
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 70, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 400);
                                    MoButtonCau3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        Panel2.Visible = false;
                                        lbladmin.Visible = true;
                                        lblketqua.Visible = true;
                                        Image1.Visible = true;
                                        lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                        lblketqua.Text = "Bạn nhận được +80Exp  +1 Pet  +500 ";
                                        Image1.Visible = true;
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 80, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 500);
                                        MoButtonCau4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            Panel2.Visible = false;
                                            lbladmin.Visible = true;
                                            lblketqua.Visible = true;
                                            Image1.Visible = true;
                                            lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                            lblketqua.Text = "Bạn nhận được +90Exp  +1 Champ +1Pet +600 ";
                                            Image1.Visible = true;
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 600);
                                            MoButtonCau5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                Panel2.Visible = false;
                                                lbladmin.Visible = true;
                                                lblketqua.Visible = true;
                                                Image1.Visible = true;
                                                lbladmin.Text = "Chúc mừng bạn đã chiến thắng!";
                                                lblketqua.Text = "Bạn nhận được +100Exp  +1 Champ +2Pet +700 ";
                                                Image1.Visible = true;
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) + 90, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) + 700);
                                                MoButtonCau6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Cau == "Câu 1")
                        {
                            Panel1.Visible = false;
                            lbladmin.Visible = true;
                            Panel2.Visible = false;
                            myform.Visible = false;
                            lblketqua.Visible = true;
                            lbladmin.Text = "Bạn đã thua!";
                            lblketqua.Text = "Bạn bị -25Exp ";
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 25, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
                            XLTHFalse();
                            DongButton1();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 2")
                            {
                                Panel1.Visible = false;
                                lbladmin.Visible = true;
                                Panel2.Visible = false;
                                myform.Visible = false;
                                lblketqua.Visible = true;
                                lbladmin.Text = "Bạn đã thua!";
                                lblketqua.Text = "Bạn bị -50Exp -100 Point";
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 100);
                                XLTHFalse();
                                DongButton2();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 3")
                                {
                                    Panel1.Visible = false;
                                    lbladmin.Visible = true;
                                    Panel2.Visible = false;
                                    myform.Visible = false;
                                    lblketqua.Visible = true;
                                    lbladmin.Text = "Bạn đã thua!";
                                    lblketqua.Text = "Bạn bị -50Exp -200 Point";
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 200);
                                    XLTHFalse();
                                    DongButton3();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 4")
                                    {
                                        Panel1.Visible = false;
                                        lbladmin.Visible = true;
                                        Panel2.Visible = false;
                                        myform.Visible = false;
                                        lblketqua.Visible = true;
                                        lbladmin.Text = "Bạn đã thua!";
                                        lblketqua.Text = "Bạn bị -50Exp -300 Point";
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 300);
                                        XLTHFalse();
                                        DongButton4();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 5")
                                        {
                                            Panel1.Visible = false;
                                            lbladmin.Visible = true;
                                            Panel2.Visible = false;
                                            myform.Visible = false;
                                            lblketqua.Visible = true;
                                            lbladmin.Text = "Bạn đã thua!";
                                            lblketqua.Text = "Bạn bị -50Exp -400 Point";
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 400);
                                            XLTHFalse();
                                            DongButton5();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                        else
                                        {
                                            if (Cau == "Câu 6")
                                            {
                                                Panel1.Visible = false;
                                                lbladmin.Visible = true;
                                                Panel2.Visible = false;
                                                myform.Visible = false;
                                                lblketqua.Visible = true;
                                                lbladmin.Text = "Bạn đã thua!";
                                                lblketqua.Text = "Bạn bị -50Exp -500 Point";
                                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 500);
                                                XLTHFalse();
                                                DongButton6();
                                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Check Not tick
                if (ck.Checked == false && ck1.Checked == false && ck2.Checked == false && ck3.Checked == false)
                {
                    if (Cau == "Câu 1")
                    {
                        Panel1.Visible = false;
                        Panel2.Visible = false;
                        lblketqua.Visible = true;
                        lbladmin.Visible = true;
                        Image1.Visible = false;
                        lbladmin.Text = "Bạn đã thua!";
                        lblketqua.Text = "Bạn bị -25Exp ";
                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 25, Convert.ToDouble(dtAcc.Rows[0][3].ToString()));
                        XLTHFalse();
                        DongButton1();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                    }
                    else
                    {
                        if (Cau == "Câu 2")
                        {

                            Panel1.Visible = false;
                            Panel2.Visible = false;
                            lblketqua.Visible = true;
                            lbladmin.Visible = true;
                            Image1.Visible = false;
                            lbladmin.Text = "Bạn đã thua!";
                            lblketqua.Text = "Bạn bị -50Exp -100 Point";
                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 100);
                            XLTHFalse();
                            DongButton2();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                        else
                        {
                            if (Cau == "Câu 3")
                            {
                                Panel1.Visible = false;
                                Panel2.Visible = false;
                                lblketqua.Visible = true;
                                lbladmin.Visible = true;
                                Image1.Visible = false;
                                lbladmin.Text = "Bạn đã thua!";
                                lblketqua.Text = "Bạn bị -50Exp -200 Point";
                                TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 200);
                                XLTHFalse();
                                DongButton3();
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            }
                            else
                            {
                                if (Cau == "Câu 4")
                                {
                                    Panel1.Visible = false;
                                    Panel2.Visible = false;
                                    lblketqua.Visible = true;
                                    lbladmin.Visible = true;
                                    Image1.Visible = false;
                                    lbladmin.Text = "Bạn đã thua!";
                                    lblketqua.Text = "Bạn bị -50Exp -300 Point";
                                    TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 300);
                                    XLTHFalse();
                                    DongButton4();
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                }
                                else
                                {
                                    if (Cau == "Câu 5")
                                    {
                                        Panel1.Visible = false;
                                        Panel2.Visible = false;
                                        lblketqua.Visible = true;
                                        lbladmin.Visible = true;
                                        Image1.Visible = false;
                                        lbladmin.Text = "Bạn đã thua!";
                                        lblketqua.Text = "Bạn bị -50Exp -400 Point";
                                        TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 400);
                                        XLTHFalse();
                                        DongButton5();
                                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                    }
                                    else
                                    {
                                        if (Cau == "Câu 6")
                                        {
                                            Panel1.Visible = false;
                                            Panel2.Visible = false;
                                            lblketqua.Visible = true;
                                            lbladmin.Visible = true;
                                            Image1.Visible = false;
                                            lbladmin.Text = "Bạn đã thua!";
                                            lblketqua.Text = "Bạn bị -50Exp -500 Point";
                                            TblAcc_BLL.UpdateExpPoint(int.Parse(Session["IDAcc"].ToString()), Convert.ToDouble(dtAcc.Rows[0][2].ToString()) - 50, Convert.ToDouble(dtAcc.Rows[0][3].ToString()) - 500);
                                            XLTHFalse();
                                            DongButton6();
                                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //End Check not check
            }
        }
        #endregion
        #region
        private void DongButton1()
        {
            Imbtcau1.Visible = true;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau1()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = true;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }
        private void DongButton2()
        {
            Imbtcau1.Visible = true;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau2()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = true;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }
        private void DongButton3()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = true;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau3()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = true;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }
        private void DongButton4()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = true;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau4()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = true;
            Imgcau6.Visible = false;
        }
        private void DongButton5()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = true;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau5()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = true;
        }
        private void DongButton6()
        {
            Imbtcau1.Visible = false;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = false;
            Imcau4.Visible = false;
            Imgcau5.Visible = true;
            Imgcau6.Visible = false;
        }

        private void MoButtonCau6()
        {
            Imbtcau1.Visible = true;
            ImageBtcau2.Visible = false;
            ImgBTcau3.Visible = true;
            Imcau4.Visible = false;
            Imgcau5.Visible = false;
            Imgcau6.Visible = false;
        }
        #endregion
    }
}