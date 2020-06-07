namespace QLPT
{
    partial class FrmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckOut));
            this.lblChoseRoom = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.grpHireRoom = new System.Windows.Forms.GroupBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.grpHireCusInfo = new System.Windows.Forms.GroupBox();
            this.grdCusHireInfo = new System.Windows.Forms.DataGridView();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgree = new System.Windows.Forms.Button();
            this.grpHireRoom.SuspendLayout();
            this.grpHireCusInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCusHireInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoseRoom
            // 
            this.lblChoseRoom.AutoSize = true;
            this.lblChoseRoom.Location = new System.Drawing.Point(99, 64);
            this.lblChoseRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoseRoom.Name = "lblChoseRoom";
            this.lblChoseRoom.Size = new System.Drawing.Size(68, 13);
            this.lblChoseRoom.TabIndex = 0;
            this.lblChoseRoom.Text = "Chose Room";
            // 
            // cboRoom
            // 
            this.cboRoom.DisplayMember = "mapt";
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(188, 62);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(116, 21);
            this.cboRoom.TabIndex = 2;
            this.cboRoom.TextChanged += new System.EventHandler(this.cboRoom_TextChanged);
            // 
            // grpHireRoom
            // 
            this.grpHireRoom.Controls.Add(this.txtRoomName);
            this.grpHireRoom.Controls.Add(this.txtRoomID);
            this.grpHireRoom.Controls.Add(this.lblRoomName);
            this.grpHireRoom.Controls.Add(this.lblRoomID);
            this.grpHireRoom.Enabled = false;
            this.grpHireRoom.Location = new System.Drawing.Point(95, 119);
            this.grpHireRoom.Margin = new System.Windows.Forms.Padding(2);
            this.grpHireRoom.Name = "grpHireRoom";
            this.grpHireRoom.Padding = new System.Windows.Forms.Padding(2);
            this.grpHireRoom.Size = new System.Drawing.Size(592, 102);
            this.grpHireRoom.TabIndex = 4;
            this.grpHireRoom.TabStop = false;
            this.grpHireRoom.Text = "Hire Room Info";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(402, 50);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(76, 20);
            this.txtRoomName.TabIndex = 3;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(175, 50);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(76, 20);
            this.txtRoomID.TabIndex = 2;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(321, 53);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(63, 13);
            this.lblRoomName.TabIndex = 1;
            this.lblRoomName.Text = "RoomName";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(87, 55);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 0;
            this.lblRoomID.Text = "Room ID";
            // 
            // grpHireCusInfo
            // 
            this.grpHireCusInfo.Controls.Add(this.grdCusHireInfo);
            this.grpHireCusInfo.Location = new System.Drawing.Point(9, 297);
            this.grpHireCusInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpHireCusInfo.Name = "grpHireCusInfo";
            this.grpHireCusInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpHireCusInfo.Size = new System.Drawing.Size(679, 150);
            this.grpHireCusInfo.TabIndex = 6;
            this.grpHireCusInfo.TabStop = false;
            this.grpHireCusInfo.Text = "Customer Info";
            // 
            // grdCusHireInfo
            // 
            this.grdCusHireInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCusHireInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makt,
            this.mapt,
            this.hoten,
            this.cmnd,
            this.gioitinh,
            this.nghenghiep,
            this.sdt});
            this.grdCusHireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCusHireInfo.Location = new System.Drawing.Point(2, 15);
            this.grdCusHireInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grdCusHireInfo.Name = "grdCusHireInfo";
            this.grdCusHireInfo.RowTemplate.Height = 24;
            this.grdCusHireInfo.Size = new System.Drawing.Size(675, 133);
            this.grdCusHireInfo.TabIndex = 0;
            // 
            // makt
            // 
            this.makt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makt.DataPropertyName = "makt";
            this.makt.HeaderText = "Mã khách trọ";
            this.makt.Name = "makt";
            // 
            // mapt
            // 
            this.mapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Mã phòng trọ";
            this.mapt.Name = "mapt";
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            // 
            // cmnd
            // 
            this.cmnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "CMND";
            this.cmnd.Name = "cmnd";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // nghenghiep
            // 
            this.nghenghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nghenghiep.DataPropertyName = "nghenghiep";
            this.nghenghiep.HeaderText = "Nghề nghiệp";
            this.nghenghiep.Name = "nghenghiep";
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(337, 254);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(80, 32);
            this.btnAgree.TabIndex = 7;
            this.btnAgree.Text = "Agree";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(699, 454);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.grpHireCusInfo);
            this.Controls.Add(this.grpHireRoom);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lblChoseRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.FrmCheckOut_Load);
            this.grpHireRoom.ResumeLayout(false);
            this.grpHireRoom.PerformLayout();
            this.grpHireCusInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCusHireInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoseRoom;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.GroupBox grpHireRoom;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.GroupBox grpHireCusInfo;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.DataGridView grdCusHireInfo;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}