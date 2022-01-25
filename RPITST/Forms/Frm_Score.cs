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
    public partial class Frm_Score : Form
    {
        SQL_Control sql = new SQL_Control();

        public Frm_Score()
        {
            InitializeComponent();
        }

        private void Frm_Score_Load(object sender, EventArgs e)
        {
            CueBannerText.SetCueText(cmb_academic, "ជ្រើសរើសឆ្នាំសិក្សា");
            CueBannerText.SetCueText(cmb_batch, "ជ្រើសរើសជំនាន់");
            CueBannerText.SetCueText(cmb_Department, "ជ្រើសរើសដេប៉ាតឺម៉ង់");
            CueBannerText.SetCueText(cmb_level, "ជ្រើសរើសកម្រិត");
            CueBannerText.SetCueText(cmb_specialty, "ជ្រើសរើសជំនាញ");
            CueBannerText.SetCueText(cmb_subject, "ជ្រើសរើសមុខវិជ្ជា");
            CueBannerText.SetCueText(cmb_semester, "ជ្រើសរើសឆមាស");
            CueBannerText.SetCueText(cmb_year, "ជ្រើសរើសឆមាស");
            sql.cmbx("select id,nameen from academic",cmb_academic,"id","nameen");
            sql.cmbx("select id,nameen from batch", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from department", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from level", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from subject", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from specialty", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from semester", cmb_academic, "id", "nameen");
            sql.cmbx("select id,nameen from year", cmb_academic, "id", "nameen");

            sql.retrive("select namekh,nameen,genderen,doben from oregin", dgv_Data);
        }

        private void dgv_Data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dgv_Data.Columns["score"].Index) //this is our numeric column
            {
                float i;
                if (!float.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("must be numeric");
                    //ref: https://www.daniweb.com/programming/software-development/threads/226941/enter-only-number-in-datagridview
                }
            }
        }
    }
}
