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
            sql.cmbx("select id,namekh from academic", cmb_academic,"id", "namekh");
            sql.cmbx("select id,namekh from batch", cmb_batch, "id", "namekh");
            sql.cmbx("select id,namekh from department", cmb_Department, "id", "namekh");
            sql.cmbx("select id,namekh from level", cmb_level, "id", "namekh");
            sql.cmbx("select id,namekh from subject", cmb_subject, "id", "namekh");
            sql.cmbx("select id,namekh from specialty", cmb_specialty, "id", "namekh");
            sql.cmbx("select id,namekh from semester", cmb_semester, "id", "namekh");
            sql.cmbx("select id,namekh from year", cmb_year, "id", "namekh");
            //sql.retriev_score("select namekh,nameen,gender,dob from DATA where specialty = N'"+ cmb_specialty.SelectedValue + "' And level =N'" + cmb_level.SelectedValue + "'  ", dgv_Data);
            dgv_Data.Columns["score"].DefaultCellStyle.NullValue = "0.00";
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
                    //    }
                    //}
                }





            }

            }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Data.Rows)
            {
                // ADD SQL PARAMS & RUN THE COMMAND
                sql.AddParam("@id", row.Cells["namekh"].Value);
                sql.AddParam("@academic", cmb_academic.Text);
                sql.AddParam("@year", cmb_year.Text);
                sql.AddParam("@semester", cmb_semester.Text);
                sql.AddParam("@level", cmb_level.Text);
                sql.AddParam("@specialty", cmb_specialty.Text);
                sql.AddParam("@department", cmb_Department.Text);
                sql.AddParam("@subject", cmb_subject.Text);

                sql.AddParam("@mark", row.Cells["score"].Value);

                //Execute Quey
                sql.ExecQuery("Insert Into tbl_score(id,academic,year,semester,level,specialty,department,subject,score) Values(@id,@academic,@year,@semester,@level,@specialty,@department,@subject,@mark)", true);
                
            }
            MessageBox.Show("suucess");
            //REPORT & ABORT ON ERRORS
            if (sql.HasException(true))
            {
                return;
            }


        }

        private void cmb_specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sql.retrieve("select namekh,nameen,gender,dob from DATA where specialty = N'" + cmb_specialty.Text + "' ", dgv_Data);
        }
    }
}
