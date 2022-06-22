
namespace RPITST.Forms
{
    partial class Frm_Examination
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Restore = new FontAwesome.Sharp.IconButton();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Cmb_Specialty = new System.Windows.Forms.ComboBox();
            this.Cmb_Level = new System.Windows.Forms.ComboBox();
            this.Cmb_Academic = new System.Windows.Forms.ComboBox();
            this.Cmb_Semester = new System.Windows.Forms.ComboBox();
            this.Cmb_Year = new System.Windows.Forms.ComboBox();
            this.Cmb_Batch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Save = new FontAwesome.Sharp.IconButton();
            this.Btn_Cancel = new FontAwesome.Sharp.IconButton();
            this.Btn_Search = new FontAwesome.Sharp.IconButton();
            this.Cmb_Subject = new System.Windows.Forms.ComboBox();
            this.Btn_New = new FontAwesome.Sharp.IconButton();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.Red;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 35;
            this.btn_Close.Location = new System.Drawing.Point(1166, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Silver;
            this.panel_Title.Controls.Add(this.btn_Maximize);
            this.panel_Title.Controls.Add(this.btn_Minimize);
            this.panel_Title.Controls.Add(this.btn_Restore);
            this.panel_Title.Controls.Add(this.btn_Close);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1200, 35);
            this.panel_Title.TabIndex = 1;
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.Color.Red;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 35;
            this.btn_Maximize.Location = new System.Drawing.Point(1130, 3);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 21;
            this.btn_Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click_1);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Red;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.Red;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 30;
            this.btn_Minimize.Location = new System.Drawing.Point(1094, 2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 22;
            this.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.ForeColor = System.Drawing.Color.Red;
            this.btn_Restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btn_Restore.IconColor = System.Drawing.Color.Red;
            this.btn_Restore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Restore.IconSize = 30;
            this.btn_Restore.Location = new System.Drawing.Point(1130, 2);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(30, 30);
            this.btn_Restore.TabIndex = 21;
            this.btn_Restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Visible = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AllowUserToAddRows = false;
            this.Dgv_Data.AllowUserToResizeColumns = false;
            this.Dgv_Data.AllowUserToResizeRows = false;
            this.Dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Location = new System.Drawing.Point(8, 363);
            this.Dgv_Data.MultiSelect = false;
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.RowHeadersVisible = false;
            this.Dgv_Data.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Suwannaphum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Data.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Data.RowTemplate.Height = 24;
            this.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgv_Data.Size = new System.Drawing.Size(1182, 430);
            this.Dgv_Data.TabIndex = 9;
            this.Dgv_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Data_CellContentClick);
            this.Dgv_Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Data_CellDoubleClick);
            this.Dgv_Data.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_Data_CellFormatting);
            this.Dgv_Data.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Dgv_Data_CellValidating);
            // 
            // Cmb_Specialty
            // 
            this.Cmb_Specialty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Specialty.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Specialty.FormattingEnabled = true;
            this.Cmb_Specialty.Location = new System.Drawing.Point(190, 195);
            this.Cmb_Specialty.Name = "Cmb_Specialty";
            this.Cmb_Specialty.Size = new System.Drawing.Size(342, 39);
            this.Cmb_Specialty.TabIndex = 2;
            this.Cmb_Specialty.DropDown += new System.EventHandler(this.Cmb_Specialty_DropDown);
            this.Cmb_Specialty.SelectedIndexChanged += new System.EventHandler(this.Cmb_Specialty_SelectedIndexChanged);
            // 
            // Cmb_Level
            // 
            this.Cmb_Level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Level.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Level.FormattingEnabled = true;
            this.Cmb_Level.Location = new System.Drawing.Point(267, 144);
            this.Cmb_Level.Name = "Cmb_Level";
            this.Cmb_Level.Size = new System.Drawing.Size(625, 39);
            this.Cmb_Level.TabIndex = 1;
            this.Cmb_Level.DropDown += new System.EventHandler(this.Cmb_Level_DropDown);
            this.Cmb_Level.SelectedIndexChanged += new System.EventHandler(this.Cmb_Level_SelectedIndexChanged_1);
            // 
            // Cmb_Academic
            // 
            this.Cmb_Academic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Academic.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Academic.FormattingEnabled = true;
            this.Cmb_Academic.Location = new System.Drawing.Point(986, 195);
            this.Cmb_Academic.Name = "Cmb_Academic";
            this.Cmb_Academic.Size = new System.Drawing.Size(148, 39);
            this.Cmb_Academic.TabIndex = 6;
            this.Cmb_Academic.SelectedIndexChanged += new System.EventHandler(this.Cmb_Academic_SelectedIndexChanged);
            // 
            // Cmb_Semester
            // 
            this.Cmb_Semester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Semester.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Semester.FormattingEnabled = true;
            this.Cmb_Semester.Location = new System.Drawing.Point(697, 48);
            this.Cmb_Semester.Name = "Cmb_Semester";
            this.Cmb_Semester.Size = new System.Drawing.Size(121, 39);
            this.Cmb_Semester.TabIndex = 0;
            this.Cmb_Semester.DropDown += new System.EventHandler(this.Cmb_Semester_DropDown);
            // 
            // Cmb_Year
            // 
            this.Cmb_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Year.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Year.FormattingEnabled = true;
            this.Cmb_Year.Location = new System.Drawing.Point(593, 195);
            this.Cmb_Year.Name = "Cmb_Year";
            this.Cmb_Year.Size = new System.Drawing.Size(73, 39);
            this.Cmb_Year.TabIndex = 3;
            this.Cmb_Year.DropDown += new System.EventHandler(this.Cmb_Year_DropDown);
            // 
            // Cmb_Batch
            // 
            this.Cmb_Batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cmb_Batch.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Batch.FormattingEnabled = true;
            this.Cmb_Batch.Location = new System.Drawing.Point(754, 195);
            this.Cmb_Batch.Name = "Cmb_Batch";
            this.Cmb_Batch.Size = new System.Drawing.Size(138, 39);
            this.Cmb_Batch.TabIndex = 4;
            this.Cmb_Batch.DropDown += new System.EventHandler(this.Cmb_Batch_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Suwannaphum", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(380, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "លទ្ធផលប្រឡងសងឆមាសលើកទី";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Suwannaphum", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(344, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "សម័យប្រឡង៖ ថ្ងៃទី ០៥ ខែ មិថុនា ឆ្នាំ២០២២";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = " ជំនាញៈ ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "កម្រិតសញ្ញាបត្រៈ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "ឆ្នាំទី";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(672, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "ជំនាន់ទី";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(892, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "ឆ្នាំសិក្សា ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "មុខវិជ្ជាៈ";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Save.FlatAppearance.BorderSize = 0;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Suwannaphum", 12F);
            this.Btn_Save.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.Btn_Save.IconColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Save.IconSize = 30;
            this.Btn_Save.Location = new System.Drawing.Point(875, 308);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(146, 49);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "បញ្ចូលពិន្ទុ";
            this.Btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.FlatAppearance.BorderSize = 0;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Suwannaphum", 12F);
            this.Btn_Cancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancel.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Btn_Cancel.IconColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Cancel.IconSize = 30;
            this.Btn_Cancel.Location = new System.Drawing.Point(1042, 308);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(146, 49);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "ចាកចេញ";
            this.Btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Suwannaphum", 12F);
            this.Btn_Search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Btn_Search.IconColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Search.IconSize = 30;
            this.Btn_Search.Location = new System.Drawing.Point(737, 308);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(146, 49);
            this.Btn_Search.TabIndex = 6;
            this.Btn_Search.Text = "ស្វែងរក";
            this.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cmb_Subject
            // 
            this.Cmb_Subject.Font = new System.Drawing.Font("Suwannaphum Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Subject.FormattingEnabled = true;
            this.Cmb_Subject.Location = new System.Drawing.Point(190, 248);
            this.Cmb_Subject.Name = "Cmb_Subject";
            this.Cmb_Subject.Size = new System.Drawing.Size(702, 39);
            this.Cmb_Subject.TabIndex = 19;
            // 
            // Btn_New
            // 
            this.Btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_New.FlatAppearance.BorderSize = 0;
            this.Btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_New.Font = new System.Drawing.Font("Suwannaphum", 12F);
            this.Btn_New.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Btn_New.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Btn_New.IconColor = System.Drawing.Color.DodgerBlue;
            this.Btn_New.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_New.IconSize = 30;
            this.Btn_New.Location = new System.Drawing.Point(557, 308);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(174, 49);
            this.Btn_New.TabIndex = 20;
            this.Btn_New.Text = "បន្ថែមនិស្សិត";
            this.Btn_New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_New.UseVisualStyleBackColor = true;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Frm_Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.Cmb_Subject);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Batch);
            this.Controls.Add(this.Cmb_Year);
            this.Controls.Add(this.Cmb_Semester);
            this.Controls.Add(this.Cmb_Academic);
            this.Controls.Add(this.Cmb_Level);
            this.Controls.Add(this.Cmb_Specialty);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.panel_Title);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Frm_Examination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Examination";
            this.Load += new System.EventHandler(this.Frm_Examination_Load);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.ComboBox Cmb_Specialty;
        private System.Windows.Forms.ComboBox Cmb_Level;
        private System.Windows.Forms.ComboBox Cmb_Academic;
        private System.Windows.Forms.ComboBox Cmb_Semester;
        private System.Windows.Forms.ComboBox Cmb_Year;
        private System.Windows.Forms.ComboBox Cmb_Batch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton Btn_Save;
        private FontAwesome.Sharp.IconButton Btn_Cancel;
        private FontAwesome.Sharp.IconButton Btn_Search;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Restore;
        private System.Windows.Forms.ComboBox Cmb_Subject;
        private FontAwesome.Sharp.IconButton Btn_New;
    }
}