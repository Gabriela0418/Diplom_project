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
using System.Windows.Forms;

namespace Diplom_project
{
    public partial class Manufact : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        public Manufact()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("ID_manufacturers", "ID");
            dataGridView1.Columns.Add("Man_name", "Наименование производителя");
            dataGridView1.Columns.Add("ID_Country", "Страна");
            dataGridView1.Columns.Add("Website", "Веб-сайт");
            dataGridView1.Columns.Add("Telephone", "Телефон");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),
                record.GetValue(1),
                record.GetValue(2),
                record.GetValue(3),
                record.GetValue(4));
        }
        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            try
            {
                string queryString = "SELECT Manufacturers.ID_manufacturers, " +
                    "Manufacturers.Man_name, " +
                    "Country.Country_name, " +
                    "Manufacturers.Website, " +
                    "Manufacturers.Telephone " +
                    "FROM Manufacturers " +
                    "JOIN Country ON Country.ID_Country = Manufacturers.ID_Country";
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

        private void Manufact_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeProd orderCust = new TypeProd();
            orderCust.Show();
            
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Manufacturers where " +
                $"ID_manufacturers || Man_name || ID_Country || Website || Telephone  like '%" + textBox1.Text + "%' ";

            SQLiteCommand command = new SQLiteCommand(searchString, database.getConnection());
            database.openConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
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
