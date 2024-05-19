using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using DGVPrinterHelper;

namespace Diplom_project
{
    public partial class OrderCust : Form
    {

        DataBaseSqlite database = new DataBaseSqlite();
        int selectedRow;

        public OrderCust()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("ID_xpend", "ID");
            dataGridView1.Columns.Add("Comp_reference_num", "Наименование компонента");
            dataGridView1.Columns.Add("ID_Customers", "Заказчик");
            dataGridView1.Columns.Add("Num_ordered", "К-во компонентов");
            dataGridView1.Columns.Add("Date", "Дата");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetInt32(3),
                record.GetDateTime(4).ToString("dd.MM.yyyy"));                ;
        }

        private void otcetBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.CreateReport("Отчет о расходах", "ФИО заказчика " + comboBox1.Text, dataGridView1);
        }

        private void OrderCust_Load(object sender, EventArgs e)
        {
            CreateColomns();

            string queryListCodeRequest = "SELECT * FROM Customers";
            loadElementToComboBox(queryListCodeRequest, "Full_name_contact_person", comboBox1);
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
                while(reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    columnValues.Add(columnValue);
                }
            }
            return columnValues;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedManufacturer = comboBox1.SelectedItem.ToString();

            string queryString = "SELECT ID_xpend, " +
                   "Comp_reference_num.Name_component, " +
                   "Customers.Full_name_contact_person, " +
                   "Num_ordered, Date " +
                   "FROM Expend_warehouse " +
                   "JOIN Comp_reference_num ON Comp_reference_num.Comp_reference_num = Expend_warehouse.Comp_reference_num " +
                   "JOIN Customers ON Customers.ID_Customers = Expend_warehouse.ID_Customers " +
                   "WHERE Customers.Full_name_contact_person = @SelectedManufacturer";
            
            dataGridView1.Rows.Clear();

            try
            {
                SQLiteCommand sqlCommand = new SQLiteCommand(queryString, database.getConnection());
                sqlCommand.Parameters.AddWithValue("@SelectedManufacturer", selectedManufacturer);
                database.openConnection();
                SQLiteDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                    ReadSingleRow(dataGridView1, reader);
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
    }
}
