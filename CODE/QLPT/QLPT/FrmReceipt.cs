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
        int tienphongnho;
        int tienphonglon;
        int tiendien;
        int tiennuoc;
        int tienmang;
        int tienrac;
        int tienxe;
        int giamtien;
        int Kiemtra;
        string year;
        string month;
        int soluongnguoi;
        BUS_Receipt bus = new BUS_Receipt();
        E_Receipt ec = new E_Receipt();
        public FrmReceipt()
        {
            InitializeComponent();
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            Kiemtra = int.Parse(bus.kiemtra());
            
                if (Kiemtra != 0)
                {
                    tienphongnho = int.Parse(bus.getvalue2("tienphongnho", "'1'"));
                    tienphonglon = int.Parse(bus.getvalue2("tienphonglon", "'1'"));
                    tiendien = int.Parse(bus.getvalue2("tiendien", "'1'"));
                    tiennuoc = int.Parse(bus.getvalue2("tiennuoc", "'1'"));
                    tienxe = int.Parse(bus.getvalue2("tienxe", "'1'"));
                    tienmang = int.Parse(bus.getvalue2("tienmang", "'1'"));
                    tienrac = int.Parse(bus.getvalue2("tienrac", "'1'"));
                    giamtien = int.Parse(bus.getvalue2("giamtienlenphong", "'1'"));
                }
                cboChoseRoom.DataSource = bus.LayThongtinmapt(" where trangthai = 'Đang cho thuê' ");
                cboChoseRoom.ValueMember = "mapt";
                cboChoseRoom.DisplayMember = "mapt";
                if (cboChoseRoom != null)
                {
                    soluongnguoi = int.Parse(bus.demsoluongnguoi("'" + cboChoseRoom.Text + "'"));
                    txtRoomName.Text = bus.getvalue("tenphong", "'" + cboChoseRoom.Text + "'");
                    txtRoomID.Text = bus.getvalue("mapt", "'" + cboChoseRoom.Text + "'");
                    txtFloor.Text = bus.getvalue("tang", "'" + cboChoseRoom.Text + "'");
                    txtType.Text = bus.getvalue("loai", "'" + cboChoseRoom.Text + "'");
                    dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtRoomID.Text + "'");
                    txtWater.Text = (soluongnguoi * tiennuoc).ToString();
                    txtInternet.Text = tienmang.ToString();
                    if (txtType.Text == "A")
                    {
                        txtRoomMoney.Text = tienphongnho.ToString();
                    }
                    else { txtRoomMoney.Text = tienphonglon.ToString(); }

                }
            
            string time = dtpReceiptDate.Text;
            year = time.Substring(6, 4);
            month = time.Substring(3, 2);
        }

        private void cboChoseRoom_TextChanged(object sender, EventArgs e)
        {
            if (cboChoseRoom != null)
            {
                soluongnguoi = int.Parse(bus.demsoluongnguoi("'" + cboChoseRoom.Text + "'"));
                txtRoomName.Text = bus.getvalue("tenphong", "'" + cboChoseRoom.Text + "'");
                txtRoomID.Text = bus.getvalue("mapt", "'" + cboChoseRoom.Text + "'");
                txtFloor.Text = bus.getvalue("tang", "'" + cboChoseRoom.Text + "'");
                txtType.Text = bus.getvalue("loai", "'" + cboChoseRoom.Text + "'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtRoomID.Text + "'");
                txtWater.Text = (soluongnguoi * tiennuoc).ToString();
                txtInternet.Text = tienmang.ToString();
                if (txtType.Text == "A")
                {
                    txtRoomMoney.Text = tienphongnho.ToString();
                }             
                else { txtRoomMoney.Text = tienphonglon.ToString(); }
                try
                {
                    if (txtElec.Text != "" && txtVehicle.Text != "")
                    {
                        txtTotal.Text = (tienrac + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                       + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                       + int.Parse(txtParking.Text) - ((int.Parse(txtFloor.Text) - 1) * giamtien)).ToString();
                    }
                }
                catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định","Thông báo"); }
            }
        }

        private void txtElec_TextChanged(object sender, EventArgs e)
        {

            try
            {
                txtElecMoney.Text = (tiendien * (int.Parse(txtElec.Text))).ToString();
                if (txtVehicle.Text != "")
                {
                    txtTotal.Text = (tienrac + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                       + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                       + int.Parse(txtParking.Text) - ((int.Parse(txtFloor.Text) - 1) * giamtien)).ToString();
                }
            }
            catch { MessageBox.Show("Vui lòng kiểm tra lại tham số ở form qui định", "Thông báo"); }
        }

        private void txtVehicle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtParking.Text = (tienxe * (int.Parse(txtVehicle.Text))).ToString();
                if (txtElec.Text != "")
                {
                    txtTotal.Text = (tienrac + int.Parse(txtRoomMoney.Text) + int.Parse(txtElecMoney.Text)
                                   + int.Parse(txtWater.Text) + int.Parse(txtInternet.Text)
                                   + int.Parse(txtParking.Text) - ((int.Parse(txtFloor.Text) - 1) * giamtien)).ToString();
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
            string a = bus.kiemtra2(cboChoseRoom.Text, month, year);
            if(a!="0")
            {
                MessageBox.Show("You have completed payment !", "Message");
                return;
            }
            else
            {
                try
                {
                    
                    ec.mapt = cboChoseRoom.Text;
                    ec.tiendien = txtElecMoney.Text;
                    ec.tiennuoc = txtWater.Text;
                    ec.tienxe = txtParking.Text;
                    ec.tienmang = txtInternet.Text;
                    ec.tongtien = txtTotal.Text;
                    ec.tienphong = txtRoomMoney.Text;
                    ec.ngaythu = dtpReceiptDate.Value;
                    if (txtElec.Text != "" && txtVehicle.Text != "")
                    {
                        if (tienphonglon != 0 && tienphongnho!=0&&tiendien!=0&&tiennuoc!=0&&tienmang!=0&&tienrac!=0&&tienxe!=0&&giamtien!=0)
                        {
                          
                            bus.ThemDuLieu(ec);
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
