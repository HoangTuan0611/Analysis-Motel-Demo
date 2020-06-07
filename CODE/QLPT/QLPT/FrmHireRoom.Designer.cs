namespace QLPT
{
    partial class FrmHireRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHireRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEmptyRoom = new System.Windows.Forms.CheckBox();
            this.lblCurrentSlot = new System.Windows.Forms.Label();
            this.lblMaxSlot = new System.Windows.Forms.Label();
            this.txtCurrentSlot = new System.Windows.Forms.TextBox();
            this.txtMaxSlot = new System.Windows.Forms.TextBox();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.cboRoomID = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtIdenCard = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblIdenCard = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdCustomer = new System.Windows.Forms.DataGridView();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkEmptyRoom);
            this.panel1.Controls.Add(this.lblCurrentSlot);
            this.panel1.Controls.Add(this.lblMaxSlot);
            this.panel1.Controls.Add(this.txtCurrentSlot);
            this.panel1.Controls.Add(this.txtMaxSlot);
            this.panel1.Controls.Add(this.optFemale);
            this.panel1.Controls.Add(this.optMale);
            this.panel1.Controls.Add(this.cboRoomID);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.txtIdenCard);
            this.panel1.Controls.Add(this.txtCusName);
            this.panel1.Controls.Add(this.txtCusID);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblJob);
            this.panel1.Controls.Add(this.lblSex);
            this.panel1.Controls.Add(this.lblIdenCard);
            this.panel1.Controls.Add(this.lblCusName);
            this.panel1.Controls.Add(this.lblRoomID);
            this.panel1.Controls.Add(this.lblCusID);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 122);
            this.panel1.TabIndex = 7;
            // 
            // chkEmptyRoom
            // 
            this.chkEmptyRoom.AutoSize = true;
            this.chkEmptyRoom.Location = new System.Drawing.Point(206, 56);
            this.chkEmptyRoom.Name = "chkEmptyRoom";
            this.chkEmptyRoom.Size = new System.Drawing.Size(86, 17);
            this.chkEmptyRoom.TabIndex = 19;
            this.chkEmptyRoom.Text = "Empty Room";
            this.chkEmptyRoom.UseVisualStyleBackColor = true;
            this.chkEmptyRoom.CheckedChanged += new System.EventHandler(this.ChkEmptyRoom_CheckedChanged);
            // 
            // lblCurrentSlot
            // 
            this.lblCurrentSlot.AutoSize = true;
            this.lblCurrentSlot.Location = new System.Drawing.Point(572, 87);
            this.lblCurrentSlot.Name = "lblCurrentSlot";
            this.lblCurrentSlot.Size = new System.Drawing.Size(62, 13);
            this.lblCurrentSlot.TabIndex = 18;
            this.lblCurrentSlot.Text = "Current Slot";
            // 
            // lblMaxSlot
            // 
            this.lblMaxSlot.AutoSize = true;
            this.lblMaxSlot.Location = new System.Drawing.Point(330, 87);
            this.lblMaxSlot.Name = "lblMaxSlot";
            this.lblMaxSlot.Size = new System.Drawing.Size(48, 13);
            this.lblMaxSlot.TabIndex = 17;
            this.lblMaxSlot.Text = "Max Slot";
            // 
            // txtCurrentSlot
            // 
            this.txtCurrentSlot.Enabled = false;
            this.txtCurrentSlot.Location = new System.Drawing.Point(659, 84);
            this.txtCurrentSlot.Name = "txtCurrentSlot";
            this.txtCurrentSlot.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentSlot.TabIndex = 16;
            // 
            // txtMaxSlot
            // 
            this.txtMaxSlot.Enabled = false;
            this.txtMaxSlot.Location = new System.Drawing.Point(390, 84);
            this.txtMaxSlot.Name = "txtMaxSlot";
            this.txtMaxSlot.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSlot.TabIndex = 15;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(455, 51);
            this.optFemale.Margin = new System.Windows.Forms.Padding(2);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(59, 17);
            this.optFemale.TabIndex = 14;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Female";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(388, 51);
            this.optMale.Margin = new System.Windows.Forms.Padding(2);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(48, 17);
            this.optMale.TabIndex = 13;
            this.optMale.TabStop = true;
            this.optMale.Text = "Male";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // cboRoomID
            // 
            this.cboRoomID.FormattingEnabled = true;
            this.cboRoomID.Location = new System.Drawing.Point(109, 52);
            this.cboRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.cboRoomID.Name = "cboRoomID";
            this.cboRoomID.Size = new System.Drawing.Size(92, 21);
            this.cboRoomID.TabIndex = 12;
            this.cboRoomID.TextChanged += new System.EventHandler(this.CboRoomID_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(659, 52);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(162, 20);
            this.txtPhoneNumber.TabIndex = 11;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtPhoneNumber_Leave);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(659, 20);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(162, 20);
            this.txtJob.TabIndex = 10;
            this.txtJob.TextChanged += new System.EventHandler(this.txtJob_TextChanged);
            // 
            // txtIdenCard
            // 
            this.txtIdenCard.Location = new System.Drawing.Point(422, 17);
            this.txtIdenCard.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdenCard.Name = "txtIdenCard";
            this.txtIdenCard.Size = new System.Drawing.Size(128, 20);
            this.txtIdenCard.TabIndex = 9;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(120, 87);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(182, 20);
            this.txtCusName.TabIndex = 8;
            this.txtCusName.TextChanged += new System.EventHandler(this.txtCusName_TextChanged);
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(109, 20);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(93, 20);
            this.txtCusID.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(572, 54);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(572, 22);
            this.lblJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(326, 54);
            this.lblSex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(25, 13);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "Sex";
            // 
            // lblIdenCard
            // 
            this.lblIdenCard.AutoSize = true;
            this.lblIdenCard.Location = new System.Drawing.Point(326, 22);
            this.lblIdenCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdenCard.Name = "lblIdenCard";
            this.lblIdenCard.Size = new System.Drawing.Size(92, 13);
            this.lblIdenCard.TabIndex = 3;
            this.lblIdenCard.Text = "Identification Card";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(34, 91);
            this.lblCusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(82, 13);
            this.lblCusName.TabIndex = 2;
            this.lblCusName.Text = "Customer Name";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(33, 54);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 1;
            this.lblRoomID.Text = "Room ID";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(34, 17);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(65, 13);
            this.lblCusID.TabIndex = 0;
            this.lblCusID.Text = "Customer ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(4, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 37);
            this.panel2.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(646, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(540, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(432, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCustomer);
            this.groupBox1.Location = new System.Drawing.Point(2, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(937, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // grdCustomer
            // 
            this.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makt,
            this.mapt,
            this.hoten,
            this.cmnd,
            this.gioitinh,
            this.nghenghiep,
            this.sdt});
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.Location = new System.Drawing.Point(2, 15);
            this.grdCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.Size = new System.Drawing.Size(933, 255);
            this.grdCustomer.TabIndex = 0;
            this.grdCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomer_CellClick);
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
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            // 
            // Frmkhachtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(946, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Frmkhachtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hire Room";
            this.Load += new System.EventHandler(this.FrmHireRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.ComboBox cboRoomID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtIdenCard;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblIdenCard;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Label lblCurrentSlot;
        private System.Windows.Forms.Label lblMaxSlot;
        private System.Windows.Forms.TextBox txtCurrentSlot;
        private System.Windows.Forms.TextBox txtMaxSlot;
        private System.Windows.Forms.CheckBox chkEmptyRoom;
        private System.Windows.Forms.Button btnCancel;
    }
}