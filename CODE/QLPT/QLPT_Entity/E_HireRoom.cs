using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_HireRoom
    {
        private string _cusID;
        private string _roomID;
        private string _cusName;
        private string _cusIdenCard;
        private string _cusSex;
        private string _cusJob;
        private string _PhoneNo;

        public string cusID
        {
            get
            {
                return _cusID;
            }

            set
            {
                _cusID = value;
            }
        }

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

        public string cusName
        {
            get
            {
                return _cusName;
            }

            set
            {
                _cusName = value;
            }
        }

        public string cusIdenCard
        {
            get
            {
                return _cusIdenCard;
            }

            set
            {
                _cusIdenCard = value;
            }
        }

        public string cusSex
        {
            get
            {
                return _cusSex;
            }

            set
            {
                _cusSex = value;
            }
        }
        public string cusJob
        {
            get
            {
                return _cusJob;
            }

            set
            {
                _cusJob = value;
            }
        }
        public string PhoneNo
        {
            get
            {
                return _PhoneNo;
            }

            set
            {
                _PhoneNo = value;
            }
        }

    }
}
