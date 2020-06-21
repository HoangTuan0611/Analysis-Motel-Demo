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
            ReportDocument myReportDocument;
            myReportDocument = new ReportDocument();
            myReportDocument.Load(@"D:\project\Analysis-Motel-Demo\CODE\QLPT\QLPT\rptTienPhong.rpt");

        }
    }
}
