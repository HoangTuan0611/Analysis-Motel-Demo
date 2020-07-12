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
            this.grpHireCusInfo = new System.Windows.Forms.GroupBox();
            this.grdCusHireInfo = new System.Windows.Forms.DataGridView();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sltoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgree = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdContract = new System.Windows.Forms.DataGridView();
            this.mathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpHireCusInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCusHireInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChoseRoom
            // 
            this.lblChoseRoom.AutoSize = true;
            this.lblChoseRoom.Location = new System.Drawing.Point(79, 82);
            this.lblChoseRoom.Name = "lblChoseRoom";
            this.lblChoseRoom.Size = new System.Drawing.Size(89, 17);
            this.lblChoseRoom.TabIndex = 0;
            this.lblChoseRoom.Text = "Chose Room";
            // 
            // cboRoom
            // 
            this.cboRoom.DisplayMember = "mapt";
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(198, 79);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(153, 24);
            this.cboRoom.TabIndex = 2;
            this.cboRoom.TextChanged += new System.EventHandler(this.cboRoom_TextChanged);
            // 
            // grpHireCusInfo
            // 
            this.grpHireCusInfo.Controls.Add(this.grdContract);
            this.grpHireCusInfo.Controls.Add(this.grdCusHireInfo);
            this.grpHireCusInfo.Location = new System.Drawing.Point(12, 366);
            this.grpHireCusInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpHireCusInfo.Name = "grpHireCusInfo";
            this.grpHireCusInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpHireCusInfo.Size = new System.Drawing.Size(905, 185);
            this.grpHireCusInfo.TabIndex = 6;
            this.grpHireCusInfo.TabStop = false;
            this.grpHireCusInfo.Text = "Contract  Info";
            // 
            // grdCusHireInfo
            // 
            this.grdCusHireInfo.AllowUserToOrderColumns = true;
            this.grdCusHireInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCusHireInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapt,
            this.tenphong,
            this.tang,
            this.loai,
            this.sltoida});
            this.grdCusHireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCusHireInfo.Location = new System.Drawing.Point(3, 17);
            this.grdCusHireInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdCusHireInfo.Name = "grdCusHireInfo";
            this.grdCusHireInfo.RowTemplate.Height = 24;
            this.grdCusHireInfo.Size = new System.Drawing.Size(899, 166);
            this.grdCusHireInfo.TabIndex = 0;
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mathue";
            this.mapt.HeaderText = "Contract ID";
            this.mapt.Name = "mapt";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "makt";
            this.tenphong.HeaderText = "Customer ID";
            this.tenphong.Name = "tenphong";
            // 
            // tang
            // 
            this.tang.DataPropertyName = "mapt";
            this.tang.HeaderText = "Room ID";
            this.tang.Name = "tang";
            // 
            // loai
            // 
            this.loai.DataPropertyName = "ngaybd";
            this.loai.HeaderText = "Date From";
            this.loai.Name = "loai";
            // 
            // sltoida
            // 
            this.sltoida.DataPropertyName = "ngaykt";
            this.sltoida.HeaderText = "Date To";
            this.sltoida.Name = "sltoida";
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(449, 313);
            this.btnAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(107, 39);
            this.btnAgree.TabIndex = 7;
            this.btnAgree.Text = "Agree";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(68, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(790, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Info";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(536, 62);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 22);
            this.txtRoomName.TabIndex = 3;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(233, 62);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 22);
            this.txtRoomID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room ID";
            // 
            // grdContract
            // 
            this.grdContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathue,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ngaybd,
            this.ngaykt});
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdContract.Name = "grdContract";
            this.grdContract.RowTemplate.Height = 24;
            this.grdContract.Size = new System.Drawing.Size(899, 166);
            this.grdContract.TabIndex = 3;
            // 
            // mathue
            // 
            this.mathue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathue.DataPropertyName = "mathue";
            this.mathue.DividerWidth = 1;
            this.mathue.HeaderText = "Contract ID";
            this.mathue.Name = "mathue";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "makt";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mapt";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ngaybd
            // 
            this.ngaybd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaybd.DataPropertyName = "ngaybd";
            this.ngaybd.HeaderText = "Ngày bắt đầu";
            this.ngaybd.Name = "ngaybd";
            // 
            // ngaykt
            // 
            this.ngaykt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaykt.DataPropertyName = "ngaykt";
            this.ngaykt.HeaderText = "Ngày kết thúc";
            this.ngaykt.Name = "ngaykt";
            // 
            // FrmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(932, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.grpHireCusInfo);
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lblChoseRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.FrmCheckOut_Load);
            this.grpHireCusInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCusHireInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoseRoom;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.GroupBox grpHireCusInfo;
        private System.Windows.Forms.DataGridView grdCusHireInfo;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn sltoida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
    }
}