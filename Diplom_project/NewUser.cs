using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diplom_project
{
    public class NewUser
    {
        DataBaseSqlite database = new DataBaseSqlite();
        public static int ID { get; private set; }
        public static string FIO { get; private set; }
        public static string Status { get; private set; }
        public static string Login { get; private set; }
        public static string Password { get; private set; }

        public bool SetPersonalData(string login, string password)
        {
            string sqlExpression = "SELECT ID, FIO, Status, Login,  Password  FROM Account \r\n" +
                "WHERE Account.Login = @Login AND Account.Password = @Password LIMIT 1";
            database.openConnection();
            SQLiteCommand command = new SQLiteCommand(sqlExpression, database.getConnection());
            command.Parameters.AddWithValue("@Login", login);
            command.Parameters.AddWithValue("@Password", password);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ID = Convert.ToInt32(reader["ID"]);
                FIO = reader["FIO"].ToString();
                Status = reader["Status"].ToString();
                Login = reader["Login"].ToString();
                Password = reader["Password"].ToString();
                return true;
            }
            return false;
        }
    }
}
