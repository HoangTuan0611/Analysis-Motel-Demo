﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPT_BUS;

namespace QLPT
{
    public partial class FrmCheckOut : Form
    {
        BUS_traphong bus = new BUS_traphong();
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            cboRoom.DataSource = bus.LayThongtinmapt(" where trangthai ='Đang cho thuê'");
            cboRoom.ValueMember = "mapt";
            cboRoom.DisplayMember = "mapt";
            if (cboRoom != null)
            {
                txtRoomName.Text = bus.getvalue("tenphong","'"+cboRoom.Text+"'");
                txtRoomID.Text = bus.getvalue("mapt","'"+cboRoom.Text+"'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='"+txtRoomID.Text+"'");
            }
        }

        

        private void cboRoom_TextChanged(object sender, EventArgs e)
        {
            txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
            txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
            dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtRoomID.Text + "'");
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            bus.Xoa("'"+txtRoomID.Text+"'");
            bus.updatetrangthaiphongtro2("'" + txtRoomID.Text + "'");
            cboRoom.DataSource = bus.LayThongtinmapt(" where trangthai ='Đang cho thuê'");
            cboRoom.ValueMember = "mapt";
            cboRoom.DisplayMember = "mapt";
            if (cboRoom != null)
            {
                txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
                txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
                dgthongtinkhachthue.DataSource = bus.TaoBang("where mapt='" + txtRoomID.Text + "'");
            }
        }
    }
}