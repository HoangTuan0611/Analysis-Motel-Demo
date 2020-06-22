using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPT_Entity
{
    public class E_Room
    {

        private string _mapt;
        private string _tenphong;
        private string _tang;
        private string _loai;
        private string _sltoida;
        private string _trangthai;





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

        public string roomName
        {
            get
            {
                return _tenphong;
            }

            set
            {
                _tenphong = value;
            }
        }

        public string floor
        {
            get
            {
                return _tang;
            }

            set
            {
                _tang = value;
            }
        }

        public string type
        {
            get
            {
                return _loai;
            }

            set
            {
                _loai = value;
            }
        }
        public string maxCus
        {
            get
            {
                return _sltoida;
            }

            set
            {
                _sltoida = value;
            }
        }
        public string status
        {
            get
            {
                return _trangthai;
            }

            set
            {
                _trangthai = value;
            }
        }
     

    }
}

