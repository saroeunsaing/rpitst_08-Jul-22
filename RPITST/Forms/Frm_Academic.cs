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
    public partial class Frm_Academic : Form
    {
        public Frm_Academic()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Academic_Load(object sender, EventArgs e)
        {
            CueBannerText.SetCueText(txt_ID, "លេខសម្គាល់");
            CueBannerText.SetCueText(txt_NameKH, "ឆ្នាំសិក្សា");
            CueBannerText.SetCueText(txt_NameEN, "ជាឡាតាំង");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
