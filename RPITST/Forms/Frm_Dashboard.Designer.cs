
namespace RPITST.Forms
{
    partial class Frm_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Restore = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Menu1 = new FontAwesome.Sharp.IconButton();
            this.btn_SignOut = new FontAwesome.Sharp.IconButton();
            this.btn_Menu3 = new FontAwesome.Sharp.IconButton();
            this.btn_Menu2 = new FontAwesome.Sharp.IconButton();
            this.btn_Messager = new FontAwesome.Sharp.IconButton();
            this.btn_Instagram = new FontAwesome.Sharp.IconButton();
            this.btn_WhatApp = new FontAwesome.Sharp.IconButton();
            this.btn_Telegram = new FontAwesome.Sharp.IconButton();
            this.btn_Youtube = new FontAwesome.Sharp.IconButton();
            this.btn_Facebook = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.btn_Menu = new FontAwesome.Sharp.IconButton();
            this.timer_MenuShow = new System.Windows.Forms.Timer(this.components);
            this.timer_MenuHide = new System.Windows.Forms.Timer(this.components);
            this.panel_Content = new System.Windows.Forms.Panel();
            this.Btn_Examination = new FontAwesome.Sharp.IconButton();
            this.Btn_FR14 = new FontAwesome.Sharp.IconButton();
            this.panel_Title.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel_Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Title.Controls.Add(this.btn_Minimize);
            this.panel_Title.Controls.Add(this.btn_Maximize);
            this.panel_Title.Controls.Add(this.btn_Restore);
            this.panel_Title.Controls.Add(this.btn_Close);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1200, 35);
            this.panel_Title.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 30;
            this.btn_Minimize.Location = new System.Drawing.Point(1095, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 30;
            this.btn_Maximize.Location = new System.Drawing.Point(1131, 2);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restore.FlatAppearance.BorderSize = 0;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btn_Restore.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Restore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Restore.IconSize = 30;
            this.btn_Restore.Location = new System.Drawing.Point(1131, 3);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(30, 30);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Visible = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 30;
            this.btn_Close.Location = new System.Drawing.Point(1167, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_Menu.Controls.Add(this.iconPictureBox1);
            this.panel_Menu.Controls.Add(this.btn_Menu1);
            this.panel_Menu.Controls.Add(this.btn_SignOut);
            this.panel_Menu.Controls.Add(this.btn_Menu3);
            this.panel_Menu.Controls.Add(this.btn_Menu2);
            this.panel_Menu.Controls.Add(this.btn_Messager);
            this.panel_Menu.Controls.Add(this.btn_Instagram);
            this.panel_Menu.Controls.Add(this.btn_WhatApp);
            this.panel_Menu.Controls.Add(this.btn_Telegram);
            this.panel_Menu.Controls.Add(this.btn_Youtube);
            this.panel_Menu.Controls.Add(this.btn_Facebook);
            this.panel_Menu.Controls.Add(this.btn_Home);
            this.panel_Menu.Controls.Add(this.btn_Menu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 35);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(300, 565);
            this.panel_Menu.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(98, 71);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(78, 89);
            this.iconPictureBox1.TabIndex = 22;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_Menu1
            // 
            this.btn_Menu1.FlatAppearance.BorderSize = 0;
            this.btn_Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu1.Font = new System.Drawing.Font("Suwannaphum", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Menu1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menu1.IconSize = 40;
            this.btn_Menu1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu1.Location = new System.Drawing.Point(1, 256);
            this.btn_Menu1.Name = "btn_Menu1";
            this.btn_Menu1.Size = new System.Drawing.Size(291, 41);
            this.btn_Menu1.TabIndex = 21;
            this.btn_Menu1.Text = "ACADEMIC";
            this.btn_Menu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu1.UseVisualStyleBackColor = true;
            this.btn_Menu1.Click += new System.EventHandler(this.btn_Menu1_Click);
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.FlatAppearance.BorderSize = 0;
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Font = new System.Drawing.Font("Suwannaphum", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_SignOut.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SignOut.IconSize = 40;
            this.btn_SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.Location = new System.Drawing.Point(2, 425);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Size = new System.Drawing.Size(291, 41);
            this.btn_SignOut.TabIndex = 20;
            this.btn_SignOut.Text = "SIGHN OUT";
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SignOut.UseVisualStyleBackColor = true;
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.FlatAppearance.BorderSize = 0;
            this.btn_Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu3.Font = new System.Drawing.Font("Suwannaphum", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu3.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Menu3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menu3.IconSize = 40;
            this.btn_Menu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu3.Location = new System.Drawing.Point(2, 369);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(291, 41);
            this.btn_Menu3.TabIndex = 19;
            this.btn_Menu3.Text = "-----";
            this.btn_Menu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu3.UseVisualStyleBackColor = true;
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.FlatAppearance.BorderSize = 0;
            this.btn_Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu2.Font = new System.Drawing.Font("Suwannaphum", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu2.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Menu2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menu2.IconSize = 40;
            this.btn_Menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu2.Location = new System.Drawing.Point(2, 313);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(291, 41);
            this.btn_Menu2.TabIndex = 18;
            this.btn_Menu2.Text = "------";
            this.btn_Menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu2.UseVisualStyleBackColor = true;
            // 
            // btn_Messager
            // 
            this.btn_Messager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Messager.FlatAppearance.BorderSize = 0;
            this.btn_Messager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Messager.IconChar = FontAwesome.Sharp.IconChar.FacebookMessenger;
            this.btn_Messager.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Messager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Messager.IconSize = 30;
            this.btn_Messager.Location = new System.Drawing.Point(218, 523);
            this.btn_Messager.Name = "btn_Messager";
            this.btn_Messager.Size = new System.Drawing.Size(30, 30);
            this.btn_Messager.TabIndex = 16;
            this.btn_Messager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Messager.UseVisualStyleBackColor = true;
            // 
            // btn_Instagram
            // 
            this.btn_Instagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Instagram.FlatAppearance.BorderSize = 0;
            this.btn_Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.btn_Instagram.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Instagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Instagram.IconSize = 30;
            this.btn_Instagram.Location = new System.Drawing.Point(182, 523);
            this.btn_Instagram.Name = "btn_Instagram";
            this.btn_Instagram.Size = new System.Drawing.Size(30, 30);
            this.btn_Instagram.TabIndex = 15;
            this.btn_Instagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Instagram.UseVisualStyleBackColor = true;
            // 
            // btn_WhatApp
            // 
            this.btn_WhatApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WhatApp.FlatAppearance.BorderSize = 0;
            this.btn_WhatApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WhatApp.IconChar = FontAwesome.Sharp.IconChar.Whatsapp;
            this.btn_WhatApp.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_WhatApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_WhatApp.IconSize = 30;
            this.btn_WhatApp.Location = new System.Drawing.Point(146, 523);
            this.btn_WhatApp.Name = "btn_WhatApp";
            this.btn_WhatApp.Size = new System.Drawing.Size(30, 30);
            this.btn_WhatApp.TabIndex = 14;
            this.btn_WhatApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_WhatApp.UseVisualStyleBackColor = true;
            // 
            // btn_Telegram
            // 
            this.btn_Telegram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Telegram.FlatAppearance.BorderSize = 0;
            this.btn_Telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Telegram.IconChar = FontAwesome.Sharp.IconChar.Telegram;
            this.btn_Telegram.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Telegram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Telegram.IconSize = 30;
            this.btn_Telegram.Location = new System.Drawing.Point(110, 523);
            this.btn_Telegram.Name = "btn_Telegram";
            this.btn_Telegram.Size = new System.Drawing.Size(30, 30);
            this.btn_Telegram.TabIndex = 13;
            this.btn_Telegram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Telegram.UseVisualStyleBackColor = true;
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Youtube.FlatAppearance.BorderSize = 0;
            this.btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Youtube.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.btn_Youtube.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Youtube.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Youtube.IconSize = 30;
            this.btn_Youtube.Location = new System.Drawing.Point(74, 523);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(30, 30);
            this.btn_Youtube.TabIndex = 12;
            this.btn_Youtube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Youtube.UseVisualStyleBackColor = true;
            // 
            // btn_Facebook
            // 
            this.btn_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Facebook.FlatAppearance.BorderSize = 0;
            this.btn_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.btn_Facebook.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Facebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Facebook.IconSize = 30;
            this.btn_Facebook.Location = new System.Drawing.Point(38, 523);
            this.btn_Facebook.Name = "btn_Facebook";
            this.btn_Facebook.Size = new System.Drawing.Size(30, 30);
            this.btn_Facebook.TabIndex = 11;
            this.btn_Facebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Facebook.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Suwannaphum", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 40;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(2, 203);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(291, 41);
            this.btn_Home.TabIndex = 6;
            this.btn_Home.Text = "HOME";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btn_Menu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Menu.IconSize = 40;
            this.btn_Menu.Location = new System.Drawing.Point(261, 6);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(40, 40);
            this.btn_Menu.TabIndex = 5;
            this.btn_Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // timer_MenuShow
            // 
            this.timer_MenuShow.Tick += new System.EventHandler(this.timer_MenuShow_Tick);
            // 
            // timer_MenuHide
            // 
            this.timer_MenuHide.Tick += new System.EventHandler(this.timer_MenuHide_Tick);
            // 
            // panel_Content
            // 
            this.panel_Content.Controls.Add(this.Btn_FR14);
            this.panel_Content.Controls.Add(this.Btn_Examination);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(300, 35);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(900, 565);
            this.panel_Content.TabIndex = 3;
            // 
            // Btn_Examination
            // 
            this.Btn_Examination.FlatAppearance.BorderSize = 0;
            this.Btn_Examination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Examination.ForeColor = System.Drawing.Color.Salmon;
            this.Btn_Examination.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.Btn_Examination.IconColor = System.Drawing.Color.Salmon;
            this.Btn_Examination.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Examination.IconSize = 150;
            this.Btn_Examination.Location = new System.Drawing.Point(57, 34);
            this.Btn_Examination.Name = "Btn_Examination";
            this.Btn_Examination.Size = new System.Drawing.Size(155, 200);
            this.Btn_Examination.TabIndex = 23;
            this.Btn_Examination.Text = "Examination";
            this.Btn_Examination.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Examination.UseVisualStyleBackColor = true;
            this.Btn_Examination.Click += new System.EventHandler(this.Btn_Examination_Click);
            // 
            // Btn_FR14
            // 
            this.Btn_FR14.FlatAppearance.BorderSize = 0;
            this.Btn_FR14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FR14.ForeColor = System.Drawing.Color.Salmon;
            this.Btn_FR14.IconChar = FontAwesome.Sharp.IconChar.Linux;
            this.Btn_FR14.IconColor = System.Drawing.Color.Salmon;
            this.Btn_FR14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_FR14.IconSize = 150;
            this.Btn_FR14.Location = new System.Drawing.Point(250, 34);
            this.Btn_FR14.Name = "Btn_FR14";
            this.Btn_FR14.Size = new System.Drawing.Size(155, 200);
            this.Btn_FR14.TabIndex = 24;
            this.Btn_FR14.Text = "Student List";
            this.Btn_FR14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_FR14.UseVisualStyleBackColor = true;
            this.Btn_FR14.Click += new System.EventHandler(this.Btn_FR14_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Title);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Dashboard";
            this.panel_Title.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel_Content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Menu;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Restore;
        private FontAwesome.Sharp.IconButton btn_Close;
        private FontAwesome.Sharp.IconButton btn_Messager;
        private FontAwesome.Sharp.IconButton btn_Instagram;
        private FontAwesome.Sharp.IconButton btn_WhatApp;
        private FontAwesome.Sharp.IconButton btn_Telegram;
        private FontAwesome.Sharp.IconButton btn_Youtube;
        private FontAwesome.Sharp.IconButton btn_Facebook;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_Menu;
        private FontAwesome.Sharp.IconButton btn_SignOut;
        private FontAwesome.Sharp.IconButton btn_Menu3;
        private FontAwesome.Sharp.IconButton btn_Menu2;
        private FontAwesome.Sharp.IconButton btn_Menu1;
        private System.Windows.Forms.Timer timer_MenuShow;
        private System.Windows.Forms.Timer timer_MenuHide;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel_Content;
        private FontAwesome.Sharp.IconButton Btn_Examination;
        private FontAwesome.Sharp.IconButton Btn_FR14;
    }
}