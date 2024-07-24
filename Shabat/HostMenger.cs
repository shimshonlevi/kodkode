using host;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabatst
{
    internal class HostMenger
    {
        public static List<string> GetCatagores()
        {
            string sqlQuery = "select name from Categories";
            List<string> catagores = new List<string>();
            SqlDataReader reader = DBConnction.runSqlAllResult(sqlQuery);
            for (int i = 0; reader.Read(); i++)
            {
                catagores.Add(reader.GetString(0));
            }
            return catagores;
        }
        public static List<string> GetCatogoryByString(string filter)
        {
            string sqlQuery = "select name from Categories \r\nwhere name like '%' + @filter +'%'";
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

        public static void  AddCatagory(string newCatagory)
        {
            string sqlQuery = "if not exists(select name from Categories where name = @name)\r\n--אם לא קיים מכניס\r\n\tbegin\r\n\t\tinsert into Categories values(@name)\r\n\tend";
            string[] parameters = { "@name" };
            string[] values = { newCatagory };
            DBConnction.RunSqlNoReturn(sqlQuery, parameters, values);
            
        }

        public static DataTable GetFoodByCtgr(string categoryName)
        {
            string sqlQuery = "select Food.name as name,count(*)as quality\r\nfrom Food\r\njoin Categories on Categories.id = Food.Category_id\r\nwhere  Categories.name = @category_name\r\nGROUP BY Food.name;";
            string[] parameters = { "@category_name" };
            string[] values = { categoryName };
            return DBConnction.RunsqlTableResult(sqlQuery, parameters, values);
        }



    }
}
