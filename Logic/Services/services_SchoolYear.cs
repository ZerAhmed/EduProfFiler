using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduProfFiler.Logic.Services
{
    static class services_SchoolYear
    {
        // هذه دالة الإدخال
        public static bool SchoolYears_Insert(string SY_Code, string SY_Notes)
        {
            return DB_Helper.executeData("SchoolYears_Insert", ()=> schoolYear_AddParamInsert(SY_Code, SY_Notes, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر الإدخال
        private static void schoolYear_AddParamInsert(string SY_Code, string SY_Notes, SqlCommand command)
        {
            command.Parameters.Add("SY_Code", SqlDbType.NVarChar, 50).Value = SY_Code;
            command.Parameters.Add("SY_Notes", SqlDbType.NVarChar, 250).Value = SY_Notes;
        }

        // هذه دالة حذف تسجيل واحد
        public static bool SchoolYears_Delete(string SY_Code)
        {
            return DB_Helper.executeData("SchoolYears_Delete", () => schoolYear_AddParamDelete(SY_Code, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر حذف تسجيل واحد
        private static void schoolYear_AddParamDelete(string SY_Code, SqlCommand command)
        {
            command.Parameters.Add("SY_Code", SqlDbType.NVarChar, 50).Value = SY_Code;
        }

        // هذه دالة التعديل
        public static bool SchoolYears_Update(string SY_Code, string SY_Notes)
        {
            return DB_Helper.executeData("SchoolYears_Update", () => schoolYear_AddParamUpdate(SY_Code, SY_Notes, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر التعديل
        private static void schoolYear_AddParamUpdate(string SY_Code, string SY_Notes, SqlCommand command)
        {
            command.Parameters.Add("SY_Code", SqlDbType.NVarChar, 50).Value = SY_Code;
            command.Parameters.Add("SY_Notes", SqlDbType.NVarChar, 250).Value = SY_Notes;
        }
    }
}