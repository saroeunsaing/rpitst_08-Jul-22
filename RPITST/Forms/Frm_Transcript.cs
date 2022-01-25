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

namespace RPITST.Forms
{
    public partial class Frm_Transcript : Form
    {
        public Frm_Transcript()
        {
            InitializeComponent();
        }

        private void Frm_Transcript_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;

            connectionString = "data source=rpitst;initial catalog=rpitst;user id=sa;password=123;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * from users";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
           DataSet_Data ds = new DataSet_Data();
            dscmd.Fill(ds, "Product");
            MessageBox.Show(ds.Tables[1].Rows.Count.ToString());
            cnn.Close();

            Reports.CR_Transcript objRpt = new Reports.CR_Transcript();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
