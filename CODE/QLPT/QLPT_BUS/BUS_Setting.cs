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
    public class BUS_Setting
    {
        DAL_Setting sql = new DAL_Setting();
        public void UpdateData(E_Setting et)
        {
            sql.UpdateData(et);
        }
        public string check()
        {
            return sql.check();
        }
        public void AddData(E_Setting et)
        {
            sql.AddData(et);
        }
        public string getvalue(string Condition1,string Condition2)
        {
            return sql.getvalue(Condition1, Condition2);
        }
    }
}
