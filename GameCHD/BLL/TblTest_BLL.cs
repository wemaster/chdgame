using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL;
using System.Data;
namespace BLL
{
    public class TblTest_BLL
    {
        public static readonly TblTest_DAL TbTest = new TblTest_DAL();
        public static DataTable ViewTestID(int IDSub, int IDTT, int IDTest)
        {
            return TbTest.ViewTestID(IDSub, IDTT, IDTest);
        }
        public static int INSERT(int IdSub, string Content, string TestA, string TestB, string TestC, string TestD, string TestCorect, string TimeTest,int IDTT, int Phan, int chuong)
        {
            return TbTest.INSERT(IdSub, Content, TestA, TestB, TestC, TestD, TestCorect, TimeTest,IDTT, Phan, chuong);
        }
        public static int UPDATE(int IDTest, int IdSub, string Content, string TestA, string TestB, string TestC, string TestD, string TestCorect, string TimeTest)
        {
            return TbTest.UPDATE(IDTest, IdSub, Content, TestA, TestB, TestC, TestD, TestCorect, TimeTest);
        }
        public static DataTable ViewTest_update()
        {
            return TbTest.ViewTest_update();
        }
        public static DataTable ViewTestIDTT(int IDTT)
        {
            return TbTest.ViewTestIDTT(IDTT);
        }
    }
}
