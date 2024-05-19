using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;
using System.Windows.Controls.Primitives;
using Org.BouncyCastle.Asn1.X509.SigI;

namespace Diplom_project
{
    public partial class Employee : Form
    {

        DataBaseSqlite database = new DataBaseSqlite();

        //Filds
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentChildForm;
        public Employee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(6, 50);
            panelMenu.Controls.Add(leftBorderBtn);

           //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Employee_Load(object sender, EventArgs e)
        {           
            string query = "SELECT SUM(Quantity) AS TotalQuantity FROM Comp_reference_num";


            using (SQLiteConnection connection = new SQLiteConnection(database.getConnection()))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        label2.Text =  result.ToString();
                    }
                    else
                    {
                        label2.Text = "No data available";
                    }
                }
            }

            string queryString = "SELECT Num_ordered, Expend_warehouse.Date " +
                "FROM Expend_warehouse " +
                "JOIN Comp_reference_num ON Comp_reference_num.Comp_reference_num = Expend_warehouse.Comp_reference_num " +
                "JOIN Customers ON Customers.ID_Customers = Expend_warehouse.ID_Customers";
            SQLiteCommand sqlCommand = new SQLiteCommand(queryString, database.getConnection());
            database.openConnection();
            SQLiteDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            grid.DataSource = dataTable;
            CreateChart2(grid, "Компоненты");


            checkRole(NewUser.Status.ToUpper());
        }
        private string checkRole(string role)
        {
            switch (role)
            {
                case ("АДМИН"):
                    iconButton1.Visible = true;
                    return role;
                case ("РАБОТНИК"):
                    iconButton1.Visible = false;
                    return role;
                default: return role;
            }
        }
        //Structs
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(250, 255, 22);
        }

        //Methods
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(212, 212, 212);
                currentBtn.ForeColor = System.Drawing.Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            lbITitleChildForm.Text = childForm.Text;
        }

        private void iBtn_comp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Сomponents());
        }

        private void iBtn_sup_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Supplies());
        }

        private void iBtn_exp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Expenses());
        }

        private void iBtn_cus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Customers());
        }

        private void iBtn_man_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Manufact());
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new NewEmp());
        }

        private void Logo_pict_home_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.DarkOrange;
            lbITitleChildForm.Text = "Главное меню";
        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FullScreen_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Clous_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }


        private void CreateChart2(DataGridView grid,  string seriesName)
        {
            try
            {
                chart1.Titles.Add("");
                chart1.Series.Clear();
                chart1.Series.Add(seriesName);

                for (int i = 0; i < grid.RowCount; i++)
                {
                    var name = grid.Rows[i].Cells[1].Value?.ToString() ?? "";
                    var value = grid.Rows[i].Cells[0].Value?.ToString() ?? "";
                    chart1.Series[seriesName].Points.AddXY(name, value);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message, "Ошибка"); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
