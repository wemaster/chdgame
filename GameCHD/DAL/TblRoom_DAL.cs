using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class TblRoom_DAL : DAL_Con
    {
        public DataTable SelectRoom()
        {
            SqlCommand cmd = new SqlCommand("TblRoom_SelectRoom", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SelectChuong(int IDPhan)
        {
            SqlCommand cmd = new SqlCommand("TblChuong_select", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDPhan", IDPhan);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UPDATE(int IDAcc, int IDRoom)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_Update_Room", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@IDRoom", IDRoom);
            return cmd.ExecuteNonQuery();
        }
        public int UPDATE_chuongAcc(int IDAcc, int IDChuong)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UpdateChuong", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@IDChuong", IDChuong);
            return cmd.ExecuteNonQuery();
        }
        public int UPDATE_NameAcc1(int IDRoom,int Note, string NameAcc)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Room_UpdateNameAcc1", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDRoom", IDRoom);
            cmd.Parameters.AddWithValue("@Note", Note);
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            return cmd.ExecuteNonQuery();
        }
        public int UPDATE_NameAcc2(int IDRoom,int Note, string NameAcc)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Room_UpdateNameAcc2", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDRoom", IDRoom);
            cmd.Parameters.AddWithValue("@Note", Note);
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            return cmd.ExecuteNonQuery();
        }
        //RoomChuong Phan 
        public DataTable SelectRoomPhan()
        {
            SqlCommand cmd = new SqlCommand("TblPhan_Select", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UPDATE_Chuong_Note(int IDChuong,int IDPhan ,int Note)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Chuong_UpdateNote", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDChuong", IDChuong);
            cmd.Parameters.AddWithValue("@IDPhan", IDPhan);
            cmd.Parameters.AddWithValue("@Note", Note);
            return cmd.ExecuteNonQuery();
        }
        public int UPDATE_Chuong_NameAcc1(int IDChuong,int IDPhan,string NameAcc)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Chuong_UpdateACC", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDChuong", IDChuong);
            cmd.Parameters.AddWithValue("@IDPhan", IDPhan);
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            return cmd.ExecuteNonQuery();
        }
        public DataTable SelectRoom_ID(int IDRoom)
        {
            SqlCommand cmd = new SqlCommand("tblRoom_select_id", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDRoom);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int insert_RoomWWar_NameAcc(int IDPhong, int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("TblWar_InsertAcc", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDPhong);
            cmd.Parameters.AddWithValue("@IDAcc1", IDAcc);
            return cmd.ExecuteNonQuery();
        }
        public int Update_RoomWWar_NameAcc(int IDPhong, int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("TblWar_updateAcc", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDPhong);
            cmd.Parameters.AddWithValue("@IDAcc2", IDAcc);
            return cmd.ExecuteNonQuery();
        }
        public DataTable SelectWarRoom(int IDPhong)
        {
            SqlCommand cmd = new SqlCommand("TblWarRoom_SelectIDPhong", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDPhong);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Delete_warRoomID(int IDRoom)
        {
            SqlCommand cmd = new SqlCommand("TblWarRoom_RemoveID", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDWar",IDRoom);
            return cmd.ExecuteNonQuery();
        }
        public int Insert_traloi(string NameResult, int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("TblTraLoi_Insert", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@NameResult", NameResult);
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            return cmd.ExecuteNonQuery();
        }
        public int Update_traloiAcc1(int IDRoom, int NumTrue)
        {
            SqlCommand cmd = new SqlCommand("TblRoom_UpDateTrue_Acc1", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDRoom);
            cmd.Parameters.AddWithValue("@NumTrue", NumTrue);
            return cmd.ExecuteNonQuery();
        }
        public int Update_traloiAcc2(int IDRoom, int NumTrue)
        {
            SqlCommand cmd = new SqlCommand("TblRoom_UpDateTrue_Acc2", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDRoom);
            cmd.Parameters.AddWithValue("@NumTrue", NumTrue);
            return cmd.ExecuteNonQuery();
        }
        public DataTable SelectTraLoi(int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("Tbl_TraLoi_Select ", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDACC", IDAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int deleteAL_TblwarRoom(int IDPhong)
        {
            SqlCommand cmd = new SqlCommand("tblwarroom_deleteall", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDPhong", IDPhong);
            return cmd.ExecuteNonQuery();
        }
        public int deleteAL_TblTraLoi(int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("TblTraLoi_deleteall", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            return cmd.ExecuteNonQuery();
        }
    }
}
