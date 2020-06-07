using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;

namespace QLPT_DAL
{
    public class DAL_Room
    {
        ConnectDB cn = new ConnectDB();

        
        // Thêm Dữ Liệu
        public void AddData(E_Room et)
        {
            cn.ExcuteQuery(@"INSERT INTO phongtro (mapt, tang, tenphong, loai, sltoida, trangthai) VALUES  ('" + et.roomID + "',N'" + et.floor + "',N'" + et.roomName + "',N'" + et.type + "',N'" + et.maxCus + "',N'" + et.status + "')");
        }
        //Sửa
        public void UpdateData(E_Room et)
        {
            cn.ExcuteQuery(@"UPDATE phongtro SET tang = N'" + et.floor + "', tenphong =N'" + et.roomName + "', loai ='" + et.type + "', sltoida ='" + et.maxCus + "', trangthai ='" + et.status + "' Where mapt='" + et.roomID + "'");
        }
        //Xoá
        public void DeleteData(E_Room et)
        {

            cn.ExcuteQuery(@"DELETE FROM phongtro  Where mapt='" + et.roomID + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string Condition)
        {
            return cn.GetDataTable("Select * from phongtro" + Condition);
        }
        public DataTable GetFloorInfo(string Condition)
        {
            return cn.GetDataTable("Select tang from tangphong " + Condition);
        }
        public DataTable GetTypeRoomInfo(string Condition)
        {
            return cn.GetDataTable("Select loai from loaiphong " + Condition);
        }
    }
}
