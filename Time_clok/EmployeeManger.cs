using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_clok;

namespace Time_clock
{
    internal class EmployeeManger
    {
        private static string _loginSQL = "declare  @code int, @answer VARCHAR(250), @fullName VARCHAR(20)='';\r\nIF exists (select * from Employees where id= @id)\r\n\tbegin\r\n\t\t--find the code from the exists employee\r\n\t\tselect @code = (select code from Employees where id=@id)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\t\t-- הוספת עובד לטבלה\r\n\t\t\tINSERT into Employees values ( @id, @fullName);\r\n\t\t\tselect @code=@@IDENTITY;\r\n\t\tend\r\nIF exists (select * from Passwords WHERE employee_code=@code)\r\n\tbegin\r\n\t\tif exists (select password_string From Passwords\r\n\t\t\t\t\tWHERE employee_code=@code AND password_string=@password\r\n\t\t\t\t\tAND has_access=1 )\r\n\t\t\t\tbegin\r\n\t\t\t\t\tif exists (select password_string From Passwords\r\n\t\t\t\t\tWHERE employee_code=@code AND password_string=@password\r\n\t\t\t\t\tAND has_access=1 AND  password_expiry_date>=getdate())\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tIF exists (SELECT * FROM Clock_Time\r\n\t\t\t\t\t\t\tWHERE employee_code=@code AND exit_time is null)\r\n\t\t\t\t\t\t\t\tbegin \t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\tUPDATE Clock_Time set exit_time=GETDATE()\r\n\t\t\t\t\t\t\t\t\tWHERE employee_code=@code AND exit_time is null;\r\n\t\t\t\t\t\t\t\t\tselect @answer='Exit time: ' + CONVERT (NVARCHAR, GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tINSERT INTO Clock_Time  VALUES (@code, GETDATE(), null);\r\n\t\t\t\t\t\t\t\tselect @answer='Entry time: ' + CONVERT (NVARCHAR, GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\tend\r\n\t\t\t\t\tELSE\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @answer= 'you need to update your password';\r\n\t\t\t\t\t\tend\r\n\t\t\t\tend\r\n\t\tELSE\r\n\t\t\tbegin\r\n\t\t\tselect @answer = 'wrong password';\r\n\t\t\tend\r\n\tend\r\nELSE\r\n\tbegin\r\n\t\tINSERT INTO\tPasswords VALUES (@code, @password,\r\n\t\tDATEADD(day, 180, GETDATE()),\r\n\t\t1)\r\n\t\tselect @answer= 'You created a worker and password';\r\n\tend \nselect @answer";

        private static string _changePasswordSQL = "declare @answer varchar (100) = ''\r\n\r\n\tif exists(\r\n\tselect password_string from Passwords\r\n\tjoin Employees on Employees.code = Passwords.employee_code\r\n\twhere Employees.id = @id_number and Passwords.password_string = @old_pass and Passwords.has_access = 1\r\n\t)\r\n\tbegin\r\n\t\t--בדיקת האם הסיסמא החדשה שונה מהישנה\r\n\t\tif exists(\r\n\t\tselect password_string from Passwords\r\n\t\tjoin Employees on Employees.code = Passwords.employee_code\r\n\t\twhere Employees.id = @id_number and Passwords.password_string =\r\n\t\t@old_pass and Passwords.has_access = 1 and @new_password != @old_pass\r\n\t\t)\r\n\t\t\tbegin\r\n\t\t\t\tif exists(\r\n\t\t\t\tselect password_string from Passwords\r\n\t\t\t\tjoin Employees on Employees.code = Passwords.employee_code\r\n\t\t\t\twhere Employees.id = @id_number and Passwords.password_string =\r\n\t\t\t\t@old_pass and Passwords.has_access = 1 and @new_password != @old_pass \r\n\t\t\t\tand @new_password = @validation_new_password \r\n\t\t\t\t) \r\n\t\r\n\t\t\t\t\tbegin \r\n\t\t\t\t\tupdate Passwords\r\n\t\t\t\t\tset has_access = 0\r\n\t\t\t\t\tfrom Passwords\r\n\t\t\t\t\tjoin Employees on Employees.code = Passwords.employee_code\r\n\t\t\t\t\twhere Employees.id = @id_number \r\n\t\t\t\t\tand Passwords.password_string = @old_pass\r\n\r\n\t\t\t\t\t      -- הוספת שורה חדשה עם הסיסמה החדשה\r\n\t\t\t\t\tinsert into Passwords (employee_code, password_string,password_expiry_date, has_access)\r\n\t\t\t\t\tselect Employees.code, @new_password,DATEADD(day, 180, GETDATE()), 1\r\n\t\t\t\t\tfrom Employees\r\n\t\t\t\t\twhere Employees.id = @id_number\r\n\r\n\t\t\t\t\tselect @answer = 'Password changed successfully'\r\n\t\t\t\t\tend\r\n\r\n\t\t\t\r\n\r\n\t\t\t\t\telse \r\n\t\t\t\t\tbegin\r\n\t\t\t\t\tselect @answer = 'The passwords are incorrect'\r\n\t\t\t\t\tend\r\n\r\n\t\t\t\tend\r\n\r\n\t\telse\r\n\t\tbegin\r\n\t\tselect @answer =  'Enter a password that has not been used'\r\n\t\tend\r\n\tend\r\n\t\t\t\t\t\t\r\nelse \r\nbegin\r\nselect @answer = 'One of the details is wrong'\r\nend\r\n\r\n\r\nselect @answer\t";
        public void doX()
        {
        }
        public static string Login(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password" };
            string[] values = { id, password };
            string result = DBConnction.runSQL(_loginSQL, parameters, values);
            // 3. Return response
            return result;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            string[] parameters = { "@id_number", "@old_pass", "@new_password", "@validation_new_password" };
            string[] values = { id, oldPass, newPass, confirmPass };
            string result = DBConnction.runSQL(_changePasswordSQL, parameters, values);
            return result;
        }
    }

    
}
