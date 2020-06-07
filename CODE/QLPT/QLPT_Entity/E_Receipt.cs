using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Receipt
    {
        private string _roomID;
        private string _elec;
        private string _water;
        private string _internet;
        private string _parking;
        private string _roomCharge;
        private string _total;
        private DateTime _receiptDate;
        

        public string roomID
        {
            get
            {
                return _roomID;
            }

            set
            {
                _roomID = value;
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

        public string roomCharge
        {
            get
            {
                return _roomCharge;
            }

            set
            {
                _roomCharge = value;
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
        public string total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }
        public DateTime receiptDate
        {
            get
            {
                return _receiptDate;
            }
            set
            {
                _receiptDate = value;
            }
        }
    }
}
