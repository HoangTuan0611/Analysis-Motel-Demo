using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_Checkout
    {
        DAL_Checkout sql = new DAL_Checkout();
        public DataTable CreateTable(string Condition)
        {
            return sql.CreateTable(Condition);
        }
        public DataTable GetIDHireRoomInfo(string Condition)
        {
            return sql.GetHireRoomIDInfo(Condition);
        }
        public void UpdateRoomStatus(string Condition)
        {
            sql.UpdateRoomStatus(Condition);
        }
        public string getvalue(string Condition1, string Condition2)
        {
            return sql.getvalue(Condition1, Condition2);
        }
        public void Delete(string Condition)
        {
            sql.Delete(Condition);
        }
    }
}
