using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Setting
    {
        private string _tienphongnho;
        private string _tienphonglon;
        private string _tiendien;
        private string _tiennuoc;
        private string _tienxe;
        private string _tienmang;
        private string _tienrac;
        private string _giamtienlenphong;

        public string smallroomCharge
        {
            get
            {
                return _tienphongnho;
            }

            set
            {
                _tienphongnho = value;
            }
        }

        public string bigroomCharge
        {
            get
            {
                return _tienphonglon;
            }

            set
            {
                _tienphonglon = value;
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
        public string garbage
        {
            get
            {
                return _tienrac;
            }

            set
            {
                _tienrac = value;
            }
        }
        public string discount
        {
            get
            {
                return _giamtienlenphong;
            }

            set
            {
                _giamtienlenphong = value;
            }
        }

    }
}

    

