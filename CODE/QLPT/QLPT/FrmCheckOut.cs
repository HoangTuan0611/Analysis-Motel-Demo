using System;
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
        BUS_Checkout bus = new BUS_Checkout();
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            cboRoom.DataSource = bus.GetIDRoomInfo(" where trangthai ='hiring'");
            cboRoom.ValueMember = "mapt";
            cboRoom.DisplayMember = "mapt";
            if (cboRoom != null)
            {
                txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
                txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
                //grdCusHireInfo.DataSource = bus.CreateTable("where mapt='" + txtRoomID.Text + "'");
                grdContract.DataSource = bus.CreateTable("where mapt='" + cboRoom.Text + "'");
            }

            //cboRoom.DataSource = bus.GetIDHireRoomInfo("");
            //cboRoom.ValueMember = "mathue";
            //cboRoom.DisplayMember = "mathue";
            //if (cboRoom != null)
            //{
            //    txtRoomName.Text = bus.getvalue("makt", "'" + cboRoom.Text + "'");
            //    txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
            //    grdCusHireInfo.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'&&thuephong.mapt=phongtro.mapt");
            //}
        }

        

        private void cboRoom_TextChanged(object sender, EventArgs e)
        {
            txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
            txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
            //txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
            //txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
            grdContract.DataSource = bus.CreateTable("where mapt='" +cboRoom.Text +"'");
            //txtRoomName.Text = bus.getvalue("makt", "'" + cboRoom.Text + "'");
            //txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
            //grdCusHireInfo.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'");
            //grdCusHireInfo.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'&&thuephong.mapt=phongtro.mapt");
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            //bus.Delete("'"+txtRoomID.Text+"'");
            bus.UpdateRoomStatus("'" + cboRoom.Text + "'");
            cboRoom.DataSource = bus.GetIDRoomInfo(" where trangthai ='hiring'");
            //cboRoom.DataSource = bus.GetIDRoomInfo("");
            cboRoom.ValueMember = "mapt";
            cboRoom.DisplayMember = "mapt";
            if (cboRoom != null)
            {
                //txtRoomName.Text = bus.getvalue("tenphong", "'" + cboRoom.Text + "'");
                //txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
                grdCusHireInfo.DataSource = bus.CreateTable("where mapt='" + cboRoom.Text + "'");
                //txtRoomName.Text = bus.getvalue("makt", "'" + cboRoom.Text + "'");
                //txtRoomID.Text = bus.getvalue("mapt", "'" + cboRoom.Text + "'");
                //grdCusHireInfo.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'");
                //grdCusHireInfo.DataSource = bus.CreateTable("where mathue='" + txtRoomID.Text + "'&&thuephong.mapt=phongtro.mapt");
            }
        }
    }
}
