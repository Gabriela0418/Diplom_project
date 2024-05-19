using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Diplom_project
{
    public partial class AddForm : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            string typeListCodeRequest = "SELECT * FROM Types_comp";
            loadElementToComboBox(typeListCodeRequest, "Name_type", typeComboBox);

            string manListCodeRequest = "SELECT * FROM Manufacturers";
            loadElementToComboBox(manListCodeRequest, "Man_name", manufCB);

            string edListCodeRequest = "SELECT * FROM Nom_unites_measurement";
            loadElementToComboBox(edListCodeRequest, "Name", edCB);
        }

        public void addBtn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var name = nameTB.Text;
            var type = typeComboBox.Text;
            var des = desTB.Text;
            var manuf = manufCB.Text;
            var fact = numTB.Text;
            var nominal = nomTB.Text;
            var unit = edCB.Text;
            var quantity = colTB.Text;

            var addQuery = $"INSERT INTO Comp_reference_num (Name_component, ID_types_comp, Description, " +
                $"ID_manufacturers, Factory_part_num, Nominal, Nom_unites_measurement, Quantity) " +
                $"VALUES ('{name}', (SELECT ID_types_comp FROM Types_comp WHERE Name_type = '{type}'), " +
                $"'{des}', (SELECT ID_manufacturers FROM Manufacturers WHERE Man_name = '{manuf}'), " +
                $"'{fact}', '{nominal}', " +
                $"(SELECT Nom_unites_measurement FROM Nom_unites_measurement WHERE Name = '{unit}'), '{quantity}')";

            var command = new SQLiteCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}