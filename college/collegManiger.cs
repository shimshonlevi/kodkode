using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Xml.Linq;

namespace college
{
    internal class collegManiger
    {
        public static List<string> Getcourses(string studentName)
        {
            string sqlQuery = "SELECT Courses.name\r\nFROM Courses\r\nWHERE Courses.id NOT IN (\r\n    SELECT studens_and_courss.cours_id\r\n    FROM studens_and_courss\r\n    JOIN Studens ON studens_and_courss.student_id = Studens.id\r\n    WHERE Studens.name = @student_name\r\n);";

            List<string> courses = new List<string>();
            SqlDataReader reader = null;
            try
            {
                // הוספת פרמטרים לשאילתה
                string[] parameters = { "@student_name" };
                string[] values = { studentName };

                reader = DBConnction.runSqlAllResult(sqlQuery, parameters, values);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        courses.Add(reader.GetString(0));
                    }
                }
            }
            finally
            {
                // סגירת ה- SqlDataReader
                reader?.Close();
            }
            return courses;
        }

        public void DisplayCourseDetails(string courseName)
        {
            
        }

        public static List<string> GetcoursesByString(string filter)
        {
            string sqlQuery = "select name from Courses where name like '%' + @filter +'%'";
            string[] parametrs = { "@filter" };
            string[] values = { filter };
            List<string> catagores = new List<string>();
            SqlDataReader reader = DBConnction.runSqlAllResult(sqlQuery, parametrs, values);
            for (int i = 0; reader.Read(); i++)
            {
                catagores.Add(reader.GetString(0));
            }
            return catagores;

        }



        public static List<string> GetStudentCourses(string studentName)
        {
            string query = "SELECT Courses.name " +
                           "FROM Courses " +
                           "JOIN studens_and_courss ON Courses.id = studens_and_courss.cours_id " +
                           "JOIN Studens ON studens_and_courss.student_id = Studens.id " +
                           "WHERE Studens.name = @StudentName";

            string[] parameters = { "@StudentName" };
            string[] values = { studentName };

            List<string> courses = new List<string>();
            SqlDataReader reader = DBConnction.runSqlAllResult(query, parameters, values);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    courses.Add(reader.GetString(0));
                }
            }
            reader.Close();
            return courses;
        }



        public static DataTable GetsobjectByCours(string category)
        {
            string query = "SELECT day_in_week, start_date, subjects.namw AS subject_name, Teachers.name AS lecturer \r\n                           FROM Courses\r\n                           INNER JOIN Times ON Courses.id = Times.cours_id \r\n                           INNER JOIN Subjects ON Courses.id = Subjects.subjects_id \r\n                           INNER JOIN Teachers ON Subjects.teacher_id = Teachers.teacher_id \r\n                           WHERE Courses.name = @cours";

          
            string[] parameters = { "@cours" };
            string[] values = { category };

          
            return DBConnction.RunsqlTableResult(query, parameters, values);
        }

        public static bool AddCourseToStudent(string studentName, string courseName)
        {
            // שאילתה להוספת סטודנט או קורס
            string query = "IF NOT EXISTS (SELECT 1 FROM Studens WHERE name = @StudentName)\r\nBEGIN\r\n    INSERT INTO Studens (name, Amount_to_pay) VALUES (@StudentName, 0);\r\nEND\r\n\r\nINSERT INTO studens_and_courss (student_id, cours_id)\r\nSELECT s.id, c.id\r\nFROM Studens s\r\nCROSS JOIN Courses c\r\nWHERE s.name = @StudentName AND c.name = @CourseName;";

            string[] parameters = { "@StudentName", "@CourseName" };
            string[] values = { studentName, courseName };

            try
            {
               
                DBConnction.RunSqlNoReturn(query, parameters, values);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" שגיאה: " + ex.Message);
                return false;
            }
        }


        //public static void AddCatagory(string newCatagory)
        //{
        //    string sqlQuery = "if not exists(select name from Categories where name = @name)\r\n--אם לא קיים מכניס\r\n\tbegin\r\n\t\tinsert into Categories values(@name)\r\n\tend";
        //    string[] parameters = { "@name" };
        //    string[] values = { newCatagory };
        //    DBConnction.RunSqlNoReturn(sqlQuery, parameters, values);

        //}

        //public static DataTable GetFoodByCtgr(string categoryName)
        //{
        //    string sqlQuery = "select Food.name as name,count(*)as quality\r\nfrom Food\r\njoin Categories on Categories.id = Food.Category_id\r\nwhere  Categories.name = @category_name\r\nGROUP BY Food.name;";
        //    string[] parameters = { "@category_name" };
        //    string[] values = { categoryName };
        //    return DBConnction.RunsqlTableResult(sqlQuery, parameters, values);
        //}



    }

}
