using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduProfFiler.Logic.Services;
using EduProfFiler.Models;
using EduProfFiler.Views.Interfaces;

namespace EduProfFiler.Logic.Presenter
{
    public class presenter_Classes
    {
        IClasses iClasses;
        model_Classes modelClasse = new model_Classes();

        // دالة الكونستراكتور بنفس اسم الكلاس تنفد قبل أكواد الكلاس عند استدعاء الكلاس من أي مكان
        public presenter_Classes(IClasses view)
        {
            this.iClasses = view;
        }

        //دالة الربط بين الموديل والإنترفيس
        public void connectModelInterface()
        {
            modelClasse.Cl_Code = iClasses.Cl_Code;
            modelClasse.Cl_Name = iClasses.Cl_Name;
            modelClasse.Cl_Grade = iClasses.Cl_Grade;
            modelClasse.SY_Code = iClasses.SY_Code;
        }

        // النداء على دالة الإدخال
        public bool ClassesInsert()
        {
            connectModelInterface();
            return services_Classes.Classes_Insert(modelClasse.Cl_Code, modelClasse.Cl_Name, modelClasse.Cl_Grade, modelClasse.SY_Code);
        }

        // النداء على دالة التعديل
        public bool ClassesUpdate()
        {
            connectModelInterface();
            return services_Classes.Classes_Update(modelClasse.Cl_Code, modelClasse.Cl_Name, modelClasse.Cl_Grade, modelClasse.SY_Code);
        }

        // النداء على دالة الحذف
        public bool ClassesDelete()
        {
            connectModelInterface();
            return services_Classes.Classes_Delete(modelClasse.Cl_Code);
        }

        // النداء على دالة حذف الكل
        public bool ClassesDeleteAll()
        {
            connectModelInterface();
            return services_Classes.Classes_DeleteAll();
        }

        // دالة إفراغ الحقول
        public void SchoolYearsClearFields()
        {
            connectModelInterface();
            iClasses.Cl_Code = "";
            iClasses.Cl_Name = "";
            iClasses.Cl_Grade = "";
            iClasses.SY_Code = "";
        }
    }
}
