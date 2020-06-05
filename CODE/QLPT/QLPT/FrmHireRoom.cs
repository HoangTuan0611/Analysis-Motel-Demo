using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLPT_BUS;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    
    public partial class Frmkhachtro : Form
    {
        
        string kiemtratinhtrangphong;
        string text;
        public Frmkhachtro()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_HireRoom bus = new BUS_HireRoom();
        E_khachtro ec = new E_khachtro();
        

        void KhoaDieuKien()
        {
            btnCancel.Enabled = false;
            txtIdenCard.Enabled = false;
            txtCusName.Enabled = false;
            txtCusID.Enabled = false;
            txtJob.Enabled = false;
            txtPhoneNumber.Enabled = false;
            cboRoomID.Enabled = false;
            optFemale.Enabled = false;
            optMale.Enabled = false;
            chkEmptyRoom.Enabled = false;
        }

        void MoDieuKien()
        {
            btnCancel.Enabled = true;
            txtIdenCard.Enabled = true;
            txtCusName.Enabled = true;
            txtCusID.Enabled = false;
            txtJob.Enabled = true;
            txtPhoneNumber.Enabled = true;
            cboRoomID.Enabled = true;
            optFemale.Enabled = true;
            optMale.Enabled = true;
            chkEmptyRoom.Enabled = true;
        }

        void setnull()
        {
            txtPhoneNumber.Text = "";
            txtJob.Text = "";
            txtCusID.Text = "";
            txtCusName.Text = "";
            txtIdenCard.Text = "";
            cboRoomID.Text = "";
        }

        void HienThi(string where)
        {
            grdCustomer.DataSource = bus.TaoBang(where);
        }

        private void FrmHireRoom_Load(object sender, EventArgs e)
        {
            
            if (chkEmptyRoom.Checked == true)
            {
                cboRoomID.DataSource = bus.LayThongtinmapt(" where trangthai = 'Trống'");
                cboRoomID.ValueMember = "mapt";
                cboRoomID.DisplayMember = "mapt";
            }
            else
            {
                cboRoomID.DataSource = bus.LayThongtinmapt(" where trangthai != 'Bảo trì'");
                cboRoomID.ValueMember = "mapt";
                cboRoomID.DisplayMember = "mapt";
            }
            if (cboRoomID != null)
            {
                txtMaxSlot.Text = bus.songuoitoida("'" + cboRoomID.Text + "'");
                txtCurrentSlot.Text = bus.demsoluongnguoi("'" + cboRoomID.Text + "'");
            }
            KhoaDieuKien();
            HienThi("");
        }

        private string GetGioiTinh()//Lấy giới tính của sinh viên
        {

            if (optMale.Checked)
                return "Nam";
            else 
                return "Nữ";           
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {

                MoDieuKien();
                setnull();
                txtCusID.Focus();
                btnAdd.Text = "Save";
                MaTuTang();
            }
            else if(btnAdd.Text == "Save")
            {
                if (txtCusID.Text == "" || txtCusName.Text == "" || cboRoomID.Text == "")
                {
                    MessageBox.Show("Please fill out Information", "Message");
                    return;
                }
                else
                {
                    try
                    {
                        ec.hoten = txtCusName.Text;
                        ec.nghenghiep = txtJob.Text;
                        ec.sdt = txtPhoneNumber.Text;
                        ec.cmnd = txtIdenCard.Text;
                        ec.mapt = cboRoomID.Text;
                        ec.gioitinh = GetGioiTinh();
                        ec.makt = txtCusID.Text;
                        int a = int.Parse(txtCurrentSlot.Text);
                        int b = int.Parse(txtMaxSlot.Text);
                        if (a<b) {
                            bus.ThemDuLieu(ec);
                            bus.updatetrangthaiphongtro1("'" + cboRoomID.Text + "'");
                            MessageBox.Show("Added data !", "Message");
                        }
                        else { MessageBox.Show("Room full"); }
                                              
                    }
                    catch
                    {
                        MessageBox.Show("Failed, try again!", "Message");
                        return;
                    }
                }
                btnAdd.Text = "Add";
                KhoaDieuKien();
                HienThi("");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                MoDieuKien();
                txtCusID.Focus();
                btnUpdate.Text = "Save";
            }
            else if (btnUpdate.Text == "Save")
            {
                if (txtCusID.Text == "" || txtCusName.Text == "" || cboRoomID.Text == "")
                {
                    MessageBox.Show("Please fill out Information", "Message");
                    return;
                }
                else
                {
                    try
                    {
                        ec.hoten = txtCusName.Text;
                        ec.nghenghiep = txtJob.Text;
                        ec.sdt = txtPhoneNumber.Text;
                        ec.cmnd = txtIdenCard.Text;
                        ec.mapt = cboRoomID.Text;
                        ec.gioitinh = GetGioiTinh();
                        ec.makt = txtCusID.Text;
                        int a = int.Parse(txtCurrentSlot.Text);
                        int b = int.Parse(txtMaxSlot.Text);                     
                        
                        if (cboRoomID.Text != kiemtratinhtrangphong)
                        {
                            if (a < b)
                            {
                                bus.SuaDuLieu(ec);
                                text = bus.demsoluongnguoi("'" + cboRoomID.Text + "'");
                                if (text == "0") bus.updatetrangthaiphongtro2("'" + cboRoomID.Text + "'");
                                else bus.updatetrangthaiphongtro1("'" + cboRoomID.Text + "'");
                                text = bus.demsoluongnguoi("'" + kiemtratinhtrangphong + "'");
                                if (text == "0") bus.updatetrangthaiphongtro2("'" + kiemtratinhtrangphong + "'");
                                else bus.updatetrangthaiphongtro1("'" + kiemtratinhtrangphong + "'");
                                MessageBox.Show("Updated Success", "Message");
                            }
                        }
                        else
                        {
                            bus.SuaDuLieu(ec);
                            bus.updatetrangthaiphongtro1("'" + cboRoomID.Text + "'");
                            MessageBox.Show("Updated Success", "Message");
                        }                                                                                                                         
                    }
                    catch
                    {
                        MessageBox.Show("Failed, try again!", "Message");
                        return;
                    }
                }
                KhoaDieuKien();
                HienThi("");
                btnUpdate.Text = "Update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ec.makt = txtCusID.Text;
                bus.XoaDuLieu(ec);
                text = bus.demsoluongnguoi("'" + kiemtratinhtrangphong + "'");
                if (text == "0") bus.updatetrangthaiphongtro2("'" + kiemtratinhtrangphong + "'");
                else bus.updatetrangthaiphongtro1("'" + kiemtratinhtrangphong + "'");
                MessageBox.Show("Deleted");
                KhoaDieuKien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Can't delete, Try again!");
            }
        }

        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from khachtro");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "KT00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "KT";//ký tự mặc định của mã nhân viên
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            txtCusID.Text = h;
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtCusID.Text = grdCustomer.Rows[dong].Cells[0].Value.ToString();
                cboRoomID.Text = grdCustomer.Rows[dong].Cells[1].Value.ToString();
                kiemtratinhtrangphong = cboRoomID.Text;
                txtCusName.Text = grdCustomer.Rows[dong].Cells[2].Value.ToString();      
                txtIdenCard.Text = grdCustomer.Rows[dong].Cells[3].Value.ToString();              
                txtJob.Text = grdCustomer.Rows[dong].Cells[5].Value.ToString();
                txtPhoneNumber.Text = grdCustomer.Rows[dong].Cells[6].Value.ToString();
                if (grdCustomer[4, grdCustomer.CurrentRow.Index].Value.ToString() == "Nam")
                {
                    optMale.Checked = true;
                }
                else
                {
                    optFemale.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void txtCusName_TextChanged(object sender, EventArgs e)
        {
            txtCusName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtCusName.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txtCusName.SelectionStart = txtCusName.Text.Length;
        }

        private void CboRoomID_TextChanged(object sender, EventArgs e)
        {
            txtMaxSlot.Text = bus.songuoitoida("'" + cboRoomID.Text + "'");
            txtCurrentSlot.Text = bus.demsoluongnguoi("'" + cboRoomID.Text + "'");
        }

        private void ChkEmptyRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmptyRoom.Checked == true)
            {
                cboRoomID.DataSource = bus.LayThongtinmapt(" where trangthai != 'Đang cho thuê' and trangthai != 'Bảo trì'");
                cboRoomID.ValueMember = "mapt";
                cboRoomID.DisplayMember = "mapt";
            }
            else
            {
                cboRoomID.DataSource = bus.LayThongtinmapt(" where trangthai != 'Bảo trì'");
                cboRoomID.ValueMember = "mapt";
                cboRoomID.DisplayMember = "mapt";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setnull();
            txtCusID.Focus();
            btnAdd.Text = "Add";
            KhoaDieuKien();
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (PhoneNumberCheck(txtPhoneNumber.Text) == false)
            {
                MessageBox.Show("Please re-enter the phone number (the phone number must be 10 digits and start with 0)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
            }
        }
        private bool PhoneNumberCheck(string sdt) //Kiểm số điện thoại 
        {
            if (sdt.Length == 10)
            {
                if (sdt[0] != '0')
                    return false;
                for (int i = 0; i < sdt.Length; i++)
                {
                    if (!char.IsDigit(sdt[i]))
                        return false;
                }
            }
            else
                return false;
            return true;
        }

        private void txtJob_TextChanged(object sender, EventArgs e)
        {
            txtJob.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtJob.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txtJob.SelectionStart = txtJob.Text.Length;
        }
    }







}
