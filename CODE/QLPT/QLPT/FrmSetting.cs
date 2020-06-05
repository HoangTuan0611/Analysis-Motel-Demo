using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPT_BUS;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    public partial class FrmSetting : Form
    {
        int Kiemtra;
        BUS_Setting bus = new BUS_Setting();
        E_quidinh ec = new E_quidinh();
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ec.tienphongnho = txtBigRoom.Text;
                ec.tienphonglon = txtSmallRoom.Text;
                ec.tiendien = txtElec.Text;
                ec.tiennuoc = txtWater.Text;
                ec.tienxe = txtParking.Text;
                ec.tienmang = txtInternet.Text;
                ec.tienrac = txtGarbage.Text;
                ec.giamtienlenphong = txtDiscount.Text;
                if (Kiemtra != 0)
                {
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Updated data !", "Message");
                }
                else
                {
                    bus.ThemDuLieu(ec);
                    MessageBox.Show("Added data !", "Message");
                }
            }
            catch
            {
                MessageBox.Show("Error", "Message");
                return;
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            Kiemtra = int.Parse(bus.kiemtra());
            if(Kiemtra!=0)
            {
                txtBigRoom.Text = bus.getvalue("tienphongnho", "'1'");
                txtSmallRoom.Text = bus.getvalue("tienphonglon", "'1'");
                txtElec.Text = bus.getvalue("tiendien", "'1'");
                txtWater.Text = bus.getvalue("tiennuoc", "'1'");
                txtParking.Text = bus.getvalue("tienxe", "'1'");
                txtInternet.Text = bus.getvalue("tienmang", "'1'");
                txtGarbage.Text = bus.getvalue("tienrac", "'1'");
                txtDiscount.Text = bus.getvalue("giamtienlenphong", "'1'");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
