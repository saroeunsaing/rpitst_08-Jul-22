
namespace RPITST.Forms
{
    partial class Frm_Shift
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cboX = new System.Windows.Forms.ComboBox();
            this.cboY = new System.Windows.Forms.ComboBox();
            this.cboZ = new System.Windows.Forms.ComboBox();
            this.chkSumValues = new System.Windows.Forms.CheckBox();
            this.txttNullValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(605, 183);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboX
            // 
            this.cboX.FormattingEnabled = true;
            this.cboX.Location = new System.Drawing.Point(201, 13);
            this.cboX.Name = "cboX";
            this.cboX.Size = new System.Drawing.Size(65, 21);
            this.cboX.TabIndex = 3;
            // 
            // cboY
            // 
            this.cboY.FormattingEnabled = true;
            this.cboY.Location = new System.Drawing.Point(289, 15);
            this.cboY.Name = "cboY";
            this.cboY.Size = new System.Drawing.Size(75, 21);
            this.cboY.TabIndex = 4;
            // 
            // cboZ
            // 
            this.cboZ.FormattingEnabled = true;
            this.cboZ.Location = new System.Drawing.Point(383, 15);
            this.cboZ.Name = "cboZ";
            this.cboZ.Size = new System.Drawing.Size(80, 21);
            this.cboZ.TabIndex = 5;
            // 
            // chkSumValues
            // 
            this.chkSumValues.AutoSize = true;
            this.chkSumValues.Location = new System.Drawing.Point(469, 38);
            this.chkSumValues.Name = "chkSumValues";
            this.chkSumValues.Size = new System.Drawing.Size(82, 17);
            this.chkSumValues.TabIndex = 15;
            this.chkSumValues.Text = "Sum Values";
            this.chkSumValues.UseVisualStyleBackColor = true;
            // 
            // txttNullValue
            // 
            this.txttNullValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttNullValue.Location = new System.Drawing.Point(469, 12);
            this.txttNullValue.Name = "txttNullValue";
            this.txttNullValue.Size = new System.Drawing.Size(82, 20);
            this.txttNullValue.TabIndex = 14;
            this.txttNullValue.Text = "-";
            // 
            // Frm_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 400);
            this.Controls.Add(this.chkSumValues);
            this.Controls.Add(this.txttNullValue);
            this.Controls.Add(this.cboZ);
            this.Controls.Add(this.cboY);
            this.Controls.Add(this.cboX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Shift";
            this.Text = "Frm_Shift";
            this.Load += new System.EventHandler(this.Frm_Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboX;
        private System.Windows.Forms.ComboBox cboY;
        private System.Windows.Forms.ComboBox cboZ;
        private System.Windows.Forms.CheckBox chkSumValues;
        private System.Windows.Forms.TextBox txttNullValue;
    }
}