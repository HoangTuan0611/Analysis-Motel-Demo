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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbemptyroom = new System.Windows.Forms.CheckBox();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.cbcus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdContract = new System.Windows.Forms.DataGridView();
            this.mathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(987, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckbemptyroom);
            this.panel1.Controls.Add(this.dtto);
            this.panel1.Controls.Add(this.dtfrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbroom);
            this.panel1.Controls.Add(this.cbcus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcon);
            this.panel1.Controls.Add(this.lblCusName);
            this.panel1.Controls.Add(this.lblCusID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 132);
            this.panel1.TabIndex = 8;
            // 
            // ckbemptyroom
            // 
            this.ckbemptyroom.AutoSize = true;
            this.ckbemptyroom.Location = new System.Drawing.Point(588, 75);
            this.ckbemptyroom.Name = "ckbemptyroom";
            this.ckbemptyroom.Size = new System.Drawing.Size(110, 21);
            this.ckbemptyroom.TabIndex = 27;
            this.ckbemptyroom.Text = "Empty Room";
            this.ckbemptyroom.UseVisualStyleBackColor = true;
            this.ckbemptyroom.CheckedChanged += new System.EventHandler(this.ckbemptyroom_CheckedChanged);
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(122, 94);
            this.dtto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(200, 22);
            this.dtto.TabIndex = 26;
            this.dtto.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(122, 59);
            this.dtfrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 22);
            this.dtfrom.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // cbroom
            // 
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(448, 73);
            this.cbroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(121, 24);
            this.cbroom.TabIndex = 22;
            this.cbroom.TextChanged += new System.EventHandler(this.cbroom_TextChanged);
            // 
            // cbcus
            // 
            this.cbcus.FormattingEnabled = true;
            this.cbcus.Location = new System.Drawing.Point(448, 15);
            this.cbcus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcus.Name = "cbcus";
            this.cbcus.Size = new System.Drawing.Size(121, 24);
            this.cbcus.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contract ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(122, 18);
            this.txtcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(123, 22);
            this.txtcon.TabIndex = 19;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(345, 76);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(62, 17);
            this.lblCusName.TabIndex = 2;
            this.lblCusName.Text = "Room ID";
            this.lblCusName.Click += new System.EventHandler(this.lblCusName_Click);
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(345, 22);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(85, 17);
            this.lblCusID.TabIndex = 0;
            this.lblCusID.Text = "Customer ID";
            this.lblCusID.Click += new System.EventHandler(this.lblCusID_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdContract);
            this.groupBox2.Location = new System.Drawing.Point(3, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(987, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hợp đồng";
            // 
            // grdContract
            // 
            this.grdContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathue,
            this.makt,
            this.mapt,
            this.ngaybd,
            this.ngaykt});
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdContract.Name = "grdContract";
            this.grdContract.RowTemplate.Height = 24;
            this.grdContract.Size = new System.Drawing.Size(981, 269);
            this.grdContract.TabIndex = 0;
            this.grdContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContract_CellClick);
            // 
            // mathue
            // 
            this.mathue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mathue.DataPropertyName = "mathue";
            this.mathue.DividerWidth = 1;
            this.mathue.HeaderText = "Contract ID";
            this.mathue.Name = "mathue";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCheckout);
            this.groupBox3.Controls.Add(this.btncancel);
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Location = new System.Drawing.Point(5, 165);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(981, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(550, 22);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(431, 22);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(311, 22);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // FrmHireRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 527);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHireRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hire Room";
            this.Load += new System.EventHandler(this.FrmHireRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.ComboBox cbcus;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdContract;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn makt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
        private System.Windows.Forms.CheckBox ckbemptyroom;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnCheckout;
    }
}