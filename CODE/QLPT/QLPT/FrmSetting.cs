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
        int Check;
        BUS_Setting bus = new BUS_Setting();
        E_Setting ec = new E_Setting();
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ec.smallroomCharge = txtBigRoom.Text;
                ec.bigroomCharge = txtSmallRoom.Text;
                ec.elec = txtElec.Text;
                ec.water = txtWater.Text;
                ec.parking = txtParking.Text;
                ec.internet = txtInternet.Text;
                ec.garbage = txtGarbage.Text;
                ec.discount = txtDiscount.Text;
                if (Check != 0)
                {
                    bus.UpdateData(ec);
                    MessageBox.Show("Updated data !", "Message");
                }
                else
                {
                    bus.AddData(ec);
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
            Check = int.Parse(bus.check());
            if(Check!=0)
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
