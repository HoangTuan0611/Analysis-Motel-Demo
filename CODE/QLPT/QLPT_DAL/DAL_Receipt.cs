using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPT_Entity;
namespace QLPT_DAL
{
    public class DAL_Receipt
    {
        ConnectDB cn = new ConnectDB();
        public DataTable GetRoomID(string DieuKien)
        {
            //return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
            return cn.GetDataTable("Select mathue from thuephong" + DieuKien);
        }
        public string getvalue(string DieuKien1, string DieuKien2)
        {
            //return cn.GetValue("Select " + DieuKien1 + " from phongtro where mapt = " + DieuKien2);
            return cn.GetValue("Select " + DieuKien1 + " from thuephong where mathue = " + DieuKien2);
        }
        public DataTable CreateTable(string DieuKien)
        {
            return cn.GetDataTable("Select mathue from thuephong " + DieuKien);
        }
        public string check()
        {
            return cn.GetValue("Select COUNT(*) from thamso");
        }
        public string getvalue2(string DieuKien1, string DieuKien2)
        {
            return cn.GetValue("Select " + DieuKien1 + " from thamso where id = " + DieuKien2);
        }
        public string countCustomer(string DieuKien)
        {
            return cn.GetValue("Select COUNT(*) from khachtro where mapt = " + DieuKien);
        }
        public string check2(string DieuKien1,string DieuKien2,string DieuKien3)
        {
            return cn.GetValue("Select COUNT(*) from thutien where mapt='" + DieuKien1 + "' and MONTH(ngaythu)='" + DieuKien2 + "' and YEAR(ngaythu)='" + DieuKien3 + "'");
        }
        public void AddData(E_Receipt et)
        {
            cn.ExcuteQuery(@"INSERT INTO thutien (mapt, tiendien, tiennuoc, tienmang, tienxe, tienphong, ngaythu, tongtien) VALUES  ('" + et.roomID + "',N'" + et.elec + "',N'" + et.water + "',N'" + et.internet + "',N'" + et.parking + "',N'" + et.roomCharge + "',N'" + et.receiptDate + "',N'" + et.total + "')");
        }
    }
}
