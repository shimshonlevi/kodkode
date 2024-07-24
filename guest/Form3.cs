using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace host
{
    internal class DBConnection
    {
        // משתנה שמחזיק את החיבור למסד הנתונים
        private static SqlConnection sqlConnection;
        // מחרוזת החיבור למסד הנתונים
        private static string connectionString = "server = MY-COMPUTER;initial catalog= shabat; user id=sa; password=1234;TrustServerCertificate=Yes";

        // פונקציה לחיבור למסד הנתונים
        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // פונקציה להרצת שאילתת SQL שמחזירה תוצאה אחת
        public static string RunSQL(string sql, string[] parameters = null, string[] values = null)
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
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";
        }

        // פונקציה להרצת שאילתת SQL שמחזירה מצביע לתוצאות
        public static SqlDataReader RunSqlAllResult(string sql, string[] parameters = null, string[] values = null)
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
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
            return null;
        }

        // פונקציה להרצת שאילתת SQL שמחזירה DataTable
        public static DataTable RunSqlTableResult(string sql, string[] parameters = null, string[] values = null)
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
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
            return null;
        }

        // פונקציה להרצת שאילתת SQL ללא תוצאה מוחזרת
        public static void RunSqlNoReturn(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // הוספת פרמטרים לשאילתה
                    if (parameters != null && values != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
