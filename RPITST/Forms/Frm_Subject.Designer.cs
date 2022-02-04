
namespace RPITST.Forms
{
    partial class Frm_Subject
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
            this.label_Title = new System.Windows.Forms.Label();
            this.icon_Logo = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Update = new FontAwesome.Sharp.IconButton();
            this.btn_Save = new FontAwesome.Sharp.IconButton();
            this.btn_NameEn = new FontAwesome.Sharp.IconButton();
            this.btn_iconNamekh = new FontAwesome.Sharp.IconButton();
            this.btn_iconID = new FontAwesome.Sharp.IconButton();
            this.panel_NameEN = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.txt_NameEN = new System.Windows.Forms.TextBox();
            this.txt_NameKH = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.icon_Credit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Credit = new System.Windows.Forms.TextBox();
            this.icon_Level = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icon_Specialty = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_Level = new System.Windows.Forms.ComboBox();
            this.cmb_Specialty = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.panel_Content.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Khmer OS Siemreap", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.DimGray;
            this.label_Title.Location = new System.Drawing.Point(630, 18);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(140, 49);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "SUBJECT";
            // 
            // icon_Logo
            // 
            this.icon_Logo.BackColor = System.Drawing.Color.LightBlue;
            this.icon_Logo.ForeColor = System.Drawing.Color.DimGray;
            this.icon_Logo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon_Logo.IconColor = System.Drawing.Color.DimGray;
            this.icon_Logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Logo.IconSize = 61;
            this.icon_Logo.Location = new System.Drawing.Point(556, 10);
            this.icon_Logo.Name = "icon_Logo";
            this.icon_Logo.Size = new System.Drawing.Size(68, 61);
            this.icon_Logo.TabIndex = 12;
            this.icon_Logo.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_Delete.IconColor = System.Drawing.Color.Red;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.IconSize = 30;
            this.btn_Delete.Location = new System.Drawing.Point(777, 391);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(119, 34);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.btn_Update.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_Update.IconColor = System.Drawing.Color.DarkBlue;
            this.btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Update.IconSize = 30;
            this.btn_Update.Location = new System.Drawing.Point(657, 391);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 34);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.btn_Save.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Save.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_Save.IconColor = System.Drawing.Color.DarkRed;
            this.btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Save.IconSize = 30;
            this.btn_Save.Location = new System.Drawing.Point(534, 391);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 34);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_NameEn
            // 
            this.btn_NameEn.FlatAppearance.BorderSize = 0;
            this.btn_NameEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NameEn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_NameEn.IconColor = System.Drawing.Color.DimGray;
            this.btn_NameEn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NameEn.IconSize = 30;
            this.btn_NameEn.Location = new System.Drawing.Point(547, 187);
            this.btn_NameEn.Name = "btn_NameEn";
            this.btn_NameEn.Size = new System.Drawing.Size(30, 30);
            this.btn_NameEn.TabIndex = 8;
            this.btn_NameEn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NameEn.UseVisualStyleBackColor = true;
            // 
            // btn_iconNamekh
            // 
            this.btn_iconNamekh.FlatAppearance.BorderSize = 0;
            this.btn_iconNamekh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconNamekh.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btn_iconNamekh.IconColor = System.Drawing.Color.DimGray;
            this.btn_iconNamekh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconNamekh.IconSize = 30;
            this.btn_iconNamekh.Location = new System.Drawing.Point(545, 140);
            this.btn_iconNamekh.Name = "btn_iconNamekh";
            this.btn_iconNamekh.Size = new System.Drawing.Size(30, 30);
            this.btn_iconNamekh.TabIndex = 7;
            this.btn_iconNamekh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconNamekh.UseVisualStyleBackColor = true;
            // 
            // btn_iconID
            // 
            this.btn_iconID.FlatAppearance.BorderSize = 0;
            this.btn_iconID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconID.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_iconID.IconColor = System.Drawing.Color.DimGray;
            this.btn_iconID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_iconID.IconSize = 30;
            this.btn_iconID.Location = new System.Drawing.Point(546, 99);
            this.btn_iconID.Name = "btn_iconID";
            this.btn_iconID.Size = new System.Drawing.Size(30, 30);
            this.btn_iconID.TabIndex = 1;
            this.btn_iconID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_iconID.UseVisualStyleBackColor = true;
            // 
            // panel_NameEN
            // 
            this.panel_NameEN.Location = new System.Drawing.Point(550, 220);
            this.panel_NameEN.Name = "panel_NameEN";
            this.panel_NameEN.Size = new System.Drawing.Size(300, 3);
            this.panel_NameEN.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(550, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 3);
            this.panel1.TabIndex = 5;
            // 
            // panel_ID
            // 
            this.panel_ID.Location = new System.Drawing.Point(550, 133);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(300, 3);
            this.panel_ID.TabIndex = 4;
            // 
            // txt_NameEN
            // 
            this.txt_NameEN.BackColor = System.Drawing.Color.LightBlue;
            this.txt_NameEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NameEN.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.txt_NameEN.ForeColor = System.Drawing.Color.DimGray;
            this.txt_NameEN.Location = new System.Drawing.Point(580, 189);
            this.txt_NameEN.Name = "txt_NameEN";
            this.txt_NameEN.Size = new System.Drawing.Size(270, 28);
            this.txt_NameEN.TabIndex = 3;
            // 
            // txt_NameKH
            // 
            this.txt_NameKH.BackColor = System.Drawing.Color.LightBlue;
            this.txt_NameKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NameKH.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.txt_NameKH.ForeColor = System.Drawing.Color.DimGray;
            this.txt_NameKH.Location = new System.Drawing.Point(580, 143);
            this.txt_NameKH.Name = "txt_NameKH";
            this.txt_NameKH.Size = new System.Drawing.Size(270, 28);
            this.txt_NameKH.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.LightBlue;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.txt_ID.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ID.Location = new System.Drawing.Point(580, 102);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(270, 28);
            this.txt_ID.TabIndex = 1;
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(3, 2);
            this.dgv_Data.MultiSelect = false;
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.ReadOnly = true;
            this.dgv_Data.RowHeadersVisible = false;
            this.dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Data.Size = new System.Drawing.Size(500, 460);
            this.dgv_Data.TabIndex = 0;
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.cmb_Specialty);
            this.panel_Content.Controls.Add(this.cmb_Level);
            this.panel_Content.Controls.Add(this.icon_Specialty);
            this.panel_Content.Controls.Add(this.panel4);
            this.panel_Content.Controls.Add(this.icon_Level);
            this.panel_Content.Controls.Add(this.panel3);
            this.panel_Content.Controls.Add(this.icon_Credit);
            this.panel_Content.Controls.Add(this.panel2);
            this.panel_Content.Controls.Add(this.txt_Credit);
            this.panel_Content.Controls.Add(this.label_Title);
            this.panel_Content.Controls.Add(this.icon_Logo);
            this.panel_Content.Controls.Add(this.btn_Delete);
            this.panel_Content.Controls.Add(this.btn_Update);
            this.panel_Content.Controls.Add(this.btn_Save);
            this.panel_Content.Controls.Add(this.btn_NameEn);
            this.panel_Content.Controls.Add(this.btn_iconNamekh);
            this.panel_Content.Controls.Add(this.btn_iconID);
            this.panel_Content.Controls.Add(this.panel_NameEN);
            this.panel_Content.Controls.Add(this.panel1);
            this.panel_Content.Controls.Add(this.panel_ID);
            this.panel_Content.Controls.Add(this.txt_NameEN);
            this.panel_Content.Controls.Add(this.txt_NameKH);
            this.panel_Content.Controls.Add(this.txt_ID);
            this.panel_Content.Controls.Add(this.dgv_Data);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.ForeColor = System.Drawing.Color.DimGray;
            this.panel_Content.Location = new System.Drawing.Point(0, 35);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(900, 465);
            this.panel_Content.TabIndex = 3;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.Red;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 35;
            this.btn_Close.Location = new System.Drawing.Point(866, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Silver;
            this.panel_Title.Controls.Add(this.btn_Close);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(900, 35);
            this.panel_Title.TabIndex = 2;
            // 
            // icon_Credit
            // 
            this.icon_Credit.FlatAppearance.BorderSize = 0;
            this.icon_Credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_Credit.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icon_Credit.IconColor = System.Drawing.Color.DimGray;
            this.icon_Credit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Credit.IconSize = 30;
            this.icon_Credit.Location = new System.Drawing.Point(547, 229);
            this.icon_Credit.Name = "icon_Credit";
            this.icon_Credit.Size = new System.Drawing.Size(30, 30);
            this.icon_Credit.TabIndex = 16;
            this.icon_Credit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_Credit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(550, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 3);
            this.panel2.TabIndex = 15;
            // 
            // txt_Credit
            // 
            this.txt_Credit.BackColor = System.Drawing.Color.LightBlue;
            this.txt_Credit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Credit.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.txt_Credit.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Credit.Location = new System.Drawing.Point(580, 231);
            this.txt_Credit.Name = "txt_Credit";
            this.txt_Credit.Size = new System.Drawing.Size(270, 28);
            this.txt_Credit.TabIndex = 14;
            // 
            // icon_Level
            // 
            this.icon_Level.FlatAppearance.BorderSize = 0;
            this.icon_Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_Level.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icon_Level.IconColor = System.Drawing.Color.DimGray;
            this.icon_Level.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Level.IconSize = 30;
            this.icon_Level.Location = new System.Drawing.Point(547, 282);
            this.icon_Level.Name = "icon_Level";
            this.icon_Level.Size = new System.Drawing.Size(30, 30);
            this.icon_Level.TabIndex = 19;
            this.icon_Level.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_Level.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(550, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 3);
            this.panel3.TabIndex = 18;
            // 
            // icon_Specialty
            // 
            this.icon_Specialty.FlatAppearance.BorderSize = 0;
            this.icon_Specialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon_Specialty.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icon_Specialty.IconColor = System.Drawing.Color.DimGray;
            this.icon_Specialty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_Specialty.IconSize = 30;
            this.icon_Specialty.Location = new System.Drawing.Point(547, 332);
            this.icon_Specialty.Name = "icon_Specialty";
            this.icon_Specialty.Size = new System.Drawing.Size(30, 30);
            this.icon_Specialty.TabIndex = 22;
            this.icon_Specialty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icon_Specialty.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(550, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 3);
            this.panel4.TabIndex = 21;
            // 
            // cmb_Level
            // 
            this.cmb_Level.BackColor = System.Drawing.Color.LightBlue;
            this.cmb_Level.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Level.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Level.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Level.FormattingEnabled = true;
            this.cmb_Level.Location = new System.Drawing.Point(583, 277);
            this.cmb_Level.Name = "cmb_Level";
            this.cmb_Level.Size = new System.Drawing.Size(267, 35);
            this.cmb_Level.TabIndex = 23;
            // 
            // cmb_Specialty
            // 
            this.cmb_Specialty.BackColor = System.Drawing.Color.LightBlue;
            this.cmb_Specialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Specialty.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Specialty.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Specialty.FormattingEnabled = true;
            this.cmb_Specialty.Location = new System.Drawing.Point(583, 327);
            this.cmb_Specialty.Name = "cmb_Specialty";
            this.cmb_Specialty.Size = new System.Drawing.Size(267, 35);
            this.cmb_Specialty.TabIndex = 24;
            // 
            // Frm_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Title);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Subject";
            this.Text = "Frm_Subject";
            ((System.ComponentModel.ISupportInitialize)(this.icon_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.panel_Content.ResumeLayout(false);
            this.panel_Content.PerformLayout();
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private FontAwesome.Sharp.IconPictureBox icon_Logo;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_Save;
        private FontAwesome.Sharp.IconButton btn_NameEn;
        private FontAwesome.Sharp.IconButton btn_iconNamekh;
        private FontAwesome.Sharp.IconButton btn_iconID;
        private System.Windows.Forms.Panel panel_NameEN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.TextBox txt_NameEN;
        private System.Windows.Forms.TextBox txt_NameKH;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.ComboBox cmb_Specialty;
        private System.Windows.Forms.ComboBox cmb_Level;
        private FontAwesome.Sharp.IconButton icon_Specialty;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton icon_Level;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton icon_Credit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Credit;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Panel panel_Title;
    }
}