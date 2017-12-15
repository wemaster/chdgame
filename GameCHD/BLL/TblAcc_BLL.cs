using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL;
using System.Data;
namespace BLL
{
    public class TblAcc_BLL
    {
        public static readonly TblAcc_DAL TbACC = new TblAcc_DAL();
        public static DataTable ViewAccID(int IDAcc)
        {
            return TbACC.ViewAccID(IDAcc);
        }
        public static DataTable ViewAcc2(int IDTT, int IDSubjects)
        {
            return TbACC.ViewAcc2(IDTT, IDSubjects);
        }
        public static DataTable ViewBoss()
        {
            return TbACC.ViewAccBoss();
        }
        public static DataTable CheckLogin(string NameAcc, string PassAcc)
        {
            return TbACC.CheckLogin(NameAcc, PassAcc);
        }
        public static DataTable ViewIDClass(int IDClass, int IDAcc)
        {
            return TbACC.ViewIDClass(IDClass,IDAcc);
        }
        public static int UpdateExpPoint(int IDAcc,double Exp, double Point)
        {
            return TbACC.UpdateExpPoint(IDAcc, Exp, Point);
        }
        public static int UpdateLevel(int IDAcc, int Level)
        {
            return TbACC.UpdateLevel(IDAcc, Level);
        }
        public static int UpdateNumWin(int IDAcc, int NumWin)
        {
            return TbACC.UpdateNumWin(IDAcc, NumWin);
        }
        public static int UpdateNumLose(int IDAcc, int NumLose)
        {
            return TbACC.UpdateNumLose(IDAcc, NumLose);
        }
        public int UpdateNumRank(int IDAcc, int NumRank)
        {
            return TbACC.UpdateNumRank(IDAcc, NumRank);
        }
        /// <summary>
        /// hiển thị câu test
        /// </summary>
        /// <param name="IDAcc"></param>
        /// <returns></returns>
        public static DataTable SelectCauTest(int IDAcc)
        {
            return TbACC.SelectCauTest(IDAcc);
        }
        public static DataTable SelectAccViewMem()
        {
            return TbACC.SelectAccViewMem();
        }
        public static DataTable ViewAccName(string NameAcc)
        {
            return TbACC.ViewAccName(NameAcc);
        }
        /// <summary>
        /// Reg tài khoản
        /// </summary>
        /// <param name="NameAcc"></param>
        /// <param name="Pwd"></param>
        /// <param name="email"></param>
        /// <param name="dateReg"></param>
        /// <returns></returns>
        public static int RegTaiKhoan(string NameAcc, string Pwd, string email, string dateReg)
        {
            return TbACC.RegTaiKhoan(NameAcc, Pwd, email, dateReg);
        }
        public static int UpdateClass(int IDAcc, int IDClass)
        {
            return TbACC.UpdateClass(IDAcc, IDClass);
        }
    }
}
