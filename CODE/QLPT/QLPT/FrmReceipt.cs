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
using QLPT_Entity;

namespace QLPT
{
    public partial class FrmReceipt : Form
    {
        int smallroomcharge;
        int bigroomcharge;
        int elec;
        int water;
        int internet;
        int garbage;
        int parking;
        int discount;
        int check;
        string year;
        string month;
        int countcustomer;
        BUS_Receipt bus = new BUS_Receipt();
        E_Receipt ec = new E_Receipt();
        public FrmReceipt()
        {
            InitializeComponent();
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            check = int.Parse(bus.check());
            
                if (check != 0)
                {
                    smallroomcharge = int.Parse(bus.getvalue2("tienphongnho", "'1'"));
                    bigroomcharge = int.Parse(bus.getvalue2("tienphonglon", "'1'"));
                    elec = int.Parse(bus.getvalue2("tiendien", "'1'"));
                    water = int.Parse(bus.getvalue2("tiennuoc", "'1'"));
                    parking = int.Parse(bus.getvalue2("tienxe", "'1'"));
                    internet = int.Parse(bus.getvalue2("tienmang", "'1'"));
                    garbage = int.Parse(bus.getvalue2("tienrac", "'1'"));
                    discount = int.Parse(bus.getvalue2("giamtienlenphong", "'1'"));
                }
            //cboChoseRoom.DataSource = bus.GetRoomID(" where trangthai = 'Đang cho thuê' ");
                cboChoseRoom.DataSource = bus.GetRoomID("");
                cboChoseRoom.ValueMember = "mathue";
                 cboChoseRoom.DisplayMember = "mathue";
            if (cboChoseRoom != null)
                {
                    countcustomer = int.Parse(bus.countCustomer("'" + cboChoseRoom.Text + "'"));
                //txtRoomName.Text = bus.getvalue("tenphong", "'" + cboChoseRoom.Text + "'");

                //txtFloor.Text = bus.getvalue("tang", "'" + cboChoseRoom.Text + "'");
                //txtType.Text = bus.getvalue("loai", "'" + cboChoseRoom.Text + "'");
                txtRoomName.Text = bus.getvalue("mapt", "'" + cboChoseRoom.Text + "'");
                txtRoomID.Text = bus.getvalue("makt", "'" + cboChoseRoom.Text + "'");
                txtStartHire.Text = bus.getvalue("ngaybd", "'" + cboChoseRoom.Text + "'");
                txtEndHire.Text = bus.getvalue("ngaykt", "'" + cboChoseRoom.Text + "'");
                dgthongtinkhachthue.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'");
                //txtWater.Text = (countcustomer * water).ToString();
                txtWater.Text = water.ToString();
                txtInternet.Text = internet.ToString();
                    if (txtEndHire.Text == "A")
                    {
                        txtRoomMoney.Text = smallroomcharge.ToString();
                    }
                    else { txtRoomMoney.Text = bigroomcharge.ToString(); }

                }
            
            string time = dtpReceiptDate.Text;
            year = time.Substring(6, 4);
            month = time.Substring(3, 2);
        }

        private void cboChoseRoom_TextChanged(object sender, EventArgs e)
        {
            if (cboChoseRoom != null)
            {
                countcustomer = int.Parse(bus.countCustomer("'" + cboChoseRoom.Text + "'"));
                //txtRoomName.Text = bus.getvalue("tenphong", "'" + cboChoseRoom.Text + "'");

                //txtFloor.Text = bus.getvalue("tang", "'" + cboChoseRoom.Text + "'");
                //txtType.Text = bus.getvalue("loai", "'" + cboChoseRoom.Text + "'");
                txtRoomName.Text = bus.getvalue("mapt", "'" + cboChoseRoom.Text + "'");
                txtRoomID.Text = bus.getvalue("makt", "'" + cboChoseRoom.Text + "'");
                txtStartHire.Text = bus.getvalue("ngaybd", "'" + cboChoseRoom.Text + "'");
                txtEndHire.Text = bus.getvalue("ngaykt", "'" + cboChoseRoom.Text + "'");
                dgthongtinkhachthue.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'");
                txtWater.Text = (countcustomer * water).ToString();
                txtInternet.Text = internet.ToString();
                if (txtEndHire.Text == "A")
                {
                    txtRoomMoney.Text = smallroomcharge.ToString();
                }             
                else { txtRoomMoney.Text = bigroomcharge.ToString(); }
                try
                {
                    if (txtElec.Text != "" && txtVehicle.Text != "")
                    {
                        txtTotal.Text = (garbage + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                       + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                       + int.Parse(txtParking.Text) - ((int.Parse(txtStartHire.Text) - 1) * discount)).ToString();
                    }
                }
                catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định","Thông báo"); }
            }
        }

        private void txtElec_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txtElecMoney.Text = (elec * (int.Parse(txtElec.Text))).ToString();
                if (txtVehicle.Text != "")
                {
                    txtTotal.Text = (garbage + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                       + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                       + int.Parse(txtParking.Text) - ((int.Parse(txtStartHire.Text) - 1) * discount)).ToString();
                }
            }
            catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định", "Thông báo"); }
        }

        private void txtVehicle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtParking.Text = (parking * (int.Parse(txtVehicle.Text))).ToString();
                if (txtElec.Text != "")
                {
                    txtTotal.Text = (garbage + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                   + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                   + int.Parse(txtParking.Text) - ((int.Parse(txtStartHire.Text) - 1) * discount)).ToString();
                }
            }
            catch { MessageBox.Show("Please fill out this form", "Message"); }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtElec.Text == "")
            {
                MessageBox.Show("Please fill a index of electric usage", "Message");
                return;
            }
            if (txtVehicle.Text == "")
            {
                MessageBox.Show("Please fill a number of vehicle", "Message");
                return;
            }
            string a = bus.check2(cboChoseRoom.Text, month, year);
            if(a!="0")
            {
                MessageBox.Show("You have completed payment !", "Message");
                return;
            }
            else
            {
                try
                {
                    
                    ec.roomID = cboChoseRoom.Text;
                    ec.elec = txtElecMoney.Text;
                    ec.water = txtWater.Text;
                    ec.parking = txtParking.Text;
                    ec.internet = txtInternet.Text;
                    ec.total = txtTotal.Text;
                    ec.roomCharge = txtRoomMoney.Text;
                    ec.receiptDate = dtpReceiptDate.Value;
                    if (txtElec.Text != "" && txtVehicle.Text != "")
                    {
                        if (bigroomcharge != 0 && smallroomcharge!=0&&elec!=0&&water!=0&&internet!=0&&garbage!=0&&parking!=0&&discount!=0)
                        {
                          
                            bus.AddData(ec);
                            MessageBox.Show("Payment success !", "Message");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Please fill out this Form");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Payment failed !", "Message");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Error", "Message");
                    return;
                }
            }
        }

        private void dtpReceiptDate_ValueChanged(object sender, EventArgs e)
        {
            string time = dtpReceiptDate.Text;
            year = time.Substring(6, 4);
            month = time.Substring(3, 2);
        }

       
    }
}
