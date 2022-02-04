using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPITST.Forms
{
    public partial class Frm_RptERL : Form
    {
        SQL_Control sql = new SQL_Control();
        public Frm_RptERL()
        {
            InitializeComponent();
        }

        private void Frm_ERL_Load(object sender, EventArgs e)
        {
            DataView dview = new DataView();
            dview.Table = sql.LoadReport("select * from score where specialty = N'acc' and year = 1","score").Tables["score"];

            Reports.CR_ERL myreport = new Reports.CR_ERL();
            myreport.SetDataSource(dview);
            crystalReportViewer1.ReportSource = myreport;
            //_ = crystalReportViewer1.DataBindings;
        }
    }
}
