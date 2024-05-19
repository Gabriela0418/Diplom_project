﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media;

namespace Diplom_project
{
    public partial class AddExpen : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        public AddExpen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddExpen_Load(object sender, EventArgs e)
        {
            string manListCodeRequest = "SELECT * FROM Customers";
            loadElementToComboBox(manListCodeRequest, "Full_name_contact_person", manufCB);

            string compListCodeRequest = "SELECT * FROM Comp_reference_num";
            loadElementToComboBox(compListCodeRequest, "Name_component", compCB);
        }

        public void loadElementToComboBox(string stringQuery, string column, ComboBox myBox)
        {
            List<string> columnValues = GetColumnValues(stringQuery, column);
            myBox.Items.AddRange(columnValues.ToArray());
        }

        public List<string> GetColumnValues(string query, string columnName)
        {
            List<string> columnValues = new List<string>();

            SQLiteConnection myCon = new SQLiteConnection(database.getConnection());
            myCon.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, myCon))
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    columnValues.Add(columnValue);
                }
            }
            return columnValues;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var comp = compCB.Text;
            var man = manufCB.Text;
            var date_ = dateTimePicker1.Text;
            var fact = numTB.Text;

            string[] formats = { "dd MMMM yyyy 'г.'", "d MMMM yyyy 'г.'" };
            DateTime date = DateTime.MinValue;

            foreach (string format in formats)
            {
                if (DateTime.TryParseExact(date_, format, CultureInfo.GetCultureInfo("ru-RU"), DateTimeStyles.None, out date))
                {
                    break;
                }
            }
            string formattedDate = date.ToString("yyyy-MM-dd");


            // Получаем Comp_reference_num компонента по его названию
            string getCompRefNumQuery = $"SELECT Comp_reference_num FROM Comp_reference_num WHERE Name_component = '{comp}'";
            SQLiteCommand compRefNumCommand = new SQLiteCommand(getCompRefNumQuery, database.getConnection());
            long compRefNum = (long)compRefNumCommand.ExecuteScalar();

            // Проверяем, достаточно ли компонентов на складе
            string checkQuantityQuery = $"SELECT Quantity FROM Comp_reference_num WHERE Comp_reference_num = {compRefNum}";
            SQLiteCommand checkQuantityCommand = new SQLiteCommand(checkQuantityQuery, database.getConnection());
            long quantity = (long)checkQuantityCommand.ExecuteScalar();
            if (quantity < long.Parse(fact))
            {
                MessageBox.Show("Количество заказанных компонентов больше, чем на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var addQuery = $"INSERT INTO Expend_warehouse (Comp_reference_num, ID_Customers, Num_ordered, Date) " +
                $"VALUES ((SELECT Comp_reference_num FROM Comp_reference_num WHERE Name_component = '{comp}'), " +
                $"(SELECT ID_Customers FROM Customers WHERE Full_name_contact_person = '{man}'), " +
                $"'{fact}', '{formattedDate}')";

            // Увеличиваем количество компонентов на складе
            string updateQuantityQuery = $"UPDATE Comp_reference_num SET Quantity = Quantity + {fact} WHERE Comp_reference_num = {compRefNum}";
            SQLiteCommand updateQuantityCommand = new SQLiteCommand(updateQuantityQuery, database.getConnection());
            updateQuantityCommand.ExecuteNonQuery();

            var command = new SQLiteCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!\n Необходимо обновить страницу", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
