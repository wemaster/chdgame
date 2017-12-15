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
    public partial class join_room : System.Web.UI.Page
    {
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
                    if (!IsPostBack)
                    {
                        ViewRoom();
                    }
                }
            }
        }
        /// <summary>
        /// Hiển thị các phòng để chọn
        /// </summary>
        private void ViewRoom()
        {
            RptRoom.DataSource = TblRoom_BLL.ViewRoom();
            RptRoom.DataBind();
            Rpt11.DataSource = TblRoom_BLL.ViewRoom();
            Rpt11.DataBind();
            Rpt12.DataSource = TblRoom_BLL.ViewRoom();
            Rpt12.DataBind();
            foreach (RepeaterItem items in RptRoom.Items)
            {
                Button bt = (Button)items.FindControl("btnJoin");
                HiddenField hf = (HiddenField)items.FindControl("HdFID");
                HiddenField hfAcc1 = (HiddenField)items.FindControl("HdfAcc1");
                HiddenField hfAcc2 = (HiddenField)items.FindControl("HdfAcc2");
                Label lbnameRm = (Label)items.FindControl("lblnameroom");
                //Trường hợp người chơi đang thi đấu
                if (hf.Value == "2")
                {
                    bt.Attributes.Add("title", "Người chơi: " + hfAcc1.Value + "," + hfAcc2.Value + "");
                    bt.BackColor = Color.White;
                    lbnameRm.Text = "Đang chiến";
                }
                else
                {
                    //Trường hơp người chơi đang ở phòng chờ đối thủ hoặc phòng đang trống
                    if(hf.Value=="0"|| hf.Value=="1")
                    {
                        bt.Attributes.Add("title","Người chơi : "+hfAcc1.Value+","+hfAcc2.Value+"");

                    }
                }

            }
        }
        /// <summary>
        /// Khi chọn phòng sẽ kiểm tra người chơi trong tinh trạng nào?
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void RptRoom_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Join")
            {
                HiddenField NumNote = e.Item.FindControl("HdFID") as HiddenField;
                HiddenField HdFAcc1 = e.Item.FindControl("HdfAcc1") as HiddenField;
                //Kiểm tra số lượng người trong phòng
                if (NumNote.Value == "0" || NumNote.Value == "1")
                {
                    //Kiểm tra xem Id phòng của tài khoản có đang tồn tại không 
                    DataTable dtAcc = new DataTable();
                    dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                    string iDRoom = dtAcc.Rows[0][16].ToString();
                    string NameAcc = dtAcc.Rows[0][1].ToString();
                    //Nếu rỗng hoặc chưa có giá trị tức là chưa vào phòng nào => cho phép vào phòng
                    if (string.IsNullOrEmpty(iDRoom) || iDRoom == "0")
                    {
                        TblRoom_BLL.UPDATE(int.Parse(Session["IDAcc"].ToString()), Convert.ToInt32(e.CommandArgument.ToString().Trim()));
                        if (string.IsNullOrEmpty(HdFAcc1.Value))
                        {
                            TblRoom_BLL.insert_RoomWWar_NameAcc(Convert.ToInt32(e.CommandArgument.ToString().Trim()),int.Parse(Session["IDAcc"].ToString()));
                            TblRoom_BLL.UPDATE_NameAcc1(Convert.ToInt32(e.CommandArgument.ToString().Trim()),1, NameAcc);
                            Response.Redirect("war-room.aspx?id=" + e.CommandArgument);
                        }
                        else
                        {
                            TblRoom_BLL.UPDATE_NameAcc2(Convert.ToInt32(e.CommandArgument.ToString().Trim()), 2,NameAcc);
                            Response.Redirect("war-room.aspx?id=" + e.CommandArgument);
                        }
                    }
                    else
                    {
                        if (iDRoom == e.CommandArgument.ToString().Trim())
                        {
                            Response.Redirect("war-room.aspx?id=" + e.CommandArgument);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            lbltbao.Text = "Bạn đang tham gia phòng " + iDRoom + ".";
                        }
                    }
                }
                else
                {
                    DataTable dtAcc = new DataTable();
                    dtAcc = TblAcc_BLL.ViewAccID(int.Parse(Session["IDAcc"].ToString()));
                    string iDRoom = dtAcc.Rows[0][16].ToString();  
                    if (NumNote.Value == "2")
                    {
                        if (iDRoom == e.CommandArgument.ToString().Trim())
                        {
                            Response.Redirect("war-room.aspx?id=" + e.CommandArgument);
                        }
                        else
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                            lbltbao.Text = "Phòng đang thi đấu,vui lòng chọn phòng khác";
                        }
                    }
                }
            }
        }
    }
}