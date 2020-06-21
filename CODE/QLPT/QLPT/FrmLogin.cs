using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using QLPT_DAL;


namespace QLPT
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ConnectDB db = new ConnectDB();

   

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strcon = @"Server=DESKTOP-19MG1RT\SQLEXPRESS01; Database=DataQLPT ;Integrated Security=SSPI;";
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            DataTable dt = SqlHelper.ExecuteDataset(strcon, "DangNhap_Login", user, pass).Tables[0];

            if (dt.Rows.Count > 0)

            {
                FrmMain.Account = txtUsername.Text;
                MessageBox.Show("Welcome to Motel Managememt System");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry! Please enter a valid account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsername.Focus();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain.Account = txtUsername.Text = "";
            DialogResult message;
            message = (MessageBox.Show("Do you want to exit log in ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (message == DialogResult.Yes)
            {
                //MessageBox.Show("Tạm Biệt! Hẹn Gặp Lại", "Thông Báo");
                //Application.Exit();
                this.Hide();

            }
        }

        private void btndn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

    }
}
