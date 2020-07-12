using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_DAL
{
    public class DAL_Checkout
    {
        ConnectDB cn = new ConnectDB();
        public DataTable CreateTable(string DieuKien)
        {
            return cn.GetDataTable("Select * from thuephong " + DieuKien);
            
        }
        public DataTable GetRoomIDInfo(string DieuKien)
        {
            return cn.GetDataTable("Select mapt from phongtro " + DieuKien);
            //return cn.GetDataTable("Select mathue from thuephong " + DieuKien);
        }
        public void UpdateRoomStatus(string DieuKien)
        {
            cn.ExcuteQuery("UPDATE phongtro SET trangthai ='empty' where mapt = " + DieuKien);
        }
        public string getvalue(string DieuKien1,string DieuKien2)
        {
            return cn.GetValue("Select "+ DieuKien1+" from phongtro where mapt = " + DieuKien2);
            //return cn.GetValue("Select " + DieuKien1 + " from thuephong where mathue = " + DieuKien2);
        }
        public void Delete(string DieuKien)
        {
            cn.ExcuteQuery("Delete from khachtro where mapt=" + DieuKien);
        }
    }
}
