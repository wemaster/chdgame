using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL;
using System.Data;
namespace BLL
{
    public class TbLClass_BLL
    {
        public static readonly TblClass_DAL TbClass = new TblClass_DAL();
        public static DataTable ViewClass()
        {
            return TbClass.ViewCL();
        }
    }
}
