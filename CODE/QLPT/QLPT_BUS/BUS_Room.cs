using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;
using QLPT_DAL;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_Room
    {
        DAL_Room sql = new DAL_Room();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_Room et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(E_Room et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(E_Room et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongtintang(string DieuKien)
        {
            return sql.LayThongtintang(DieuKien);
        }
        public DataTable LayThongtinloaiphong(string DieuKien)
        {
            return sql.LayThongtinloaiphong(DieuKien);
        }

    }
}
