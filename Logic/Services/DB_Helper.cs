using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Media.Animation;

namespace EduProfFiler.Logic.Services
{
    public static class DB_Helper
    {
        public static SqlCommand command;
        // هذه الدالة لجلب جملة الاتصال بقاعدة البيانات
        private static SqlConnection getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.BDName;
            builder.IntegratedSecurity = true;
            // الدالة ترجع جملة الاتصال
            return new SqlConnection(builder.ConnectionString);
        }
        // دالة الأدراج و التعديل والحذف من جداول قواعد البيانات
        public static bool executeData(string StoredProcedure_Name, Action addParameters)
        {
            using (SqlConnection connection = getConnectionString())
            {
                try
                {
                    command = new SqlCommand(StoredProcedure_Name, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // استدعاء الدالة التي تضيف البارامترات التي تحتاجها الأمر
                    addParameters.Invoke();

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
                finally
                {
                    // إغلاق الاتصال بقاعدة البيانات
                    connection.Close();
                }
                
            }
        }
    }
}
