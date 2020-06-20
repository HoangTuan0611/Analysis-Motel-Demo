namespace QLPT
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tipLogin = new System.Windows.Forms.ToolStripButton();
            this.tipHireRoom = new System.Windows.Forms.ToolStripButton();
            this.tipRoom = new System.Windows.Forms.ToolStripSplitButton();
            this.tipRoomManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tipReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.tipCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tipStastistic = new System.Windows.Forms.ToolStripButton();
            this.tipSetting = new System.Windows.Forms.ToolStripButton();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipLogin,
            this.tipHireRoom,
            this.tipRoom,
            this.tipStastistic,
            this.tipSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tipLogin
            // 
            this.tipLogin.Image = ((System.Drawing.Image)(resources.GetObject("tipLogin.Image")));
            this.tipLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipLogin.Name = "tipLogin";
            this.tipLogin.Size = new System.Drawing.Size(74, 24);
            this.tipLogin.Text = "Log In";
            this.tipLogin.Click += new System.EventHandler(this.tipLogin_Click);
            // 
            // tipHireRoom
            // 
            this.tipHireRoom.Image = ((System.Drawing.Image)(resources.GetObject("tipHireRoom.Image")));
            this.tipHireRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipHireRoom.Name = "tipHireRoom";
            this.tipHireRoom.Size = new System.Drawing.Size(105, 24);
            this.tipHireRoom.Text = "Hire Room";
            this.tipHireRoom.Click += new System.EventHandler(this.tipHireRoom_Click);
            // 
            // tipRoom
            // 
            this.tipRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipRoomManagement,
            this.tipReceipt,
            this.tipCheckOut});
            this.tipRoom.Image = ((System.Drawing.Image)(resources.GetObject("tipRoom.Image")));
            this.tipRoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipRoom.Name = "tipRoom";
            this.tipRoom.Size = new System.Drawing.Size(88, 24);
            this.tipRoom.Text = "Room";
            // 
            // tipRoomManagement
            // 
            this.tipRoomManagement.Image = ((System.Drawing.Image)(resources.GetObject("tipRoomManagement.Image")));
            this.tipRoomManagement.Name = "tipRoomManagement";
            this.tipRoomManagement.Size = new System.Drawing.Size(224, 26);
            this.tipRoomManagement.Text = "Room Management";
            this.tipRoomManagement.Click += new System.EventHandler(this.tipRoomManagement_Click);
            // 
            // tipReceipt
            // 
            this.tipReceipt.Image = ((System.Drawing.Image)(resources.GetObject("tipReceipt.Image")));
            this.tipReceipt.Name = "tipReceipt";
            this.tipReceipt.Size = new System.Drawing.Size(224, 26);
            this.tipReceipt.Text = "Receipt";
            this.tipReceipt.Click += new System.EventHandler(this.tipReceipt_Click);
            // 
            // tipCheckOut
            // 
            this.tipCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("tipCheckOut.Image")));
            this.tipCheckOut.Name = "tipCheckOut";
            this.tipCheckOut.Size = new System.Drawing.Size(224, 26);
            this.tipCheckOut.Text = "Check Out";
            this.tipCheckOut.Click += new System.EventHandler(this.tipCheckOut_Click);
            // 
            // tipStastistic
            // 
            this.tipStastistic.Image = ((System.Drawing.Image)(resources.GetObject("tipStastistic.Image")));
            this.tipStastistic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipStastistic.Name = "tipStastistic";
            this.tipStastistic.Size = new System.Drawing.Size(85, 24);
            this.tipStastistic.Text = "Statistic";
            this.tipStastistic.Click += new System.EventHandler(this.tipStastistic_Click);
            // 
            // tipSetting
            // 
            this.tipSetting.Image = ((System.Drawing.Image)(resources.GetObject("tipSetting.Image")));
            this.tipSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tipSetting.Name = "tipSetting";
            this.tipSetting.Size = new System.Drawing.Size(80, 24);
            this.tipSetting.Text = "Setting";
            this.tipSetting.Click += new System.EventHandler(this.tipSetting_Click);
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(183, 454);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(0, 17);
            this.lbltaikhoan.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.Color.Teal;
            this.lblUserName.Location = new System.Drawing.Point(23, 454);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Account";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 490);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motel Management System";
            this.Load += new System.EventHandler(this.tipSetting_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tipLogin;
        private System.Windows.Forms.ToolStripButton tipHireRoom;
        private System.Windows.Forms.ToolStripButton tipStastistic;
        private System.Windows.Forms.ToolStripSplitButton tipRoom;
        private System.Windows.Forms.ToolStripMenuItem tipRoomManagement;
        private System.Windows.Forms.ToolStripMenuItem tipReceipt;
        private System.Windows.Forms.ToolStripMenuItem tipCheckOut;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripButton tipSetting;
    }
}