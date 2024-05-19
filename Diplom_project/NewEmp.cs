using System;
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
using System.Windows.Forms;
using static iTextSharp.text.pdf.qrcode.Version;
using System.Windows.Media;

namespace Diplom_project
{
    public partial class NewEmp : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();
        int selectedRow;
        public NewEmp()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("ID", "Табельный номер");
            dataGridView1.Columns.Add("FIO", "ФИО сотрудника");
            dataGridView1.Columns.Add("Status", "Должность");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Прароль");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),     
                record.GetString(1),    
                record.GetString(2),      
                record.GetString(3),    
                record.GetString(4),       
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            try
            {
                string queryString = "SELECT ID, " +
                    "FIO, " +
                    "Status, " +
                    "Login, " +
                    "Password " +
                    "FROM Account";
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

        private void NewEmp_Load(object sender, EventArgs e)
        {
            CreateColomns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.Columns["IsNew"].Visible = false;
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
                    var daleteQuery = $"DELETE FROM Account WHERE ID = {id}";
                    var command = new SQLiteCommand(daleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var status = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var log = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var pas = dataGridView1.Rows[index].Cells[4].Value.ToString();

                    var addQuery = $"UPDATE Account SET FIO = '{name}', Status = '{status}', " +
                    $"Login = '{log}', Password = '{pas}' WHERE ID = '{id}'";

                    var command = new SQLiteCommand(addQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }
            }
            database.closeConnection();
        }

        private void Chenge()
        {
            var selectRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = nameTB.Text;
            var status = statusTB.Text;
            var log = logTB.Text;
            var pas = pasTB.Text;

            if (dataGridView1.Rows[selectRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectRowIndex].Cells[1].Value = name;
                dataGridView1.Rows[selectRowIndex].Cells[2].Value = status;
                dataGridView1.Rows[selectRowIndex].Cells[3].Value = log;
                dataGridView1.Rows[selectRowIndex].Cells[4].Value = pas;
                dataGridView1.Rows[selectRowIndex].Cells[5].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Account where ID || FIO || Status || Login || Password like '%" + textBox1.Text + "%' ";

            SQLiteCommand command = new SQLiteCommand(searchString, database.getConnection());
            database.openConnection();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void ClearFields()
        {
           nameTB.Text = "";
           statusTB.Text = "";
           logTB.Text = "";
           pasTB.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                nameTB.Text = row.Cells[1].Value.ToString(); ;
                statusTB.Text = row.Cells[2].Value.ToString(); ;
                logTB.Text = row.Cells[3].Value.ToString(); ;
                pasTB.Text = row.Cells[4].Value.ToString(); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)//поиск
        {
            Search(dataGridView1);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)//обнов
        {
            Update();
            RefreshDataGrid(dataGridView1);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//добавить
        {
            database.openConnection();

            var name = nameTB.Text;
            var status = statusTB.Text;
            var log = logTB.Text;
            var pas = pasTB.Text;

            var addQuery = $"INSERT INTO Account (FIO, Status, Login, Password) " +
                $"VALUES ('{name}', '{status}', '{log}', '{pas}')";

            var command = new SQLiteCommand(addQuery, database.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись создана!\n Необходимо обновить страницу", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)//изменить
        {
            Chenge();
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)//удалить
        {
            deleteRow();
            ClearFields();
        }
    }
}
