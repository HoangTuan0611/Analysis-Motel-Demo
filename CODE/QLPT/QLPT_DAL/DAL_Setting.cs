using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPT_Entity;
using System.Data;

namespace QLPT_DAL
{
    public class DAL_Setting
    {
        ConnectDB cn = new ConnectDB();
        public void UpdateData(E_Setting et)
        {
            cn.ExcuteQuery(@"UPDATE thamso SET tienphongnho =N'" + et.smallroomCharge + "', tienphonglon =N'" + et.bigroomCharge + "', tiendien =N'" + et.elec + "', tiennuoc =N'" + et.water + "', tienxe =N'" + et.parking + "', tienmang =N'" + et.internet + "', tienrac=N'" + et.garbage +"', giamtienlenphong=N'" +et.discount +"'");
        }
        public string check()
        {
            return cn.GetValue("Select COUNT(*) from thamso");
        }
        public void AddData(E_Setting et)
        {
            cn.ExcuteQuery(@"INSERT INTO thamso (tienphongnho, tienphonglon, tiendien, tiennuoc, tienxe, tienmang, tienrac, giamtienlenphong) VALUES  ('" + et.smallroomCharge + "',N'" + et.bigroomCharge + "',N'" + et.elec + "',N'" + et.water + "',N'" + et.parking + "',N'" + et.internet + "',N'" + et.garbage + "',N'" + et.discount +"')");
        }
        public string getvalue(string Condition1, string Condition2)
        {
            return cn.GetValue("Select " + Condition1 + " from thamso where id = " + Condition2);
        }
    }
}
