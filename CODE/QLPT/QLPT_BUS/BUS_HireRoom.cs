using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_DAL;
using QLPT_Entity;

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
        //Sửa
        public void UpdateData(E_HireRoom et)
        {
            sql.UpdateData(et);
        }
        //Xoá
        public void DeleteData(E_HireRoom et)
        {
            sql.DeleteData(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable CreateTable(string Condition)
        {
            return sql.CreateTable(Condition);
        }
        public DataTable GetRoomID(string Condition)
        {
            return sql.GetRoomID(Condition);
        }
        public void UpdateRoomStatus(string Condition)
        {
            sql.UpdateRoomStatus(Condition);
        }
        public void UpdateRoomStatus2(string DieuKien)
        {
            sql.UpdateRoomStatus2(DieuKien);
        }
        public string countcustomer(string DieuKien)
        {
            return sql.countcustomer(DieuKien);
        }
        public string maxcustomer(string DieuKien)
        {
            return sql.maxcustomer(DieuKien);
        }
    } 
}
