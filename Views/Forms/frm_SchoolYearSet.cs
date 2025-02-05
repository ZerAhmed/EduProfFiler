using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduProfFiler.Logic.Presenter;
using EduProfFiler.Views.Interfaces;

namespace EduProfFiler.Views.Forms
{
    public partial class frm_SchoolYearSet : Form, ISchoolYears
    {
        presenter_SchoolYear presenterSchoolYear;

        public string SY_Code { get => txt_SYCode.Text.ToString(); set => txt_SYCode.Text = value.ToString(); }
        public string SY_Notes { get => txt_SYNotes.Text.ToString(); set => txt_SYNotes.Text = value.ToString(); }

        public frm_SchoolYearSet()
        {
            InitializeComponent();
            presenterSchoolYear = new presenter_SchoolYear(this);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool isInserted = presenterSchoolYear.SchoolYearsInsert();
            if (isInserted)
            {
                MessageBox.Show("لقد تم التسجيل بنجاح");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء التسجيل");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            bool isSaved = presenterSchoolYear.SchoolYearsUpdate();
            if (isSaved)
            {
                MessageBox.Show("لقد تم التعديل بنجاح");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء التعديل");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isDeleted = presenterSchoolYear.SchoolYearsDelete();
            if (isDeleted)
            {
                MessageBox.Show("لقد تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء الحذف");
            }
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            bool isDeletedAll = presenterSchoolYear.SchoolYearsDeleteAll();
            if (isDeletedAll)
            {
                MessageBox.Show("لقد تم حذف كل البيانات");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء الحذف");
            }
        }
        private void btn_Clearfields_Click(object sender, EventArgs e)
        {
            presenterSchoolYear.SchoolYearsClearFields();
        }
    }
}
