using DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class TblRoom_BLL
    {
        public static readonly TblRoom_DAL TbRoom = new TblRoom_DAL();
        public static DataTable ViewRoom()
        {
            return TbRoom.SelectRoom();
        }
        public static int UPDATE(int IDAcc, int IDRoom)
        {
            return TbRoom.UPDATE(IDAcc, IDRoom);
        }
        public static int UPDATE_NameAcc1(int IDRoom, int Note, string NameAcc)
        {
            return TbRoom.UPDATE_NameAcc1(IDRoom,Note, NameAcc);
        }
        public static int UPDATE_NameAcc2(int IDRoom, int Note, string NameAcc)
        {
            return TbRoom.UPDATE_NameAcc2(IDRoom,Note, NameAcc);
        }
        public static DataTable SelectRoomPhan()
        {
            return TbRoom.SelectRoomPhan();
        }
        public static int UPDATE_Chuong_NameAcc1(int IDChuong,int IDPhan,string NameAcc)
        {
            return TbRoom.UPDATE_Chuong_NameAcc1(IDChuong,IDPhan, NameAcc);
        }
        public static int UPDATE_Chuong_Note(int IDChuong,int IDPhan,int Note)
        {
            return TbRoom.UPDATE_Chuong_Note(IDChuong,IDPhan,Note);
        }
        public static int UPDATE_chuongAcc(int IDAcc, int IDChuong)
        {
            return TbRoom.UPDATE_chuongAcc(IDAcc, IDChuong);
        }
        public static DataTable  SelectChuong(int IDPhan)
        {
            return TbRoom.SelectChuong(IDPhan);
        }
        public static DataTable SelectRoom_ID(int IDRoom)
        {
            return TbRoom.SelectRoom_ID(IDRoom);
        }
        public static int insert_RoomWWar_NameAcc(int IDPhong, int IDAcc)
        {
            return TbRoom.insert_RoomWWar_NameAcc(IDPhong, IDAcc);
        }
        public static int Update_RoomWWar_NameAcc(int IDPhong, int IDAcc)
        {
            return TbRoom.Update_RoomWWar_NameAcc(IDPhong, IDAcc);
        }
        public static  DataTable SelectWarRoom(int IDPhong)
        {
            return TbRoom.SelectWarRoom(IDPhong);
        }
        public int Delete_warRoomID(int IDRoom)
        {
            return TbRoom.Delete_warRoomID(IDRoom);
        }
        public static int Insert_traloi(string NameResult, int IDAcc)
        {
            return TbRoom.Insert_traloi(NameResult, IDAcc);
        }
        public static int Update_traloiAcc1(int IDRoom, int NumTrue)
        {
            return TbRoom.Update_traloiAcc1(IDRoom,NumTrue);
        }
        public static int Update_traloiAcc2(int IDRoom, int NumTrue)
        {
            return TbRoom.Update_traloiAcc2(IDRoom, NumTrue);
        }
        public static DataTable SelectTraLoi(int IDAcc)
        {
            return TbRoom.SelectTraLoi(IDAcc);
        }
        public static int deleteAL_TblwarRoom(int IDPhong)
        {
            return TbRoom.deleteAL_TblwarRoom(IDPhong);
        }
        public static int deleteAL_TblTraLoi(int IDAcc)
        {
            return TbRoom.deleteAL_TblTraLoi(IDAcc);
        }
    }
}
