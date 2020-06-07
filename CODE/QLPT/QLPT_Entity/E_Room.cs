using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Room
    {
        
        private string _roomID;
        private string _roomName;
        private string _floor;
        private string _type;
        private string _maxCus;
        private string _status;
       



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

        public string roomName
        {
            get
            {
                return _roomName;
            }

            set
            {
                _roomName = value;
            }
        }

        public string floor
        {
            get
            {
                return _floor;
            }

            set
            {
                _floor = value;
            }
        }

        public string type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        public string maxCus
        {
            get
            {
                return _maxCus;
            }

            set
            {
                _maxCus = value;
            }
        }
        public string status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
     

    }
}

