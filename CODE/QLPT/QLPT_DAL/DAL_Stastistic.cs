using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLPT_Entity;
namespace QLPT_DAL
{
    public class DAL_Stastistic
    {
        ConnectDB cn = new ConnectDB();
        public DataTable TaoBang(string DieuKien1, string DieuKien2)
        {
            return cn.GetDataTable("Select * from thutien where MONTH(ngaythu)='" + DieuKien1 + "' and YEAR(ngaythu)='" + DieuKien2 + "'");
        }

    }
}
