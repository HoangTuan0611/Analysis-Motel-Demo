﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string Account = string.Empty;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LockConditon();
            tipLogin_Click(sender, e);
        }
        void LockConditon()
        {
            toolStripButton1.Enabled = false;
            tipSetting.Enabled = false;
            tipLogin.Enabled = true;
            tipRoomManagement.Enabled = false;
            tipStastistic.Enabled = false;
            tipHireRoom.Enabled = false;
        }
        void OpenCondition()
        {
            toolStripButton1.Enabled = true;
            tipSetting.Enabled = true;
            tipLogin.Enabled = true;
            tipRoomManagement.Enabled = true;
            tipStastistic.Enabled = true;
            tipHireRoom.Enabled = true;
        }
        private void tipLogin_Click(object sender, EventArgs e)
        {
            if (tipLogin.Text == "Log In" && this.lbltaikhoan.Text == "")
            {
                FrmLogin dn = new FrmLogin();
                // chỉ 1 cửa sổ được mở ra!
                dn.ShowDialog();

                // nếu chuỗi có giá trị!
                if (!string.IsNullOrEmpty(Account))
                {
                    this.lbltaikhoan.Text = Account;
                    this.lbltaikhoan.BackColor = System.Drawing.Color.Transparent;
                    this.lbltaikhoan.ForeColor = System.Drawing.Color.Teal;
                    OpenCondition();
                    tipLogin.Text = "Log Out";
                }
            }
            else
            {

                DialogResult message;
                message = (MessageBox.Show("Do you want to Log out", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (message == DialogResult.Yes)
                {
                    LockConditon();
                    this.lbltaikhoan.Text = "";
                    tipLogin.Text = "Log In";
                }

                if (this.lbltaikhoan.Text == "")
                {
                    LockConditon();
                    tipLogin.Text = "Log In";
                }

            }
        }

        private void tipHireRoom_Click(object sender, EventArgs e)
        {
            FrmCustomer kt = new FrmCustomer();
            kt.ShowDialog();
        }


    

        private void tipSetting_Click(object sender, EventArgs e)
        {
            FrmSetting qd = new FrmSetting();
            qd.ShowDialog();
        }

   

        private void tipStastistic_Click(object sender, EventArgs e)
        {
            FrmStastistic tk = new FrmStastistic();
            tk.ShowDialog();
        }

    

        private void hireRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHireRoom hr = new FrmHireRoom();
            hr.ShowDialog();
        }

        private void tipReceipt_Click_1(object sender, EventArgs e)
        {
            FrmReceipt tt = new FrmReceipt();
            tt.ShowDialog();
        }


        private void tipRoomManagement_Click_1(object sender, EventArgs e)
        {
            FrmRoom pt = new FrmRoom();
            pt.ShowDialog();
        }
    }
}
