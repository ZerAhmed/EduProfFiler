using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduProfFiler.Logic.Services
{
    public static class services_Classes
    {
        // هذه دالة الإدخال
        public static bool Classes_Insert(string Cl_Code, string Cl_Name, string Cl_Grade, string SY_Code)
        {
            return DB_Helper.executeData("Classes_Insert", () => Classes_AddParamInsert(Cl_Code, Cl_Name, Cl_Grade, SY_Code, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر الإدخال
        private static void Classes_AddParamInsert(string Cl_Code, string Cl_Name, string Cl_Grade, string SY_Code, SqlCommand command)
        {
            command.Parameters.Add("Cl_Code", SqlDbType.NVarChar, 50).Value = Cl_Code;
            command.Parameters.Add("Cl_Name", SqlDbType.NVarChar, 250).Value = Cl_Name;
            command.Parameters.Add("Cl_Grade", SqlDbType.NVarChar, 50).Value = Cl_Grade;
            command.Parameters.Add("SY_Code", SqlDbType.NVarChar, 250).Value = SY_Code;
        }

        // هذه دالة التعديل
        public static bool Classes_Update(string Cl_Code, string Cl_Name, string Cl_Grade, string SY_Code)
        {
            return DB_Helper.executeData("Classes_Update", () => Classes_AddParamUpdate(Cl_Code, Cl_Name, Cl_Grade, SY_Code, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر التعديل
        private static void Classes_AddParamUpdate(string Cl_Code, string Cl_Name, string Cl_Grade, string SY_Code, SqlCommand command)
        {
            command.Parameters.Add("Cl_Code", SqlDbType.NVarChar, 50).Value = Cl_Code;
            command.Parameters.Add("Cl_Name", SqlDbType.NVarChar, 250).Value = Cl_Name;
            command.Parameters.Add("Cl_Grade", SqlDbType.NVarChar, 50).Value = Cl_Grade;
            command.Parameters.Add("SY_Code", SqlDbType.NVarChar, 250).Value = SY_Code;
        }

        // هذه دالة الحذف
        public static bool Classes_Delete(string Cl_Code)
        {
            return DB_Helper.executeData("Classes_Delete", () => Classes_AddParamDelete(Cl_Code, DB_Helper.command));
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر الحذف
        private static void Classes_AddParamDelete(string Cl_Code, SqlCommand command)
        {
            command.Parameters.Add("Cl_Code", SqlDbType.NVarChar, 50).Value = Cl_Code;
        }

        // هذه دالة حذف الكل
        public static bool Classes_DeleteAll()
        {
            return DB_Helper.executeData("Classes_DeleteAll", () => Classes_AddParamDeleteAll());
        }

        // هذه الدالة لإضافة البارمترات الخاصة بأمر حذف الكل
        private static void Classes_AddParamDeleteAll()
        {
        }
    }
}