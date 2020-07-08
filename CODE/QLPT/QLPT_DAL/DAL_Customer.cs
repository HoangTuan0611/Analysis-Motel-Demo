
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;

namespace QLPT_DAL
{
    public class DAL_Customer
    {
        ConnectDB cn = new ConnectDB();

        // Thêm Dữ Liệu
        public void AddData(E_Customer et)
        {
            cn.ExcuteQuery(@"INSERT INTO khachtro (makt, hoten, cmnd, gioitinh, nghenghiep, sdt) VALUES  ('" + et.cusID + "',N'" + et.cusName + "',N'" + et.cusIdenCard + "',N'" + et.cusSex + "',N'" + et.cusJob + "',N'" + et.PhoneNo + "')");
        }
        //Sửa
        public void UpdateData(E_Customer et)
        {
            cn.ExcuteQuery(@"UPDATE khachtro SET hoten =N'" + et.cusName + "', cmnd ='" + et.cusIdenCard + "', gioitinh ='" + et.cusSex + "', nghenghiep ='" + et.cusJob + "', sdt ='" + et.PhoneNo + "' Where makt='" + et.cusID + "'");
        }
        //Xoá
        public void DeleteData(E_Customer et)
        {

            cn.ExcuteQuery(@"DELETE FROM khachtro  Where makt='" + et.cusID + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable CreateTable(string DieuKien)
        {
            return cn.GetDataTable("Select * from khachtro " + DieuKien);
        }
        public DataTable GetRoomID(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
        }
        public void UpdateRoomStatus(string DieuKien)
        {
            cn.ExcuteQuery("UPDATE phongtro SET trangthai ='Đang cho thuê' where mapt = " + DieuKien);
        }
        public void UpdateRoomStatus2(string DieuKien)
        {
            cn.ExcuteQuery("UPDATE phongtro SET trangthai ='Trống' where mapt = " + DieuKien);
        }
        public string countcustomer(string DieuKien)
        {
           return cn.GetValue("Select COUNT(*) from khachtro where mapt = " + DieuKien);
        }
        public string maxcustomer(string DieuKien)
        {
           return cn.GetValue("Select sltoida from phongtro where mapt = " + DieuKien);
        }
    }
}
