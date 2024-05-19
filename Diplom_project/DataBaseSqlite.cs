using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace Diplom_project
{
    public class DataBaseSqlite
    {
        SQLiteConnection sqliteConnection = new SQLiteConnection(@"Data Source = D:\SQLite\Diplom.db; Version=3;");

        
        public long ExecuteScalar(string query)
        {
            sqliteConnection.Open();
            SQLiteCommand command = new SQLiteCommand(query, sqliteConnection);
            long result = (long)command.ExecuteScalar();
            sqliteConnection.Close();
            return result;
        }

        /// <summary>
        /// Открытие соединения с базой данных SQLite
        /// </summary>
        public void openConnection()
        {
            if (sqliteConnection.State == System.Data.ConnectionState.Closed)
                sqliteConnection.Open();
        }

        /// <summary>
        /// Закрытие соединения с базой данных SQLite
        /// </summary>
        public void closeConnection()
        {
            if (sqliteConnection.State == System.Data.ConnectionState.Open)
                sqliteConnection.Close();
        }

        /// <summary>
        /// Получение соединения с базой данных SQLite
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection getConnection()
        {
            return sqliteConnection;
        }
    }
}
