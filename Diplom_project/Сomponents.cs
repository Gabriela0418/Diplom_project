using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;

namespace Diplom_project
{
    enum RowState
    { 
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Сomponents : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        int selectedRow;
        public Сomponents()
        {
            InitializeComponent();
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("Comp_reference_num", "Инвентарный номер");
            dataGridView1.Columns.Add("Name_component", "Наименование компонента");
            dataGridView1.Columns.Add("ID_types_comp", "Тип компонента");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("ID_manufacturers", "Производитель");
            dataGridView1.Columns.Add("Factory_part_num", "Заводской номер детали");
            dataGridView1.Columns.Add("Nominal", "Номинал");
            dataGridView1.Columns.Add("Nom_unites_measurement", "Единица измерения");
            dataGridView1.Columns.Add("Quantity", "Количество компонентов");
            dataGridView1.Columns.Add("IsNew",String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetValue(0),       // Comp_reference_num - INTEGER
                record.GetValue(1),       // Name_component - TEXT
                record.GetValue(2),       // ID_types_comp - INTEGER
                record.GetValue(3),       // Description - TEXT
                record.GetValue(4),       // ID_manufacturers - INTEGER
                record.GetValue(5),       // Factory_part_num - TEXT
                record.GetValue(6),       // Nominal - INTEGER
                record.GetValue(7),       // Nom_unites_measurement - INTEGER
                record.GetValue(8),       // Quantity - INTEGER
                RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            try
            {
                string queryString = "SELECT Comp_reference_num.Comp_reference_num, " +
                    "Comp_reference_num.Name_component, " +
                    "Types_comp.Name_type, " +
                    "Comp_reference_num.Description, " +
                    "Manufacturers.Man_name, " +
                    "Comp_reference_num.Factory_part_num, " +
                    "Comp_reference_num.Nominal, " +
                    "Nom_unites_measurement.Name, " +
                    "Comp_reference_num.Quantity " +
                    "FROM Comp_reference_num " +
                    "JOIN Types_comp ON Types_comp.ID_types_comp = Comp_reference_num.ID_types_comp " +
                    "JOIN Manufacturers ON Manufacturers.ID_manufacturers = Comp_reference_num.ID_manufacturers " +
                    "JOIN Nom_unites_measurement ON Nom_unites_measurement.Nom_unites_measurement = Comp_reference_num.Nom_unites_measurement";
                SQLiteCommand sqlCommand = new SQLiteCommand(queryString, database.getConnection());
                database.openConnection();
                SQLiteDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                    ReadSingleRow(dataGridView, reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при заполнении таблицы: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void Сomponents_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);

            string typeListCodeRequest = "SELECT * FROM Types_comp";
            loadElementToComboBox(typeListCodeRequest, "Name_type", typeComboBox);

            string manListCodeRequest = "SELECT * FROM Manufacturers";
            loadElementToComboBox(manListCodeRequest, "Man_name", manufCB);

            string edListCodeRequest = "SELECT * FROM Nom_unites_measurement";
            loadElementToComboBox(edListCodeRequest, "Name", edCB);

            checkRole(NewUser.Status.ToUpper());

            dataGridView1.Columns["IsNew"].Visible = false;
        }

        private string checkRole(string role)
        {
            switch (role)
            {
                case ("АДМИН"):
                    del_button.Visible = true;
                    return role;
                case ("РАБОТНИК"):
                    del_button.Visible = false;
                    return role;
                default: return role;
            }
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

        private void add_button_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var daleteQuery = $"DELETE FROM Comp_reference_num WHERE Comp_reference_num = {id}";
                    var command = new SQLiteCommand(daleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var type = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var des = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var manuf = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var fact = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var nominal = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var unit = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var quantity = dataGridView1.Rows[index].Cells[8].Value.ToString();

                        var addQuery = $"UPDATE Comp_reference_num SET Name_component = '{name}', ID_types_comp = (SELECT ID_types_comp FROM Types_comp WHERE Name_type = '{type}'), " +
                        $"Description = '{des}', ID_manufacturers = (SELECT ID_manufacturers FROM Manufacturers WHERE Man_name = '{manuf}'), " +
                        $"Factory_part_num = '{fact}', Nom_unites_measurement = '{nominal}', " +
                        $"Nom_unites_measurement = (SELECT Nom_unites_measurement FROM Nom_unites_measurement WHERE Name = '{unit}'), " +
                        $"Quantity = '{quantity}' WHERE Comp_reference_num = '{id}'";

                    var command = new SQLiteCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }
            }
            database.closeConnection();
        }
        private void del_button_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void update_Box_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dataGridView1);
            search_textBox.Text = "";
        }

        private void Chenge()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = nameTB.Text;
            var type = typeComboBox.Text;
            var des = desTB.Text;
            var manuf = manufCB.Text;
            var fact = numTB.Text;
            var nominal = nomTB.Text;
            var unit = edCB.Text;
            var quantity = colTB.Text;

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectRowIndex].Cells[1].Value = name;
                dataGridView1.Rows[selectRowIndex].Cells[2].Value = type;
                dataGridView1.Rows[selectRowIndex].Cells[3].Value = des;
                dataGridView1.Rows[selectRowIndex].Cells[4].Value = manuf;
                dataGridView1.Rows[selectRowIndex].Cells[5].Value = fact;
                dataGridView1.Rows[selectRowIndex].Cells[6].Value = nominal;
                dataGridView1.Rows[selectRowIndex].Cells[7].Value = unit;
                dataGridView1.Rows[selectRowIndex].Cells[8].Value = quantity;
                dataGridView1.Rows[selectRowIndex].Cells[9].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            Chenge();
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                nameTB.Text = row.Cells[1].Value.ToString();
                typeComboBox.Text = row.Cells[2].Value.ToString();
                desTB.Text = row.Cells[3].Value.ToString();
                manufCB.Text = row.Cells[4].Value.ToString();
                numTB.Text = row.Cells[5].Value.ToString();
                nomTB.Text = row.Cells[6].Value.ToString();
                edCB.Text = row.Cells[7].Value.ToString();
                colTB.Text = row.Cells[8].Value.ToString();
            }
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Comp_reference_num where Comp_reference_num || Name_component || ID_types_comp || Description || ID_manufacturers || Factory_part_num || Nominal || Nom_unites_measurement || Quantity like '%" + search_textBox.Text + "%' ";

            SQLiteCommand command = new SQLiteCommand(searchString, database.getConnection());
            database.openConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void search_button_Click(object sender, EventArgs e)//поиск
        {
            Search(dataGridView1);
        }

        private void ClearFields()
        {

            nameTB.Text = "";
            typeComboBox.Text = "";
            desTB.Text = "";
            manufCB.Text = "";
            numTB.Text = "";
            nomTB.Text = "";
            edCB.Text = "";
            colTB.Text = "";
        }
    }
}
