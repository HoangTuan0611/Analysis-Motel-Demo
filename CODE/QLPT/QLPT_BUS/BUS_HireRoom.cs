using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using QLPT_Entity;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_HireRoom
    {
        DAL_HireRoom sql = new DAL_HireRoom();

        // Thêm Dữ Liệu
        public void AddData(E_HireRoom et)
        {
            sql.AddData(et);
        }
        public DataTable CreateTable(string Condition)
        {
            return sql.CreateTable(Condition);
        }
        public DataTable GetRoomID(string Condition)
        {
            return sql.GetRoomID(Condition);
        }
        public DataTable GetCustomerID(string Condition)
        {
            return sql.GetCustomerID(Condition);
        }
        public string countcustomer(string DieuKien)
        {
            return sql.countcustomer(DieuKien);
        }
        public string maxslot(string DieuKien)
        {
            return sql.maxslot(DieuKien);
        }
        public void updatestatusroom_1(string DieuKien)
        {
            sql.updatestatusroom_1(DieuKien);
        }
    }
}
