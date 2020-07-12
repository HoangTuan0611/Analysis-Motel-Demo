namespace QLPT
{
    partial class FrmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceipt));
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgthongtinkhachthue = new System.Windows.Forms.DataGridView();
            this.grpHireInfo = new System.Windows.Forms.GroupBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.lblfloor = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.cboChoseRoom = new System.Windows.Forms.ComboBox();
            this.lblChoseRoom = new System.Windows.Forms.Label();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.txtParking = new System.Windows.Forms.TextBox();
            this.lblParking = new System.Windows.Forms.Label();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblVND = new System.Windows.Forms.Label();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtElecMoney = new System.Windows.Forms.TextBox();
            this.txtRoomMoney = new System.Windows.Forms.TextBox();
            this.txtElec = new System.Windows.Forms.TextBox();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblElecMoney = new System.Windows.Forms.Label();
            this.lblRoomMoney = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblElec = new System.Windows.Forms.Label();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).BeginInit();
            this.grpHireInfo.SuspendLayout();
            this.grpServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(201, 246);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(80, 32);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Payment";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgthongtinkhachthue);
            this.groupBox3.Location = new System.Drawing.Point(11, 284);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(811, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Info";
            // 
            // dgthongtinkhachthue
            // 
            this.dgthongtinkhachthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgthongtinkhachthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makt,
            this.mapt,
            this.hoten,
            this.cmnd,
            this.gioitinh,
            this.nghenghiep,
            this.sdt});
            this.dgthongtinkhachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgthongtinkhachthue.Location = new System.Drawing.Point(2, 15);
            this.dgthongtinkhachthue.Margin = new System.Windows.Forms.Padding(2);
            this.dgthongtinkhachthue.Name = "dgthongtinkhachthue";
            this.dgthongtinkhachthue.Size = new System.Drawing.Size(807, 133);
            this.dgthongtinkhachthue.TabIndex = 0;
            // 
            // grpHireInfo
            // 
            this.grpHireInfo.Controls.Add(this.txtType);
            this.grpHireInfo.Controls.Add(this.lbltype);
            this.grpHireInfo.Controls.Add(this.txtFloor);
            this.grpHireInfo.Controls.Add(this.lblfloor);
            this.grpHireInfo.Controls.Add(this.txtRoomName);
            this.grpHireInfo.Controls.Add(this.txtRoomID);
            this.grpHireInfo.Controls.Add(this.lblRoomID);
            this.grpHireInfo.Controls.Add(this.lblCusID);
            this.grpHireInfo.Enabled = false;
            this.grpHireInfo.Location = new System.Drawing.Point(11, 106);
            this.grpHireInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpHireInfo.Name = "grpHireInfo";
            this.grpHireInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpHireInfo.Size = new System.Drawing.Size(389, 126);
            this.grpHireInfo.TabIndex = 12;
            this.grpHireInfo.TabStop = false;
            this.grpHireInfo.Text = "Hire Room Info";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(301, 64);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(83, 20);
            this.txtType.TabIndex = 7;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(237, 67);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 6;
            this.lbltype.Text = "Type";
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(301, 34);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(83, 20);
            this.txtFloor.TabIndex = 5;
            // 
            // lblfloor
            // 
            this.lblfloor.AutoSize = true;
            this.lblfloor.Location = new System.Drawing.Point(237, 37);
            this.lblfloor.Name = "lblfloor";
            this.lblfloor.Size = new System.Drawing.Size(30, 13);
            this.lblfloor.TabIndex = 4;
            this.lblfloor.Text = "Floor";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(79, 64);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(126, 20);
            this.txtRoomName.TabIndex = 3;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(79, 31);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(76, 20);
            this.txtRoomID.TabIndex = 2;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(7, 64);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 1;
            this.lblRoomID.Text = "Room ID";
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(7, 31);
            this.lblCusID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(35, 13);
            this.lblCusID.TabIndex = 0;
            this.lblCusID.Text = "Name";
            // 
            // cboChoseRoom
            // 
            this.cboChoseRoom.FormattingEnabled = true;
            this.cboChoseRoom.Location = new System.Drawing.Point(123, 49);
            this.cboChoseRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cboChoseRoom.Name = "cboChoseRoom";
            this.cboChoseRoom.Size = new System.Drawing.Size(116, 21);
            this.cboChoseRoom.TabIndex = 10;
            this.cboChoseRoom.TextChanged += new System.EventHandler(this.cboChoseRoom_TextChanged);
            // 
            // lblChoseRoom
            // 
            this.lblChoseRoom.AutoSize = true;
            this.lblChoseRoom.Location = new System.Drawing.Point(18, 51);
            this.lblChoseRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoseRoom.Name = "lblChoseRoom";
            this.lblChoseRoom.Size = new System.Drawing.Size(101, 13);
            this.lblChoseRoom.TabIndex = 8;
            this.lblChoseRoom.Text = "Chose HireRoom ID";
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Location = new System.Drawing.Point(452, 51);
            this.lblReceiptDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(30, 13);
            this.lblReceiptDate.TabIndex = 16;
            this.lblReceiptDate.Text = "Date";
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReceiptDate.Location = new System.Drawing.Point(506, 49);
            this.dtpReceiptDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(188, 20);
            this.dtpReceiptDate.TabIndex = 17;
            this.dtpReceiptDate.ValueChanged += new System.EventHandler(this.dtpReceiptDate_ValueChanged);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.txtParking);
            this.grpServices.Controls.Add(this.lblParking);
            this.grpServices.Controls.Add(this.txtVehicle);
            this.grpServices.Controls.Add(this.lblVehicle);
            this.grpServices.Controls.Add(this.txtTotal);
            this.grpServices.Controls.Add(this.lblVND);
            this.grpServices.Controls.Add(this.txtInternet);
            this.grpServices.Controls.Add(this.txtWater);
            this.grpServices.Controls.Add(this.txtElecMoney);
            this.grpServices.Controls.Add(this.txtRoomMoney);
            this.grpServices.Controls.Add(this.txtElec);
            this.grpServices.Controls.Add(this.lblInternet);
            this.grpServices.Controls.Add(this.lblWater);
            this.grpServices.Controls.Add(this.lblElecMoney);
            this.grpServices.Controls.Add(this.lblRoomMoney);
            this.grpServices.Controls.Add(this.lbltotal);
            this.grpServices.Controls.Add(this.lblElec);
            this.grpServices.Location = new System.Drawing.Point(455, 106);
            this.grpServices.Margin = new System.Windows.Forms.Padding(2);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(2);
            this.grpServices.Size = new System.Drawing.Size(367, 173);
            this.grpServices.TabIndex = 18;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Services";
            // 
            // txtParking
            // 
            this.txtParking.Enabled = false;
            this.txtParking.Location = new System.Drawing.Point(96, 77);
            this.txtParking.Name = "txtParking";
            this.txtParking.Size = new System.Drawing.Size(56, 20);
            this.txtParking.TabIndex = 29;
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Location = new System.Drawing.Point(13, 82);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(80, 13);
            this.lblParking.TabIndex = 28;
            this.lblParking.Text = "Parking Charge";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(96, 51);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(33, 20);
            this.txtVehicle.TabIndex = 27;
            this.txtVehicle.TextChanged += new System.EventHandler(this.txtVehicle_TextChanged);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(13, 56);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(42, 13);
            this.lblVehicle.TabIndex = 26;
            this.lblVehicle.Text = "Vehicle";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(247, 125);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(59, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(321, 134);
            this.lblVND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(30, 13);
            this.lblVND.TabIndex = 24;
            this.lblVND.Text = "VND";
            // 
            // txtInternet
            // 
            this.txtInternet.Enabled = false;
            this.txtInternet.Location = new System.Drawing.Point(247, 101);
            this.txtInternet.Margin = new System.Windows.Forms.Padding(2);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(70, 20);
            this.txtInternet.TabIndex = 23;
            // 
            // txtWater
            // 
            this.txtWater.Enabled = false;
            this.txtWater.Location = new System.Drawing.Point(247, 73);
            this.txtWater.Margin = new System.Windows.Forms.Padding(2);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(70, 20);
            this.txtWater.TabIndex = 22;
            // 
            // txtElecMoney
            // 
            this.txtElecMoney.Enabled = false;
            this.txtElecMoney.Location = new System.Drawing.Point(247, 49);
            this.txtElecMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtElecMoney.Name = "txtElecMoney";
            this.txtElecMoney.Size = new System.Drawing.Size(70, 20);
            this.txtElecMoney.TabIndex = 21;
            // 
            // txtRoomMoney
            // 
            this.txtRoomMoney.Enabled = false;
            this.txtRoomMoney.Location = new System.Drawing.Point(247, 24);
            this.txtRoomMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomMoney.Name = "txtRoomMoney";
            this.txtRoomMoney.Size = new System.Drawing.Size(70, 20);
            this.txtRoomMoney.TabIndex = 20;
            // 
            // txtElec
            // 
            this.txtElec.Location = new System.Drawing.Point(96, 28);
            this.txtElec.Margin = new System.Windows.Forms.Padding(2);
            this.txtElec.Name = "txtElec";
            this.txtElec.Size = new System.Drawing.Size(33, 20);
            this.txtElec.TabIndex = 18;
            this.txtElec.TextChanged += new System.EventHandler(this.txtElec_TextChanged);
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Location = new System.Drawing.Point(166, 104);
            this.lblInternet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(43, 13);
            this.lblInternet.TabIndex = 17;
            this.lblInternet.Text = "Internet";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Location = new System.Drawing.Point(166, 84);
            this.lblWater.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(36, 13);
            this.lblWater.TabIndex = 16;
            this.lblWater.Text = "Water";
            // 
            // lblElecMoney
            // 
            this.lblElecMoney.AutoSize = true;
            this.lblElecMoney.Location = new System.Drawing.Point(166, 60);
            this.lblElecMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElecMoney.Name = "lblElecMoney";
            this.lblElecMoney.Size = new System.Drawing.Size(65, 13);
            this.lblElecMoney.TabIndex = 15;
            this.lblElecMoney.Text = "Elec Charge";
            // 
            // lblRoomMoney
            // 
            this.lblRoomMoney.AutoSize = true;
            this.lblRoomMoney.Location = new System.Drawing.Point(166, 31);
            this.lblRoomMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomMoney.Name = "lblRoomMoney";
            this.lblRoomMoney.Size = new System.Drawing.Size(72, 13);
            this.lblRoomMoney.TabIndex = 14;
            this.lblRoomMoney.Text = "Room Charge";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(166, 128);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Total";
            // 
            // lblElec
            // 
            this.lblElec.AutoSize = true;
            this.lblElec.Location = new System.Drawing.Point(13, 31);
            this.lblElec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElec.Name = "lblElec";
            this.lblElec.Size = new System.Drawing.Size(60, 13);
            this.lblElec.TabIndex = 10;
            this.lblElec.Text = "Elec (kWh)";
            // 
            // makt
            // 
            this.makt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makt.DataPropertyName = "makt";
            this.makt.HeaderText = "Customer ID";
            this.makt.Name = "makt";
            // 
            // mapt
            // 
            this.mapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Room ID";
            this.mapt.Name = "mapt";
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Name";
            this.hoten.Name = "hoten";
            // 
            // cmnd
            // 
            this.cmnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnd.DataPropertyName = "cmnd";
            this.cmnd.HeaderText = "Identification Card";
            this.cmnd.Name = "cmnd";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Sex";
            this.gioitinh.Name = "gioitinh";
            // 
            // nghenghiep
            // 
            this.nghenghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nghenghiep.DataPropertyName = "nghenghiep";
            this.nghenghiep.HeaderText = "Job";
            this.nghenghiep.Name = "nghenghiep";
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Phone Number";
            this.sdt.Name = "sdt";
            // 
            // FrmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(842, 465);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.lblReceiptDate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpHireInfo);
            this.Controls.Add(this.cboChoseRoom);
            this.Controls.Add(this.lblChoseRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.FrmReceipt_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgthongtinkhachthue)).EndInit();
            this.grpHireInfo.ResumeLayout(false);
            this.grpHireInfo.PerformLayout();
            this.grpServices.ResumeLayout(false);
            this.grpServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgthongtinkhachthue;
        private System.Windows.Forms.GroupBox grpHireInfo;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.ComboBox cboChoseRoom;
        private System.Windows.Forms.Label lblChoseRoom;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtElecMoney;
        private System.Windows.Forms.TextBox txtRoomMoney;
        private System.Windows.Forms.TextBox txtElec;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblElecMoney;
        private System.Windows.Forms.Label lblRoomMoney;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblElec;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label lblfloor;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txtParking;
        private System.Windows.Forms.Label lblParking;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}