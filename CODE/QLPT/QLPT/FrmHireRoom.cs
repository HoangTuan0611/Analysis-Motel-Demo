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
    public partial class FrmHireRoom : Form
    {
        string checkstatusroom;
        string text;
        public FrmHireRoom()
        {
            InitializeComponent();
        }
        ConnectDB db = new ConnectDB();
        BUS_HireRoom bus = new BUS_HireRoom();
        E_HireRoom ec = new E_HireRoom();
        void LockCondition()
        {
           
            txtcon.Enabled = false;
            cbcus.Enabled = false;
            cbroom.Enabled = false;
            dtfrom.Enabled = false;
            dtto.Enabled = false;
  

        }

        void OpenCondition()
        {
            
            cbcus.Enabled = true;
            cbroom.Enabled = true;
            dtfrom.Enabled = true;
            dtto.Enabled = true;

        }

        void setnull()
        {
            txtcon.Text = "";
            cbcus.Text = "";
            cbroom.Text = "";
            dtfrom.Text = "";
            dtto.Text = "";
       
   
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCusName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCusID_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        void Display(string where)
        {
            grdContract.DataSource = bus.CreateTable(where);
        }

        private void FrmHireRoom_Load(object sender, EventArgs e)
        {
            cbcus.DataSource = bus.GetCustomerID(" where makt != ''");
            cbcus.ValueMember = "makt";
            cbcus.DisplayMember = "makt";
            if (ckbemptyroom.Checked == true)
            {
                cbroom.DataSource = bus.GetRoomID(" where trangthai = 'empty'");
                cbroom.ValueMember = "mapt";
                cbroom.DisplayMember = "mapt";
            }
            else
            {
                cbroom.DataSource = bus.GetRoomID(" where trangthai != 'Bảo trì'");
                cbroom.ValueMember = "mapt";
                cbroom.DisplayMember = "mapt";
            }
            //if (cbroom != null)
            //{
            //    txtmaxslot.Text = bus.maxslot("'" + cbroom.Text + "'");
            //    txtcurrentslot.Text = bus.countcustomer("'" + cbroom.Text + "'");
            //}
            LockCondition(); 
            Display("");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add")
            {
                OpenCondition();
                setnull();
                cbcus.Focus();
                btnadd.Text = "Save";
                AutoIncreamentID();
            }
            else if (btnadd.Text == "Save")
            {
                if (cbcus.Text == "" || cbroom.Text == "")
                {
                    MessageBox.Show("Please fill out Information", "Message");
                    return;
                }
                else
                {
                    try
                    {
                        ec.CusID = cbcus.Text;
                        ec.RoomID = cbroom.Text;
                        ec.Datefrom = dtfrom.Value;
                        ec.Dateto = dtto.Value;
                        ec.ConID = txtcon.Text;
                        bus.AddData(ec);
                        bus.updatestatusroom_1("'" + cbroom.Text + "'");
                        MessageBox.Show("Added data !", "Message");
                        //int a = int.Parse(txtcurrentslot.Text);
                        //int b = int.Parse(txtmaxslot.Text);
                        //if (a < b)
                        //{
                        //    bus.AddData(ec);
                        //    bus.updatestatusroom_1("'" + cbroom.Text + "'");
                        //    MessageBox.Show("Added data !", "Message");
                        //}
                        //else { MessageBox.Show("Room full"); }

                    }
                    catch
                    {
                        MessageBox.Show("Failed, try again!", "Message");
                        return;
                    }
                }
                btnadd.Text = "Add";
                LockCondition();
                Display("");
            }
        }
        private void AutoIncreamentID()
        {
            DataTable dt = db.GetDataTable("Select * from thuephong");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "HRM00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "HRM";//ký tự mặc định của mã nhân viên

                string str = dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 5);

                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 5));
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
            txtcon.Text = h;
        }

        private void grdContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtcon.Text = grdContract.Rows[dong].Cells[0].Value.ToString();
                //cboRoomID.Text = grdCustomer.Rows[dong].Cells[1].Value.ToString();
                //checkroomstatus = cboRoomID.Text;
                checkstatusroom = cbroom.Text;
                cbcus.Text = grdContract.Rows[dong].Cells[1].Value.ToString();
                cbroom.Text = grdContract.Rows[dong].Cells[2].Value.ToString();
                dtfrom.Text = grdContract.Rows[dong].Cells[3].Value.ToString();
                dtto.Text = grdContract.Rows[dong].Cells[4].Value.ToString();
          
            }
            catch
            {

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void ckbemptyroom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbemptyroom.Checked == true)
            {
                cbroom.DataSource = bus.GetRoomID("where trangthai = 'empty'");
                cbroom.ValueMember = "mapt";
                cbroom.DisplayMember = "mapt";
            }
            else
            {
                cbroom.DataSource = bus.GetRoomID(" where trangthai != 'Bảo trì'");
                cbroom.ValueMember = "mapt";
                cbroom.DisplayMember = "mapt";
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setnull();
            cbcus.Focus();
            btnadd.Text = "Add";
            LockCondition();
        }

        private void cbroom_TextChanged(object sender, EventArgs e)
        {
            //txtmaxslot.Text = bus.maxslot("'" + cbroom.Text + "'");
            //txtcurrentslot.Text = bus.countcustomer("'" + cbroom.Text + "'");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                bus.UpdateRoomStatus("'" + cbroom.Text + "'");
                MessageBox.Show("Checkout Succsesful", "Message");
            }
            catch
            {
                MessageBox.Show("You have completed checkout", "Message");
            }
        }
    }
}
