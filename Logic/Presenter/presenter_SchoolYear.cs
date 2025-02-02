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
    class presenter_SchoolYear
    {
        ISchoolYear ischoolYear;
        model_SchoolYear modelSchoolYear = new model_SchoolYear();

        // دالة الكونستراكتور بنفس اسم الكلاس تنفد قبل أكواد الكلاس عند استدعاء الكلاس من أي مكان
        public presenter_SchoolYear(ISchoolYear view)
        {
            this.ischoolYear = view;
        }
        //دالة الربط بين الموديل والإنترفيس
        public void connectModelInterface()
        {
            modelSchoolYear.SY_Code = ischoolYear.SY_Code;
            modelSchoolYear.SY_Notes = ischoolYear.SY_Notes;
        }

        public bool SchoolYearsInsert()
        {
            connectModelInterface();
            return services_SchoolYear.SchoolYears_Insert(modelSchoolYear.SY_Code, modelSchoolYear.SY_Notes);
        }
    }
}
