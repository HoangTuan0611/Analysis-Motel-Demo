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
    public class BUS_Receipt
    {
        DAL_Receipt sql = new DAL_Receipt();
        public DataTable GetRoomID(string Condition)
        {
            return sql.GetRoomID(Condition);
        }
        public string getvalue(string Conditon1, string Condition2)
        {
            return sql.getvalue(Conditon1, Condition2);
        }
        public DataTable CreateTable(string condition)
        {
            return sql.CreateTable(condition);
        }
        public string check()
        {
            return sql.check();
        }
        public string getvalue2(string Condiotn1, string Conditon2)
        {
            return sql.getvalue2(Condiotn1, Conditon2);
        }
        public string countCustomer(string Conditon)
        {
            return sql.countCustomer(Conditon);
        }
        public string check2(string Condition1,string Condition2,string Condition3)
        {
            return sql.check2(Condition1, Condition2, Condition3);
        }
        public void AddData(E_Receipt et)
        {
            sql.AddData(et);
        }
    }
}
