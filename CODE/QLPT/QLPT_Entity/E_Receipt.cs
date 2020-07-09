using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Receipt
    {
        //private string _mapt;
        private string _mathue;
        private string _tiendien;
        private string _tiennuoc;
        private string _tienmang;
        private string _tienxe;
        private string _tienphong;
        private string _tongtien;
        private DateTime _ngaythu;


        //public string roomID
        //{
        //    get
        //    {
        //        return _mapt;
        //    }

        //    set
        //    {
        //        _mapt = value;
        //    }
        //}
        public string roomID
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

        public string elec
        {
            get
            {
                return _tiendien;
            }

            set
            {
                _tiendien = value;
            }
        }

        public string roomCharge
        {
            get
            {
                return _tienphong;
            }

            set
            {
                _tienphong = value;
            }
        }

        public string water
        {
            get
            {
                return _tiennuoc;
            }

            set
            {
                _tiennuoc = value;
            }
        }

        public string parking
        {
            get
            {
                return _tienxe;
            }

            set
            {
                _tienxe = value;
            }
        }
        public string internet
        {
            get
            {
                return _tienmang;
            }

            set
            {
                _tienmang = value;
            }
        }
        public string total
        {
            get
            {
                return _tongtien;
            }

            set
            {
                _tongtien = value;
            }
        }
        public DateTime receiptDate
        {
            get
            {
                return _ngaythu;
            }
            set
            {
                _ngaythu = value;
            }
        }
    }
}
