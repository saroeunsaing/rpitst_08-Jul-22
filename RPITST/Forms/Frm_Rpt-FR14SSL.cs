using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace RPITST.Forms
{
  
    public partial class Frm_Rpt_FR14SSL : Form
    {
        SQL_Control sql = new SQL_Control();

        public Frm_Rpt_FR14SSL()
        {
            InitializeComponent();
            
        }

        private void Frm_Rpt_FR14SSL_Load(object sender, EventArgs e)
        {


            Reports.CR_FR14SSL rpt = new Reports.CR_FR14SSL();


            //pass value from form to textobject using combobox text 
            TextObject rpt_academic = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Report_Academics"];
            TextObject rpt_semester = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Report_Semesters"];

            TextObject rpt_days = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Report_Days"];
            TextObject rpt_months = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Report_Months"];
            TextObject rpt_years = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Report_Years"];

            rpt_academic.Text = Frm_FR14_StudentList.academics;
            rpt_semester.Text = Frm_FR14_StudentList.semesters;
            rpt_days.Text = Frm_FR14_StudentList.e_days;
            rpt_months.Text = Frm_FR14_StudentList.e_months;
            rpt_years.Text = Frm_FR14_StudentList.e_years;

            //CALL CRYSTALL REPORT
            DataView dview = new DataView();
            dview.Table = sql.LoadReport("select * from registerkh WHERE level = N'" + Frm_FR14_StudentList.levels + "' and specialty = N'" + Frm_FR14_StudentList.specialty + "' and years = N'" + Frm_FR14_StudentList.years + "' ", "register_2022").Tables["register_2022"];

            rpt.SetDataSource(dview);
            crystalReportViewer1.ReportSource = rpt;
            //_ = crystalReportViewer1.DataBindings;
            ///* where level = '" + frm.Cmb_Level.Text + "' and specialty = '" + frm.Cmb_Specialty.Text + "' and years = '" + ((Frm_FR14_StudentList)Owner).Cmb_Year.Text + "' and years = '" + ((Frm_FR14_StudentList)this.Owner).Cmb_Year.*/
            //Text + "'
        }

        
    }
}
