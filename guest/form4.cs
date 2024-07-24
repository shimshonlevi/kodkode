using host;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Shabat
{
    internal class guostMeniger
    {
        // פונקציה לקבלת רשימת קטגוריות
        public static List<string> GetCatagores()
        {
            string sqlQuery = "select name from Categories";
            List<string> catagores = new List<string>();
            SqlDataReader reader = DBConnection.RunSqlAllResult(sqlQuery);
            while (reader.Read())
            {
                catagores.Add(reader.GetString(0));
            }
            return catagores;
        }

        // פונקציה לקבלת קטגוריות לפי מחרוזת חיפוש
        public static List<string> GetCatogoryByString(string filter)
        {
            string sqlQuery = "select name from Guests where name like '%' + @filter + '%'";
            string[] parameters = { "@filter" };
            string[] values = { filter };
            List<string> catagores = new List<string>();
            SqlDataReader reader = DBConnection.RunSqlAllResult(sqlQuery, parameters, values);
            while (reader.Read())
            {
                catagores.Add(reader.GetString(0));
            }
            return catagores;
        }

        // פונקציה להוספת קטגוריה חדשה
        public static void AddCatagory(string newCatagory)
        {
            string sqlQuery = "if not exists(select name from Guests where name = @name) begin insert into Guests values(@name) end";
            string[] parameters = { "@name" };
            string[] values = { newCatagory };
            DBConnection.RunSqlNoReturn(sqlQuery, parameters, values);
        }

        // פונקציה לקבלת נתוני מזון לפי קטגוריה
        public static DataTable GetFoodByCtgr(string categoryName)
        {
            string sqlQuery = "SELECT f.name AS food_name FROM Food f JOIN Categories c ON f.Category_id = c.id WHERE c.name = @category_name";
            string[] parameters = { "@category_name" };
            string[] values = { categoryName };
            return DBConnection.RunSqlTableResult(sqlQuery, parameters, values);
        }

        // פונקציה לקבלת נתוני מזון לפי שם אורח
        public static DataTable GetFoodByName(string guestName)
        {
            string sqlQuery = "SELECT f.name AS name, COUNT(f.name) AS count FROM Food f JOIN Categories c ON c.id = f.Category_id JOIN Guests g ON g.id = f.Guests_id WHERE g.name = @guest_name GROUP BY f.name";
            string[] parameters = { "@guest_name" };
            string[] values = { guestName };
            return DBConnection.RunSqlTableResult(sqlQuery, parameters, values);
        }
    }
}
