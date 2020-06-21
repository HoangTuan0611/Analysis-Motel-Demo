using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_HireRoom
    {
        private string _makt;
        private string _mapt;
        private string _hoten;
        private string _cmnd;
        private string _gioitinh;
        private string _nghenghiep;
        private string _sdt;

        public string cusID
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

        public string roomID
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

        public string cusName
        {
            get
            {
                return _hoten;
            }

            set
            {
                _hoten = value;
            }
        }

        public string cusIdenCard
        {
            get
            {
                return _cmnd;
            }

            set
            {
                _cmnd = value;
            }
        }

        public string cusSex
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }
        public string cusJob
        {
            get
            {
                return _nghenghiep;
            }

            set
            {
                _nghenghiep = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }

    }
}
