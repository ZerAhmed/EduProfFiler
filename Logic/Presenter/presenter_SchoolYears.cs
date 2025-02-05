using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduProfFiler.Models;
using EduProfFiler.Views.Interfaces;
using EduProfFiler.Logic.Services;

namespace EduProfFiler.Logic.Presenter
{
    public class presenter_SchoolYear
    {
        ISchoolYears ischoolYear;
        model_SchoolYears modelSchoolYear = new model_SchoolYears();

        // دالة الكونستراكتور بنفس اسم الكلاس تنفد قبل أكواد الكلاس عند استدعاء الكلاس من أي مكان
        public presenter_SchoolYear(ISchoolYears view)
        {
            this.ischoolYear = view;
        }
        //دالة الربط بين الموديل والإنترفيس
        public void connectModelInterface()
        {
            modelSchoolYear.SY_Code = ischoolYear.SY_Code;
            modelSchoolYear.SY_Notes = ischoolYear.SY_Notes;
        }
        // النداء على دالة الإدخال
        public bool SchoolYearsInsert()
        {
            connectModelInterface();
            return services_SchoolYear.SchoolYears_Insert(modelSchoolYear.SY_Code, modelSchoolYear.SY_Notes);
        }
        // النداء على دالة التعديل
        public bool SchoolYearsUpdate()
        {
            connectModelInterface();
            return services_SchoolYear.SchoolYears_Update(modelSchoolYear.SY_Code, modelSchoolYear.SY_Notes);
        }
        // النداء على دالة الحذف
        public bool SchoolYearsDelete()
        {
            connectModelInterface();
            return services_SchoolYear.SchoolYears_Delete(modelSchoolYear.SY_Code);
        }
        // النداء على دالة حذف كل البيانات
        public bool SchoolYearsDeleteAll()
        {
            connectModelInterface();
            return services_SchoolYear.SchoolYears_DeleteAll();
        }
        // دالة إفراغ الحقول
        public void SchoolYearsClearFields()
        {
            ischoolYear.SY_Code = "";
            ischoolYear.SY_Notes = "";
            connectModelInterface();
        }
    }
}
