using DGVPrinterHelper;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Diplom_project
{
    public partial class Supplies : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        int selectedRow;

        public Supplies()
        {
            InitializeComponent();
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("ID_supplies", "Номер поставки");
            dataGridView1.Columns.Add("Comp_reference_num", "Наименование компонента");
            dataGridView1.Columns.Add("ID_manufacturers", "Производитель");
            dataGridView1.Columns.Add("Delivery_date", "Дата поставки");
            dataGridView1.Columns.Add("Num_comp_supplied", "Количество компонентов");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetDateTime(3).ToString("dd.MM.yyyy"),
                record.GetInt32(4),
                RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            try
            {
                string queryString = "SELECT Supplies.ID_supplies," +
                    "Comp_reference_num.Name_component," +
                    "Manufacturers.Man_name," +
                    "Supplies.Delivery_date," +
                    "Supplies.Num_comp_supplied " +
                    "FROM Supplies " +
                    "JOIN Comp_reference_num ON Comp_reference_num.Comp_reference_num = Supplies.Comp_reference_num " +
                    "JOIN Manufacturers ON Manufacturers.ID_manufacturers = Supplies.ID_manufacturers; ";
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

        private void Supplies_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);


            string manListCodeRequest = "SELECT * FROM Manufacturers";
            loadElementToComboBox(manListCodeRequest, "Man_name", manufCB);

            string compListCodeRequest = "SELECT * FROM Comp_reference_num";
            loadElementToComboBox(compListCodeRequest, "Name_component", compCB);

            checkRole(NewUser.Status.ToUpper());

            dataGridView1.Columns["IsNew"].Visible = false;
        }

        private string checkRole(string role)
        {
            switch (role)
            {
                case ("АДМИН"):
                    button4.Visible = true;
                    return role;
                case ("РАБОТНИК"):
                    button4.Visible = false;
                    return role;
                default: return role;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSupcs addSupcs = new AddSupcs();
            addSupcs.Show();
        }


        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var daleteQuery = $"DELETE FROM Supplies WHERE ID_supplies = {id}";
                    var command = new SQLiteCommand(daleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var comp = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var man = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var date_ = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var fact = dataGridView1.Rows[index].Cells[4].Value.ToString();

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

                    var addQuery = $"UPDATE Supplies SET " +
                        $"Comp_reference_num = (SELECT Comp_reference_num FROM Comp_reference_num WHERE Name_component = '{comp}'), " +
                        $"ID_manufacturers = (SELECT ID_manufacturers FROM Manufacturers WHERE Man_name = '{man}'), " +
                        $"Delivery_date = '{formattedDate}', " +
                        $"Num_comp_supplied = '{fact}'  WHERE ID_supplies = '{id}'";

                    var command = new SQLiteCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)//изменить 
        {
            Chenge();
            ClearFields();
        }

        private void Chenge()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;

            var comp = compCB.Text;
            var man = manufCB.Text;
            var date = dateTimePicker1.Text;
            var fact = numTB.Text;

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectRowIndex].Cells[1].Value = comp;
                dataGridView1.Rows[selectRowIndex].Cells[2].Value = man;
                dataGridView1.Rows[selectRowIndex].Cells[3].Value = date;
                dataGridView1.Rows[selectRowIndex].Cells[4].Value = fact;
                dataGridView1.Rows[selectRowIndex].Cells[5].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void button4_Click(object sender, EventArgs e)//удалить
        {
            deleteRow();
            ClearFields();
        }
        private void ClearFields()
        {
            compCB.Text = "";
            manufCB.Text = "";
            dateTimePicker1.Text = "";
            numTB.Text = "";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)//обновить табл
        {
            Update();
            RefreshDataGrid(dataGridView1);
            textBox1.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                compCB.Text = row.Cells[1].Value.ToString();
                manufCB.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                numTB.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Supplies where ID_supplies || Comp_reference_num || ID_manufacturers || Delivery_date || Num_comp_supplied  like '%" + textBox1.Text + "%' ";

            SQLiteCommand command = new SQLiteCommand(searchString, database.getConnection());
            database.openConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.CreateReport("Отчет о поставках", null, dataGridView1);
        }
    }
}
