using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace host
{
    internal class DBConnction
    {
        // משתנה שמחזיק את החיבור למסד הנתונים
        static SqlConnection sqlConnection;
        // משתנה שמחזיק את מחרוזת החיבור למסד הנתונים
        static string connectionString = "server = MY-COMPUTER;initial catalog= shabat; user id=sa; password=1234;TrustServerCertificate=Yes";

        // פונקציה שמבצעת חיבור למסד הנתונים
        public static bool Connect()
        {
            try
            {
                // יצירת אובייקט SqlConnection ופתיחת חיבור
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                // הצגת הודעת שגיאה במקרה של כישלון חיבור
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // פונקציה להרצת שאילתת SQL שמחזירה תוצאה בודדת
        public static string runSQL(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    // הוספת פרמטרים לשאילתה
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }

                    // הרצת השאילתה והחזרת התוצאה
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    // החזרת הודעת שגיאה במקרה של כישלון
                    return ex.Message;
                }
            }
            return "";
        }

        // פונקציה להרצת שאילתת SQL שמחזירה DataReader
        public static SqlDataReader runSqlAllResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    // הוספת פרמטרים לשאילתה
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }

                    // הרצת השאילתה והחזרת DataReader
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    // החזרת null במקרה של שגיאה
                    return null;
                }
            }
            return null;
        }

        // פונקציה להרצת שאילתת SQL שמחזירה DataTable
        public static DataTable RunsqlTableResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    // הוספת פרמטרים לשאילתה
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }

                    // יצירת SqlDataAdapter למילוי DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    // החזרת null במקרה של שגיאה
                    return null;
                }
            }
            return null;
        }

        // פונקציה להרצת שאילתת SQL שלא מחזירה תוצאה
        public static void RunSqlNoReturn(string sql, string[] parmeters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;

                    // הוספת פרמטרים לשאילתה
                    if (parmeters != null && values != null)
                    {
                        for (int i = 0; i < parmeters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parmeters[i], values[i]);
                        }
                    }

                    // הרצת השאילתה
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // הצגת הודעת שגיאה במקרה של כישלון
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
