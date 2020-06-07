using QLPT_DAL;
using QLPT_Entity;
using System.Data;

namespace QLPT_BUS
{
    public class BUS_Room
    {
        DAL_Room sql = new DAL_Room();

        // Thêm Dữ Liệu
        public void AddData(E_Room et)
        {
            sql.AddData(et);
        }
        //Sửa
        public void UpdateData(E_Room et)
        {
            sql.UpdateData(et);
        }
        //Xoá
        public void DeleteData(E_Room et)
        {
            sql.DeleteData(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable GetFloorInfo(string DieuKien)
        {
            return sql.GetFloorInfo(DieuKien);
        }
        public DataTable GetTypeRoomInfo(string DieuKien)
        {
            return sql.GetTypeRoomInfo(DieuKien);
        }

    }
}
