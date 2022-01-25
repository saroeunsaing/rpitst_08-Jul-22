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
            sql.cmbx("select id,nameen from tbl_academic",cmb_academic,"id","nameen");

        }
    }
}
