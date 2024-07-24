using host;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabat
{
    internal class guostMeniger
    {
        // מחזיר רשימה של כל הקטגוריות
        public static List<string> GetCatagores()
        {
            // שאילתה לקבלת שמות כל הקטגוריות
            string sqlQuery = "select name from Categories";
            List<string> catagores = new List<string>();

            // מבצע את השאילתה ומחזיר את כל התוצאות
            SqlDataReader reader = DBConnction.runSqlAllResult(sqlQuery);

            // עובר על כל התוצאות ומוסיף את שם הקטגוריה לרשימה
            while (reader.Read())
            {
                catagores.Add(reader.GetString(0));
            }

            return catagores;
        }

        // מחזיר רשימה של קטגוריות שמכילות את המחרוזת הנתונה
        public static List<string> GetCatogoryByString(string filter)
        {
            // שאילתה לחיפוש קטגוריות שמכילות את המחרוזת הנתונה
            string sqlQuery = "select name from Guests where name like '%' + @filter +'%'";
            string[] parametrs = { "@filter" };
            string[] values = { filter };
            List<string> catagores = new List<string>();

            // מבצע את השאילתה ומחזיר את כל התוצאות
            SqlDataReader reader = DBConnction.runSqlAllResult(sqlQuery, parametrs, values);

            // עובר על כל התוצאות ומוסיף את שם הקטגוריה לרשימה
            while (reader.Read())
            {
                catagores.Add(reader.GetString(0));
            }

            return catagores;
        }

        // מוסיף קטגוריה חדשה אם היא לא קיימת כבר
        public static void AddCatagory(string newCatagory)
        {
            // שאילתה להוספת קטגוריה חדשה אם היא לא קיימת
            string sqlQuery = "if not exists(select name from Guests where name = @name)\r\nbegin\r\n\tinsert into Guests values(@name)\r\nend";
            string[] parameters = { "@name" };
            string[] values = { newCatagory };

            // מבצע את השאילתה
            DBConnction.RunSqlNoReturn(sqlQuery, parameters, values);
        }

        // מחזיר טבלה של שמות האוכל בקטגוריה הנתונה שלא הוזמנו על ידי אורח מסוים
        public static DataTable GetFoodByCtgr(string categoryName)
        {
            // שאילתה לקבלת שמות האוכל בקטגוריה הנתונה שלא הוזמנו על ידי אורח מסוים
            string sqlQuery = "SELECT f.name AS food_name\r\nFROM Food f\r\nJOIN Categories c ON f.Category_id = c.id\r\nWHERE f.Guests_id IS NULL OR f.Guests_id != (SELECT id FROM Guests WHERE name = @guest_name);";
            string[] parameters = { "@guest_name" };
            string[] values = { categoryName };

            // מבצע את השאילתה ומחזיר את התוצאות בטבלה
            return DBConnction.RunsqlTableResult(sqlQuery, parameters, values);
        }

        // מחזיר טבלה של שמות האוכל וכמות ההזמנות לפי קטגוריה ושם אורח
        public static DataTable GetFoodByName(string categoryName)
        {
            // שאילתה לקבלת שמות האוכל וכמות ההזמנות לפי קטגוריה ושם אורח
            string sqlQuery = "SELECT f.name AS name, COUNT(f.name) AS count\r\nFROM Food f\r\nJOIN Categories c ON c.id = f.Category_id\r\nJOIN Guests g ON g.id = f.Guests_id\r\nWHERE c.name = @category_name4 AND g.name = @user_name1\r\nGROUP BY f.name;";
            string[] parameters = { "@category_name4" };
            string[] values = { categoryName };

            // מבצע את השאילתה ומחזיר את התוצאות בטבלה
            return DBConnction.RunsqlTableResult(sqlQuery, parameters, values);
        }
    }
}
