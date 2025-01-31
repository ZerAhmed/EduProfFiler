using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace EduProfFiler.Views.Forms
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ClassesSet classesSet = new frm_ClassesSet();
            classesSet.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_StudentsListSet StudentListeSet = new frm_StudentsListSet();
            StudentListeSet.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_UnitsAndSubjectsSet unitsAndSubjectsSet = new frm_UnitsAndSubjectsSet();
            unitsAndSubjectsSet.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_SchoolYearSet schoolYearSet = new frm_SchoolYearSet();
            schoolYearSet.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ContinuousAssessmentSet ContinuousAssessmentSet = new frm_ContinuousAssessmentSet();
            ContinuousAssessmentSet.Show();
        }
    }
}