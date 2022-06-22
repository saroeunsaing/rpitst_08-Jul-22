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
    public partial class Frm_Examination : Form
    {
        SQL_Control sql = new SQL_Control();
        public Frm_Examination()
        {
            InitializeComponent();
        }

        private void placeheader()
        {
            CueBannerText.SetCueText(Cmb_Semester, "ជ្រើសរើសឆមាស");
            CueBannerText.SetCueText(Cmb_Level, "ជ្រើសរើសកម្រិតសិក្សា");
            CueBannerText.SetCueText(Cmb_Year, "រើសឆ្នាំ");
            CueBannerText.SetCueText(Cmb_Batch, "រើសជំនាន់");
            CueBannerText.SetCueText(Cmb_Subject, "រើសមុខវិជ្ជា");
        }
        private void gridviews()
        {
             sql.GetDataGrid("SELECT id,namekh,nameen,gender,dob FROM register_2022 where level = '" + Cmb_Level.Text + "' and specialty = '" + Cmb_Specialty.Text + "' and years = '" + Cmb_Year.Text + "' ", Dgv_Data);

        }

        private void Frm_Examination_Load(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year-1;
            int next = DateTime.Now.Year;
            sql.cmbx("SELECT * FROM academics where nameen = '" + Convert.ToString(years) + "-" + Convert.ToString(next) + "'", Cmb_Academic, "id", "nameen");
            
            gridviews();
            placeheader();
           

            //creating new column
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();

            col.Name = "mark";

            col.Resizable = DataGridViewTriState.False;
            //column1.SortMode = DataGridViewColumnSortMode.Automatic;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //col.DefaultCellStyle.NullValue = 0;

            col.HeaderText = "ពិន្ទុ";
            col.Width = 300;

            //adding column to dataGridView

            Dgv_Data.Columns.Add(col);
            //Dgv_Data.Rows[0].Cells[5].Selected = true;
            Dgv_Data.Columns["id"].ReadOnly = true;
            Dgv_Data.Columns["gender"].ReadOnly = true;
            Dgv_Data.Columns["dob"].ReadOnly = true;

            Dgv_Data.Columns[0].HeaderText = "កូដ";
            Dgv_Data.Columns[1].HeaderText = "គោត្តនាម នាម";
            Dgv_Data.Columns[2].HeaderText = "ជាឡាំង";
            Dgv_Data.Columns[3].HeaderText = "ភេទ";
            Dgv_Data.Columns[4].HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            //Dgv_Data.Columns[5].DefaultCellStyle.Format = "#.##";
            

            //foreach (DataGridViewRow Row in Dgv_Data.Rows)
            //{
            //    Row.Cells[5].Value = 0.00; // Sets the value of the third column

            //}


        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
          
        private void Cmb_Academic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            btn_Restore.Visible = false;
            btn_Maximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_Maximize_Click_1(object sender, EventArgs e)
        {
            btn_Restore.Visible = true;
            btn_Maximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in Dgv_Data.Rows)
            //{
            for (int i = 0; i < Dgv_Data.Rows.Count; i++)
            {

                sql.AddParam("@exam", DateTime.Now);
                sql.AddParam("@stuid", Dgv_Data.Rows[i].Cells["id"].Value == null ? DBNull.Value : Dgv_Data.Rows[i].Cells["id"].Value);
                sql.AddParam("@namekh", Dgv_Data.Rows[i].Cells["namekh"].Value == null ? DBNull.Value : Dgv_Data.Rows[i].Cells["namekh"].Value);
                sql.AddParam("@nameen", Dgv_Data.Rows[i].Cells["nameen"].Value == null ? DBNull.Value : Dgv_Data.Rows[i].Cells["nameen"].Value);
                sql.AddParam("@gender", Dgv_Data.Rows[i].Cells["gender"].Value == null ? DBNull.Value : Dgv_Data.Rows[i].Cells["gender"].Value);
                sql.AddParam("@dob", Dgv_Data.Rows[i].Cells["dob"].Value == null ? DBNull.Value : Dgv_Data.Rows[i].Cells["dob"].Value);
                sql.AddParam("@level", Cmb_Level.SelectedValue == null ? DBNull.Value : Cmb_Level.SelectedValue);
                sql.AddParam("@specialty", Cmb_Specialty.SelectedValue == null ? DBNull.Value : Cmb_Specialty.SelectedValue);
                sql.AddParam("@semester", Cmb_Semester.SelectedValue == null ? DBNull.Value : Cmb_Semester.SelectedValue);
                sql.AddParam("@years", Cmb_Level.SelectedValue == null ? DBNull.Value : Cmb_Year.SelectedValue);
                sql.AddParam("@batch", Cmb_Year.SelectedValue == null ? DBNull.Value : Cmb_Batch.SelectedValue);
                sql.AddParam("@academic", Cmb_Academic.Text);
                sql.AddParam("@subid", Cmb_Subject.SelectedValue == null ? DBNull.Value : Cmb_Subject.SelectedValue);
                sql.AddParam("@subject", Cmb_Subject.Text);
                //double temp;
                //if (double.TryParse((string)row.Cells[5].Value, out temp) == true)
                //{
                //    sql.AddParam("@mark",temp);
                //}
                double marks = 0;
                ;
                //marks = Double.TryParse(Dgv_Data.Rows[i].Cells["mark"].Value.ToString(), out marks) ? marks : 0;
                

                //double Mark = (double)row.Cells[5].Value;
                sql.AddParam("@mark", Dgv_Data.Rows[i].Cells["mark"].Value == null ? string.Empty : Dgv_Data.Rows[i].Cells["mark"].Value.ToString());
               
               
                
               
                ///DateTime dob = new DateTime(yyyy-MM-dd);
                //if (RadioMale.Checked)
                //    SQL.AddParam("@gender", "Male");
                //else

                sql.ExecQuery("INSERT INTO scores(exam_date,student_id,namekh,nameen,gender,dob,level,specialty,semester,years,batch,academic,subject_id,subject,mark) VALUES(@exam,@stuid,@namekh,@nameen,@gender,@dob,@level,@specialty,@semester,@years,@batch,@academic,@subid,@subject,@mark);", true);
            }
            //REPORT & ABORT ON ERRORS
            if (sql.HasException(true)) { }

            MessageBox.Show("បង្កើតថ្មីបានជោគជ័យ");

            clear();

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
            this.Cmb_Subject.DataSource = null;
            this.Cmb_Subject.Items.Clear();

            this.Cmb_Specialty.DataSource = null;
            this.Cmb_Specialty.Items.Clear();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            gridviews();

            
        }

        private void Cmb_Level_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            this.Cmb_Specialty.DataSource = null;
            this.Cmb_Specialty.Items.Clear();
            sql.cmbx("SELECT * FROM specialtys where level='" + Cmb_Level.SelectedValue + "'", Cmb_Specialty, "id", "nameen");
            

        }

        

        private void Cmb_Year_DropDown(object sender, EventArgs e)
        {

            sql.cmbx("SELECT * FROM years", Cmb_Year, "id", "nameen");
        }

        

        private void Cmb_Level_DropDown(object sender, EventArgs e)
        {

            sql.cmbx("SELECT * FROM levels", Cmb_Level, "id", "nameen");
        }

        private void Cmb_Specialty_DropDown(object sender, EventArgs e)
        {

        }

        private void Cmb_Batch_DropDown(object sender, EventArgs e)
        {

            sql.cmbx("SELECT * FROM batchs", Cmb_Batch, "id", "nameen");
        }

        private void Cmb_Subject_DropDown(object sender, EventArgs e)
        {
          

            sql.cmbx("SELECT * FROM subjects", Cmb_Subject, "id", "nameen");
        }

        private void Cmb_Semester_DropDown(object sender, EventArgs e)
        {
            sql.cmbx("SELECT * FROM semesters", Cmb_Semester, "id", "nameen");
        }

        private void Cmb_Specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cmb_Subject.DataSource = null;
            this.Cmb_Subject.Items.Clear();
            sql.cmbx("SELECT * FROM subject where specialty='" + Cmb_Specialty.SelectedValue + "'", Cmb_Subject, "id", "nameen");
        }

        private void Cmb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }


       

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Dgv_Data.AllowUserToAddRows = true;

        }

        

        private void Dgv_Data_Enter(object sender, EventArgs e)
        {
            
        }

        private void Dgv_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_Data_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //check numeric oonly
            double outputValue = 0.00;
            bool isNumber = false;

            isNumber = double.TryParse((string)e.FormattedValue, out outputValue);
            if (e.ColumnIndex == 0)
            {
                if (Dgv_Data.IsCurrentCellDirty)
                {
                    if (!isNumber)
                    {
                        e.Cancel = true;
                        MessageBox.Show("numeric only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ////selection cell in gridview
            //if (e.ColumnIndex == 5)
            //{
            //    if (Dgv_Data.Rows[e.RowIndex].Cells[5].Value.Equals(""))
            //    {
            //        Dgv_Data.ClearSelection();
            //        Dgv_Data.Rows[e.RowIndex].Cells[5].Selected = true;
            //    }
            //}
        }

        private void Dgv_Data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Compare the value of second Column i.e.Column with Index 1.
            //if (e.ColumnIndex == 5 && e.Value != null)
            //{
            //    double quantity = double.Parse((string)e.Value);



            //    //Apply Background color based on value.
            //    if (quantity == 0)
            //    {
            //        e.CellStyle.BackColor = Color.LightPink;
            //    //}
            //    //else if (quantity > 0 && quantity < 60)
            //    //{
            //    //    e.CellStyle.BackColor = Color.LightGray;
            //    //}
            //    //else if (quantity >= 60 && quantity <= 100)
            //    //{
            //    //    e.CellStyle.BackColor = Color.LightGreen;
            //    }
            //    else
            //    {
            //        e.CellStyle.BackColor = Color.Red;
            //    }

            //link:https://www.aspsnippets.com/Articles/Change-DataGridView-Cell-Color-based-on-condition-in-Windows-Application-using-C-and-VBNet.aspx
            foreach (DataGridViewRow row in Dgv_Data.Rows)
            {
                double val = Convert.ToDouble(row.Cells[0].Value);
                if (val == 0)
                {
                    row.Cells[0].Style.BackColor = Color.LightGray;
                }
                else if (val > 0 && val < 60)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells[0].Style.BackColor = Color.LightPink;
                }
                else if (val >= 60 && val <= 100)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells[0].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells[0].Style.BackColor = Color.LightGray;
                }
            }
            }

        private void Dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_Data.AllowUserToAddRows = false;
        }
    }
    
}
