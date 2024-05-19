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

namespace Diplom_project
{
    public partial class Customers : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        int selectedRow;

        public Customers()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void CreateColomns()
        {
            dataGridView1.Columns.Add("ID_Customers", "ID заказчика");
            dataGridView1.Columns.Add("Full_name_contact_person", "ФИО контактного лица");
            dataGridView1.Columns.Add("Company_name", "Наименование компании");
            dataGridView1.Columns.Add("Address", "Адрес");
            dataGridView1.Columns.Add("Telephone", "Телефон");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4));
        }
        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            try
            {
                string queryString = "SELECT * FROM Customers";
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

        private void Customers_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            OrderCust orderCust = new OrderCust();
            this.Hide();
            orderCust.Show();
        }

        private void Search (DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Customers where ID_Customers || Full_name_contact_person || Company_name || Address || Telephone like '%" + textBox1.Text + "%' ";

            SQLiteCommand command = new SQLiteCommand(searchString, database.getConnection());
            database.openConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow (dgw, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)//поиск
        {
            Search(dataGridView1);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dataGridView1);
            textBox1.Text = "";
        }
    }
}
