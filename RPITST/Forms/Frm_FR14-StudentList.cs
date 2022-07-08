using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPITST;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace RPITST.Forms
{
    public partial class Frm_FR14_StudentList : Form
    {
        //variable declaration for get data from combobox into another form
        public static string levels = "";
        public static string specialty = "";
        public static string years = "";
        public static string batchs = "";
        public static string semesters = "";
        public static string academics = "";
        public static string e_days = "";
        public static string e_months = "";
        public static string e_years = "";

        SQL_Control sql = new SQL_Control();
        public Frm_FR14_StudentList()
        {
            InitializeComponent();
        }

        private void placeheader()
        {
            /*  call placeholder text from static class 'curebannertext' */
            CueBannerText.SetCueText(Cmb_Semester, "ជ្រើសរើសឆមាស");
            CueBannerText.SetCueText(Cmb_Level, "ជ្រើសរើសកម្រិតសិក្សា");
            CueBannerText.SetCueText(Cmb_Year, "រើសឆ្នាំ");
            CueBannerText.SetCueText(Cmb_Batch, "រើសជំនាន់");
        }
        private void gridviews()
        {
            /* load data with condition into datagridview */
            sql.Dgv_Score("SELECT id,namekh,nameen,gender,dob FROM registerkh where level = N'" + Cmb_Level.Text + "' and specialty = N'" + Cmb_Specialty.Text + "' and years = N'" + Cmb_Year.Text + "' ", Dgv_Data);

        }
        private void clear()
        {
            //foreach (DataGridViewRow row in Dgv_Data.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        cell.Value = "";
            //    }
            //}

            this.Cmb_Semester.DataSource = null;
            this.Cmb_Semester.Items.Clear();
            this.Cmb_Level.DataSource = null;
            this.Cmb_Level.Items.Clear();

            this.Cmb_Year.DataSource = null;
            this.Cmb_Year.Items.Clear();

            this.Cmb_Specialty.DataSource = null;
            this.Cmb_Specialty.Items.Clear();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {

            /* code for close button */
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {

            /* code for minimize button */
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            /* code for maximize button */
            btn_Restore.Visible = false;
            btn_Maximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            /* code for restore button */
            btn_Restore.Visible = true;
            btn_Maximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Cmb_Level_SelectedIndexChanged(object sender, EventArgs e)
        {

            /* clear combobox before load data again */
            this.Cmb_Specialty.DataSource = null;
            this.Cmb_Specialty.Items.Clear();

            /* load data to combobox with diplaymember and display values*/
            sql.cmbx("SELECT * FROM specialtys where level='" + Cmb_Level.SelectedValue + "'", Cmb_Specialty, "id", "namekh");
        }

        private void Cmb_Specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* clear combobox before load data again */
            this.Cmb_Year.DataSource = null;
            this.Cmb_Year.Items.Clear();

            /* load data to combobox with diplaymember and display values*/
            sql.cmbx("SELECT * FROM years_regkh where specialty=N'" + Cmb_Specialty.Text + "' and level =N'" + Cmb_Level.Text + "' ", Cmb_Year, "id", "years");
        }

        private void Cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* clear combobox before load data again */
            this.Cmb_Batch.DataSource = null;
            this.Cmb_Batch.Items.Clear();

            /* load data to combobox with diplaymember and display values*/
            sql.cmbx("SELECT * FROM years_regkh where  years=N'" + Cmb_Year.Text + "' and specialty=N'" + Cmb_Specialty.Text + "' and level =N'" + Cmb_Level.Text + "' ", Cmb_Batch, "batch_id", "batch");
        }

        private void Frm_FR14_StudentList_Load(object sender, EventArgs e)
        {
            /* set defualt text in textbox using properties */
            Txt_Days.Text = Properties.Settings.Default.DAYS;
            Txt_Months.Text = Properties.Settings.Default.MONTHS;
            Txt_Years.Text = Properties.Settings.Default.YEAR;

            /* display date time using minus 1 with now */
            int years = DateTime.Now.Year - 1;
            int next = DateTime.Now.Year;
            sql.cmbx("SELECT * FROM academics where nameen = '" + Convert.ToString(years) + "-" + Convert.ToString(next) + "'", Cmb_Academic, "id", "namekh");

            /* load data to combobox with diplaymember and display values*/
            sql.cmbx("SELECT * FROM levels", Cmb_Level, "id", "namekh");


        }
        public void dgv_headertext() { 

        /*datagridview header text */
            Dgv_Data.Columns[0].HeaderText = "កូដ";
            Dgv_Data.Columns[1].HeaderText = "គោត្តនាម នាម";
            Dgv_Data.Columns[2].HeaderText = "ជាឡាំង";
            Dgv_Data.Columns[3].HeaderText = "ភេទ";
            Dgv_Data.Columns[4].HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
          }

        private void Cmb_Level_DropDown(object sender, EventArgs e)
        {
        }

        private void Cmb_Semester_DropDown(object sender, EventArgs e)
        {
            /* load data to combobox with diplaymember and display values*/
            sql.cmbx("SELECT * FROM semesters", Cmb_Semester, "id", "namekh");
        }

        private void Btn_Search_Click(object sender, EventArgs e)

        {
            /* load datagridview data  */
            gridviews();

            /* sub for datagriview header text */
            dgv_headertext();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            /* the variable with pass value to another form using combobox */
            levels = Cmb_Level.Text;
            specialty = Cmb_Specialty.Text;
            years = Cmb_Year.Text;
            semesters = Cmb_Semester.Text;
            academics = Cmb_Academic.Text;
            batchs = Cmb_Batch.Text;
            e_days = Txt_Days.Text;
            e_months = Txt_Months.Text;
            e_years = Txt_Years.Text;

            // open another form 
            Frm_Rpt_FR14SSL frm = new Frm_Rpt_FR14SSL();
            frm.ShowDialog();
        }

        private void Frm_FR14_StudentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* assign new value to propertis setting */
            Properties.Settings.Default.DAYS = Txt_Days.Text;
            Properties.Settings.Default.MONTHS = Txt_Months.Text;
            Properties.Settings.Default.YEAR = Txt_Years.Text;
            Properties.Settings.Default.Save();
        }

        private void Cmb_Level_Click(object sender, EventArgs e)
        {
            //sql.cmbx("SELECT * FROM levels", Cmb_Level, "id", "nameen");
        }

        private void Cmb_Level_DragDrop(object sender, DragEventArgs e)
        {
            //sql.cmbx("SELECT * FROM levels", Cmb_Level, "id", "nameen");
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            /* add more row in datagridview */
            Dgv_Data.AllowUserToAddRows = true;
        }

        private void Dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_Data.AllowUserToAddRows = false;
        }
    }
}
