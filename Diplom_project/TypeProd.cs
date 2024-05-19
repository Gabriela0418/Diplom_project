using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;


namespace Diplom_project
{
    public partial class TypeProd : Form
    {
        DataBaseSqlite database = new DataBaseSqlite();

        public TypeProd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CreateColomns()
        {
            dataGridView1.Columns.Add("Comp_reference_num", "Инвентарный номер");
            dataGridView1.Columns.Add("Name_component", "Наименование компонента");
            dataGridView1.Columns.Add("Types_comp", "Тип компонента");
            dataGridView1.Columns.Add("Description", "Описание");
            dataGridView1.Columns.Add("Manufacturer", "Производитель");
            dataGridView1.Columns.Add("Factory_part_num", "Заводской номер детали");
            dataGridView1.Columns.Add("Nominal", "Номинал");
            dataGridView1.Columns.Add("Nom_units_measurement", "Единица измерения");
            dataGridView1.Columns.Add("Quantity", "Количество компонентов");
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
                record.GetValue(8));      // Quantity - INTEGER
                
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

        private void TypeProd_Load(object sender, EventArgs e)
        {
            CreateColomns();

            string queryListCodeRequest = "SELECT * FROM Manufacturers";
            loadElementToComboBox(queryListCodeRequest, "Man_name", comboBox1);
        }

        private void otcetBtn_Click(object sender, EventArgs e)//отчет
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.CreateReport("Производители","ФИО производителя "+comboBox1.Text,dataGridView1);
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "PDF (*.pdf)|*.pdf";
            //    save.FileName = "Result";

            //    if (save.ShowDialog() == DialogResult.OK)
            //    {
            //        try
            //        {
            //            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
            //            {
            //                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
            //                PdfWriter.GetInstance(document, fileStream);

            //                document.Open();

            //                // Добавляем заголовок отчета
            //                Paragraph reportHeader = new Paragraph("Заголовок отчета\n");
            //                document.Add(reportHeader);

            //                // Добавляем информацию о заказчике и дате создания отчета
            //                Paragraph customerInfo = new Paragraph($"ФИО производителя: {comboBox1.Text}\nДата создания отчета: {DateTime.Now}\n\n");
            //                document.Add(customerInfo);

            //                PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);

            //                pTable.DefaultCell.Padding = 2;
            //                pTable.WidthPercentage = 100;
            //                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

            //                pTable.AddCell(new PdfPCell(new Phrase("")) { Border = PdfPCell.NO_BORDER });

            //                // Добавляем заголовок
            //                PdfPCell headerCell = new PdfPCell(new Phrase("История заказов"));
            //                headerCell.Colspan = dataGridView1.Columns.Count; // Занимает все столбцы
            //                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
            //                pTable.AddCell(headerCell);

            //                foreach (DataGridViewColumn col in dataGridView1.Columns)
            //                {
            //                    PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
            //                    pTable.AddCell(pcell);
            //                }

            //                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
            //                {
            //                    foreach (DataGridViewCell dcell in viewRow.Cells)
            //                    {
            //                        pTable.AddCell(dcell.Value.ToString());
            //                    }
            //                }

            //                document.Add(pTable);
            //                document.Close();
            //            }

            //            MessageBox.Show("Data Export Successfully", "Info");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error while exporting Data: " + ex.Message);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No Record Found", "Info");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedManufacturer = comboBox1.SelectedItem.ToString();

            string queryComponentsByManufacturer = "SELECT Comp_reference_num.Comp_reference_num, " +
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
                    "JOIN Nom_unites_measurement ON Nom_unites_measurement.Nom_unites_measurement = Comp_reference_num.Nom_unites_measurement " +
                    "WHERE Manufacturers.Man_name = @SelectedManufacturer";

            dataGridView1.Rows.Clear();

            try
            {
                SQLiteCommand sqlCommand = new SQLiteCommand(queryComponentsByManufacturer, database.getConnection());
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
