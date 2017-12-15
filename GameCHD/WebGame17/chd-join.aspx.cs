using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChDGame
{
    public partial class chd_join : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                if (Session["TrangThai"].Equals("notlogin"))
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    if (Session["TrangThai"].ToString() == "Nor")
                    {
                        if (!IsPostBack)
                        {
                            ViewRoom();
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
            
        private void ViewRoom()
        {
            Rptkhoi10.DataSource = TblRoom_BLL.SelectRoomPhan();
            Rptkhoi10.DataBind();
            rptkhoi11.DataSource = TblRoom_BLL.SelectRoomPhan();
            rptkhoi11.DataBind();
            RptPhan.DataSource = TblRoom_BLL.SelectRoomPhan();
            RptPhan.DataBind();
           
        }
        protected void RptRoom_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //try
            //{
                if (e.CommandName == "Join")
                {
                    HiddenField NumNote = e.Item.FindControl("HdNote") as HiddenField;
                    HiddenField HdFAcc1 = e.Item.FindControl("HdfAcc1") as HiddenField;
                    //Kiểm tra số lượng người trong phòng
                    if (NumNote.Value == "0")
                    {
                        DataTable dtAcc = new DataTable();
                        dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                        string iDRoom = dtAcc.Rows[0][17].ToString();
                        string IDAc = dtAcc.Rows[0][0].ToString();
                        //Nếu rỗng hoặc chưa có giá trị tức là chưa vào phòng nào => cho phép vào phòng
                        if (iDRoom == "0" || string.IsNullOrEmpty(iDRoom))
                        {
                            foreach (RepeaterItem items in RptPhan.Items)
                            {
                                Label lbname = (Label)items.FindControl("lblnamePhan");
                                HiddenField hdIID = (HiddenField)items.FindControl("hdfIDphan");
                                //Kiểm tra xem Id phòng của tài khoản có đang tồn tại không 
                                //1.Update Phòng.
                                TblRoom_BLL.UPDATE_Chuong_Note(Convert.ToInt32(e.CommandArgument.ToString().Trim()), int.Parse(hdIID.Value), 1);
                                //2.Update Acc đang ở chương của phần nào
                                TblRoom_BLL.UPDATE_chuongAcc(int.Parse(IDAc), Convert.ToInt32(e.CommandArgument.ToString().Trim()));
                                //3.Update Acc tên acc phòng đó để hiện cho người khác xem thằng nào ở trong phòng =)) 
                                TblRoom_BLL.UPDATE_Chuong_NameAcc1(Convert.ToInt32(e.CommandArgument.ToString().Trim()), int.Parse(hdIID.Value), Session["Username"].ToString());
                                //Chuyển qua trang hiện câu hỏi kèm ID chương và phần
                                Response.Redirect("war-nor.aspx?id=" + e.CommandArgument + "&idf=" + hdIID.Value);
                            }
                        }
                        else
                        {
                            if (iDRoom == e.CommandArgument.ToString().Trim())
                            {
                                foreach (RepeaterItem items in RptPhan.Items)
                                {
                                    Repeater RpTChuong = (Repeater)items.FindControl("RptRoom");
                                    foreach (RepeaterItem itE in RpTChuong.Items)
                                    {
                                        HiddenField HDF = (HiddenField)itE.FindControl("HfIDPhan");
                                        Response.Redirect("war-nor.aspx?id=" + e.CommandArgument + "&idf=" + HDF.Value);
                                    }
                                }
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                lbltbao.Text = "Bạn đang tham gia chương " + iDRoom;
                            }
                        }
                    }
                    else
                    {
                        DataTable dtAcc = new DataTable();
                        dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                        string iDRoom = dtAcc.Rows[0][17].ToString();
                        if (NumNote.Value == "1")
                        {
                            if (iDRoom == e.CommandArgument.ToString().Trim())
                            {
                                foreach (RepeaterItem items in RptPhan.Items)
                                {
                                    Repeater RpTChuong = (Repeater)items.FindControl("RptRoom");
                                    foreach (RepeaterItem itE in RpTChuong.Items)
                                    {
                                        HiddenField HDF = (HiddenField)itE.FindControl("HfIDPhan");
                                        Response.Redirect("war-nor.aspx?id=" + e.CommandArgument + "&idf=" + HDF.Value);
                                    }
                                }
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                                lbltbao.Text = "Phòng đang thi đấu,vui lòng chọn phòng khác";
                            }
                        }
                    }
                }
            //}
            //catch (Exception)
            //{

            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            //    lbltbao.Text = "Chờ chút";
            //}
        }

        protected void RptPhan_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //try
            //{
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater childRepeater = (Repeater)e.Item.FindControl("RptRoom");
                HiddenField HDfPhan = (HiddenField)e.Item.FindControl("hdfIDphan");
                childRepeater.DataSource = TblRoom_BLL.SelectChuong(int.Parse(HDfPhan.Value));
                childRepeater.DataBind();
                foreach (RepeaterItem item in childRepeater.Items)
                {
                    Button bt = (Button)item.FindControl("btnJoin");
                    HiddenField HDNote = (HiddenField)item.FindControl("HdNote");
                    HiddenField HDAcc1 = (HiddenField)item.FindControl("HdfAcc1");
                     Label lbnameRm = (Label)item.FindControl("lblnameroom");
                    //Trường hợp người chơi đang thi đấu
                    if (HDNote.Value == "1")
                    {
                        bt.Attributes.Add("title", "Người chơi: " + HDAcc1.Value + "");
                        bt.BackColor = Color.White;
                        lbnameRm.Text = "Đang chiến";
                    }
                    else
                    {
                        //Trường hơp người chơi đang ở phòng chờ đối thủ hoặc phòng đang trống
                        if (HDNote.Value == "0")
                        {
                            bt.Attributes.Add("title", "Người chơi : " + HDAcc1.Value + "");
                        }
                    }
                }
            }
            //}
            //catch (Exception)
            //{

            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            //    lbltbao.Text = "Chờ chút ";
            //}
        }
    }
}