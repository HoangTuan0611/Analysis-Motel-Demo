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
using System.Text.RegularExpressions;
using QLPT_DAL;
using QLPT_Entity;

namespace QLPT
{
    public partial class FrmRoom : Form
    {
        string checkroomstatus;
        public FrmRoom()
        {
            InitializeComponent();
        }

        ConnectDB db = new ConnectDB();
        BUS_Room bus = new BUS_Room();
        E_Room ec = new E_Room();

        void LockCondition()
        {
            txtRoomID.Enabled = false;

            btnCancel.Enabled = false;
            txtRoomName.Enabled = false;
            cboStatus.Enabled = false;
            cboType.Enabled = false;
            cboFloor.Enabled = false;
           
        }

        void OpenCondition()
        {
            txtRoomID.Enabled = false;

            btnCancel.Enabled = true;
            txtRoomName.Enabled = true;         
            cboType.Enabled = true;
            cboFloor.Enabled = true;
            cboStatus.Enabled = true;
        }

        void setnull()
        {
            txtRoomID.Text = "";
            
    
            txtRoomName.Text = "";
            cboFloor.Text = "";
            cboType.Text = "";
        }

        void Display(string where)
        {
            grdRoom.DataSource = bus.TaoBang(where);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            cboType.DataSource = bus.GetTypeRoomInfo("");
            cboType.ValueMember = "loai";
            cboType.DisplayMember = "loai";
            cboFloor.DataSource = bus.GetFloorInfo("");
            cboFloor.ValueMember = "tang";
            cboFloor.DisplayMember = "tang";
            LockCondition();
            Display("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {               
                OpenCondition();
                cboStatus.Text = "Trống";
                cboStatus.Enabled = false;
                setnull();
                txtRoomID.Focus();
                btnAdd.Text = "Save";
                MaTuTang();
            }
            else if (btnAdd.Text == "Save")
            {
                if (txtRoomID.Text == "" || txtRoomName.Text == "" || cboFloor.Text == "" || cboType.Text == "")
                {
                    MessageBox.Show("Please fill out information", "Message");
                    return;
                }
                else
                {
                    try
                    {
                        ec.roomID = txtRoomID.Text;
                        ec.type = cboType.Text;
                        ec.floor = cboFloor.Text;
                        if (cboType.Text == "A")
                        {
                            ec.maxCus = "2";
                        }
                        else { ec.maxCus = "3"; }
                        ec.status = cboStatus.Text;
                        ec.roomName = txtRoomName.Text;
                        bus.AddData(ec);
                        MessageBox.Show("Add data success", "Message");

                    }
                    catch
                    {
                        MessageBox.Show("Error", "Message");
                        return;
                    }
                }
                btnAdd.Text = "Add";
                LockCondition();
                Display("");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //if (ec.trangthai == "Đang cho thuê")
            //{
            //    btnsua.Enabled = false;
            //}
            if (btnUpdate.Text == "Update")
            {
                OpenCondition();
                if (checkroomstatus != "Đang cho thuê")
                {
                    cboStatus.Enabled = true;
                    txtRoomID.Focus();
                    btnUpdate.Text = "Save";
                }
                else
                {
                    btnUpdate.Text = "Update";
                    cboStatus.Enabled = false;
                    btnUpdate.Enabled = false;
                      
                  
                }
                
            }
            else if (btnUpdate.Text == "Save")
            {
               
                if (txtRoomID.Text == "" || txtRoomName.Text == "" || cboType.Text == "" || cboFloor.Text == "")
                {
                    MessageBox.Show("Please fill out information", "Message");
                    return;
                }
                else
                {
                    try
                    {
                        ec.roomID = txtRoomID.Text;
                        ec.type = cboType.Text;
                        ec.floor = cboFloor.Text;
                        if (cboType.Text == "A")
                        {
                            ec.maxCus = "2";
                        }
                        else { ec.maxCus = "3"; }
                        //if (ec.trangthai == "Đang cho thuê")
                        //{
                        //    cmbtrangthai.Enabled = false;
                        //}
                        //else
                        //{
                        //    ec.trangthai = cmbtrangthai.Text;
                        //}
                        ec.status = cboStatus.Text;
                        ec.roomName = txtRoomName.Text;
                        bus.UpdateData(ec);
                        MessageBox.Show("Update data success", "Message");

                    }
                    catch
                    {
                        MessageBox.Show("Error", "Message");
                        return;
                    }
                }
                LockCondition();
                Display("");
                btnUpdate.Text = "Update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ec.roomID = txtRoomID.Text;
                bus.DeleteData(ec);
                MessageBox.Show("Deleted !");
                LockCondition();
                Display("");
            }
            catch
            {
                MessageBox.Show("Can't delete ");
            }
        }
        private void MaTuTang()
        {

            DataTable dt = db.GetDataTable("Select * from phongtro");
            string h = "";
            if (dt == null) { h = "PT00001"; goto here; }
            if (dt.Rows.Count <= 0)
            {
                h = "PT00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "PT";//ký tự mặc định của mã nhân viên
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
            here:
            txtRoomID.Text = h;
        }

        private void grdRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtRoomID.Text = grdRoom.Rows[dong].Cells[0].Value.ToString();                               
                txtRoomName.Text = grdRoom.Rows[dong].Cells[2].Value.ToString();
                cboStatus.Text = grdRoom.Rows[dong].Cells[5].Value.ToString();
                checkroomstatus = cboStatus.Text;
                cboType.Text = grdRoom.Rows[dong].Cells[3].Value.ToString();
                cboFloor.Text = grdRoom.Rows[dong].Cells[1].Value.ToString();

            }
            catch
            {

            }
        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
            txtRoomName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtRoomName.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txtRoomName.SelectionStart = txtRoomName.Text.Length;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setnull();
            txtRoomID.Focus();
            btnAdd.Text = "Add";
        }
    }
}
