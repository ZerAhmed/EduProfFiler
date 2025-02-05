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
    public partial class frm_ClassesSet : Form, IClasses
    {
        presenter_Classes presenterClasses;

        public string Cl_Code { get => txt_ClCode.Text.ToString(); set => txt_ClCode.Text = value.ToString(); }
        public string Cl_Name { get => txt_ClName.Text.ToString(); set => txt_ClName.Text = value.ToString(); }
        public string Cl_Grade { get => txt_ClGrade.Text.ToString(); set => txt_ClGrade.Text = value.ToString(); }
        public string SY_Code { get => txt_SYCode.Text.ToString(); set => txt_SYCode.Text = value.ToString(); }

        public frm_ClassesSet()
        {
            InitializeComponent();
            presenterClasses = new presenter_Classes(this);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            bool isInserted = presenterClasses.ClassesInsert();
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
            bool isUpdated = presenterClasses.ClassesUpdate();
            if (isUpdated)
            {
                MessageBox.Show("لقد تم التعديل بنجاج");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء التعديل");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isDleleted = presenterClasses.ClassesDelete();
            if (isDleleted)
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
            bool isDleletedAll = presenterClasses.ClassesDeleteAll();
            if (isDleletedAll)
            {
                MessageBox.Show("لقد تم حذف جميع البيانات بنجاح");
            }
            else
            {
                MessageBox.Show("حدث مشكل أثناء الحذف");
            }
        }
        private void btn_Clearfields_Click(object sender, EventArgs e)
        {
            presenterClasses.SchoolYearsClearFields();
        }

    }
}

