
namespace RPITST.Forms
{
    partial class Frm_Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.btn_Save = new FontAwesome.Sharp.IconButton();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_level = new System.Windows.Forms.ComboBox();
            this.cmb_specialty = new System.Windows.Forms.ComboBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.cmb_subject = new System.Windows.Forms.ComboBox();
            this.cmb_semester = new System.Windows.Forms.ComboBox();
            this.cmb_batch = new System.Windows.Forms.ComboBox();
            this.cmb_academic = new System.Windows.Forms.ComboBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.panel_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(900, 35);
            this.panel_Title.TabIndex = 0;
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.btn_Save);
            this.panel_Content.Controls.Add(this.cmb_year);
            this.panel_Content.Controls.Add(this.cmb_level);
            this.panel_Content.Controls.Add(this.cmb_specialty);
            this.panel_Content.Controls.Add(this.cmb_Department);
            this.panel_Content.Controls.Add(this.cmb_subject);
            this.panel_Content.Controls.Add(this.cmb_semester);
            this.panel_Content.Controls.Add(this.cmb_batch);
            this.panel_Content.Controls.Add(this.cmb_academic);
            this.panel_Content.Controls.Add(this.dgv_Data);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 35);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(900, 465);
            this.panel_Content.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.Blue;
            this.btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Save.IconColor = System.Drawing.Color.Blue;
            this.btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Save.IconSize = 40;
            this.btn_Save.Location = new System.Drawing.Point(573, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 39);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "រក្សាទុក";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_year
            // 
            this.cmb_year.BackColor = System.Drawing.Color.Beige;
            this.cmb_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_year.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(564, 340);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(276, 33);
            this.cmb_year.TabIndex = 8;
            // 
            // cmb_level
            // 
            this.cmb_level.BackColor = System.Drawing.Color.Beige;
            this.cmb_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_level.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_level.FormattingEnabled = true;
            this.cmb_level.Location = new System.Drawing.Point(564, 113);
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.Size = new System.Drawing.Size(276, 33);
            this.cmb_level.TabIndex = 7;
            // 
            // cmb_specialty
            // 
            this.cmb_specialty.BackColor = System.Drawing.Color.Beige;
            this.cmb_specialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_specialty.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specialty.FormattingEnabled = true;
            this.cmb_specialty.Location = new System.Drawing.Point(564, 152);
            this.cmb_specialty.Name = "cmb_specialty";
            this.cmb_specialty.Size = new System.Drawing.Size(276, 33);
            this.cmb_specialty.TabIndex = 6;
            this.cmb_specialty.SelectedIndexChanged += new System.EventHandler(this.cmb_specialty_SelectedIndexChanged);
            // 
            // cmb_Department
            // 
            this.cmb_Department.BackColor = System.Drawing.Color.Beige;
            this.cmb_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Department.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(564, 191);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(276, 33);
            this.cmb_Department.TabIndex = 5;
            // 
            // cmb_subject
            // 
            this.cmb_subject.BackColor = System.Drawing.Color.Beige;
            this.cmb_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_subject.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.Location = new System.Drawing.Point(564, 239);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.Size = new System.Drawing.Size(276, 33);
            this.cmb_subject.TabIndex = 4;
            // 
            // cmb_semester
            // 
            this.cmb_semester.BackColor = System.Drawing.Color.Beige;
            this.cmb_semester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_semester.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_semester.FormattingEnabled = true;
            this.cmb_semester.Location = new System.Drawing.Point(564, 287);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(276, 33);
            this.cmb_semester.TabIndex = 3;
            // 
            // cmb_batch
            // 
            this.cmb_batch.BackColor = System.Drawing.Color.Beige;
            this.cmb_batch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_batch.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_batch.FormattingEnabled = true;
            this.cmb_batch.Location = new System.Drawing.Point(564, 70);
            this.cmb_batch.Name = "cmb_batch";
            this.cmb_batch.Size = new System.Drawing.Size(276, 33);
            this.cmb_batch.TabIndex = 2;
            // 
            // cmb_academic
            // 
            this.cmb_academic.BackColor = System.Drawing.Color.Beige;
            this.cmb_academic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_academic.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_academic.Location = new System.Drawing.Point(564, 22);
            this.cmb_academic.Name = "cmb_academic";
            this.cmb_academic.Size = new System.Drawing.Size(276, 33);
            this.cmb_academic.TabIndex = 1;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            this.dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_Data.Location = new System.Drawing.Point(3, 6);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.RowHeadersVisible = false;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(512, 456);
            this.dgv_Data.TabIndex = 0;
            this.dgv_Data.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_Data_CellValidating);
            // 
            // Frm_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Title);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Score";
            this.Text = "Frm_Score";
            this.Load += new System.EventHandler(this.Frm_Score_Load);
            this.panel_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmb_level;
        private System.Windows.Forms.ComboBox cmb_specialty;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.ComboBox cmb_subject;
        private System.Windows.Forms.ComboBox cmb_semester;
        private System.Windows.Forms.ComboBox cmb_batch;
        private System.Windows.Forms.ComboBox cmb_academic;
        private System.Windows.Forms.DataGridView dgv_Data;
        private FontAwesome.Sharp.IconButton btn_Save;
    }
}