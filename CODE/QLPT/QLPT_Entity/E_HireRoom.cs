using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_HireRoom
    {
        private string _mathue;
        private string _makt;
        private string _mapt;
        private DateTime _ngaybd;
        private DateTime _ngaykt;
    

        public string ConID
        {
            get
            {
                return _mathue;
            }

            set
            {
                _mathue = value;
            }
        }

        public string CusID
        {
            get
            {
                return _makt;
            }

            set
            {
                _makt = value;
            }
        }

        public string RoomID
        {
            get
            {
                return _mapt;
            }

            set
            {
                _mapt = value;
            }
        }

        public DateTime Dateto
        {
            get
            {
                return _ngaykt;
            }

            set
            {
                _ngaykt = value;
            }
        }
        public DateTime Datefrom
        {
            get
            {
                return _ngaybd;
            }

            set
            {
                _ngaybd = value;
            }
        }
    }
}
