using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Setting
    {
        private string _smallroomCharge;
        private string _bigroomCharge;
        private string _elec;
        private string _water;
        private string _parking;
        private string _internet;
        private string _garbage;
        private string _discount;

        public string smallroomCharge
        {
            get
            {
                return _smallroomCharge;
            }

            set
            {
                _smallroomCharge = value;
            }
        }

        public string bigroomCharge
        {
            get
            {
                return _bigroomCharge;
            }

            set
            {
                _bigroomCharge = value;
            }
        }

        public string elec
        {
            get
            {
                return _elec;
            }

            set
            {
                _elec = value;
            }
        }

        public string water
        {
            get
            {
                return _water;
            }

            set
            {
                _water = value;
            }
        }

        public string parking
        {
            get
            {
                return _parking;
            }

            set
            {
                _parking = value;
            }
        }
        public string internet
        {
            get
            {
                return _internet;
            }

            set
            {
                _internet = value;
            }
        }
        public string garbage
        {
            get
            {
                return _garbage;
            }

            set
            {
                _garbage = value;
            }
        }
        public string discount
        {
            get
            {
                return _discount;
            }

            set
            {
                _discount = value;
            }
        }

    }
}

    

