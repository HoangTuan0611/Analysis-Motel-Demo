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
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgree = new System.Windows.Forms.Button();
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
            this.grdCusHireInfo.AllowUserToOrderColumns = true;
            this.grdCusHireInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCusHireInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapt,
            this.tenphong,
            this.tang,
            this.loai,
            this.sltoida,
            this.trangthai});
            this.grdCusHireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCusHireInfo.Location = new System.Drawing.Point(2, 15);
            this.grdCusHireInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grdCusHireInfo.Name = "grdCusHireInfo";
            this.grdCusHireInfo.RowTemplate.Height = 24;
            this.grdCusHireInfo.Size = new System.Drawing.Size(675, 133);
            this.grdCusHireInfo.TabIndex = 0;
            // 
            // mapt
            // 
            this.mapt.DataPropertyName = "mapt";
            this.mapt.HeaderText = "Room ID";
            this.mapt.Name = "mapt";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Name";
            this.tenphong.Name = "tenphong";
            // 
            // tang
            // 
            this.tang.DataPropertyName = "tang";
            this.tang.HeaderText = "Floor";
            this.tang.Name = "tang";
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Type";
            this.loai.Name = "loai";
            // 
            // sltoida
            // 
            this.sltoida.DataPropertyName = "sltoida";
            this.sltoida.HeaderText = "Max";
            this.sltoida.Name = "sltoida";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Status";
            this.trangthai.Name = "trangthai";
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
            this.Controls.Add(this.cboRoom);
            this.Controls.Add(this.lblChoseRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.FrmCheckOut_Load);
            this.grpHireCusInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCusHireInfo)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
    }
}