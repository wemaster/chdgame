using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL;
namespace BLL
{
    public class TblDetailWar_BLL
    {
        public static readonly Tbl_DetailWar_DAL TbDetail = new Tbl_DetailWar_DAL();
        public int Insert(string IDAcc1, string Acc2, DateTime DayWar, int IDResult, int IDTT)
        {
            return TbDetail.Insert(IDAcc1, Acc2, DayWar, IDResult, IDTT);
        }
    }
}
