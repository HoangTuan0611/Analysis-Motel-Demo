using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QLPT
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = "Data Source=DESKTOP-8I4FATD;Initial Catalog = DataQLPT; " + "Integrated Security = true; ";
            con.Open();

            cmd = new SqlCommand("select * from thutien", con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds, "thutien");

            ReportDocument reportDocument1 = new ReportDocument();
            reportDocument1.Load(@"D:\Githud\Analysis-Motel-Demo\CODE\QLPT\QLPT\rptReceipt.rpt");

            reportDocument1.SetDataSource(ds.Tables["thutien"]);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ReportSource=reportDocument1;

        }
    }
    
}
