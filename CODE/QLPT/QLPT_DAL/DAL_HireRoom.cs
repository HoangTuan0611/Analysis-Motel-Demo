using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;

namespace QLPT_DAL
{
    public class DAL_HireRoom
    {
        ConnectDB cn = new ConnectDB();
        // Thêm Dữ Liệu
        public void AddData(E_HireRoom et)
        {
            cn.ExcuteQuery(@"INSERT INTO thuephong (mathue, makt, mapt, ngaybd, ngaykt) VALUES  ('" + et.ConID + "',N'" + et.CusID + "',N'" + et.RoomID + "',N'" + et.Datefrom + "',N'" + et.Dateto + "')");
        }

        public DataTable CreateTable(string Condition)
        {
            return cn.GetDataTable("Select * from thuephong" + Condition);
        }
        public DataTable GetRoomID(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
        }
        public DataTable GetCustomerID(string DieuKien)
        {
            return cn.GetDataTable("Select makt from khachtro " + DieuKien);
        }
    }

}
