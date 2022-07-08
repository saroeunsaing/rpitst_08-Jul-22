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
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panel_Content.Controls.Count > 0)
                this.panel_Content.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Content.Controls.Add(fh);
            this.panel_Content.Tag = fh;
            fh.Show();
        }



        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            btn_Restore.Visible = true;
            btn_Maximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
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
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Width == 300)
            {
                timer_MenuHide.Enabled = true;
            }
            else if (panel_Menu.Width == 40)
            {
                timer_MenuShow.Enabled = true;
            }
        }

     
        private void timer_MenuShow_Tick(object sender, EventArgs e)
        {
            if (panel_Menu.Width >= 300)
            {
                this.timer_MenuShow.Enabled = false;
                
            }
            else
            {
                this.panel_Menu.Width = panel_Menu.Width + 20;
            }
           
        }

        private void timer_MenuHide_Tick(object sender, EventArgs e)
        {
            if (panel_Menu.Width <= 40)
            {
                this.timer_MenuHide.Enabled = false;
                
            }
            else
            {
                this.panel_Menu.Width = panel_Menu.Width - 20;
            }
            
        }

        private void btn_Menu1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_Academic());
        }

        private void Btn_Examination_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Examination frm = new Frm_Examination();
            frm.Show();
        }

        private void Btn_FR14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_FR14_StudentList frm = new Frm_FR14_StudentList();
            frm.Show();
        }
    }
}
