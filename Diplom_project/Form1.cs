using FontAwesome.Sharp;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Diplom_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            roundBtn1.Enabled = false;
            pas_textBox.UseSystemPasswordChar = true;
            open_pictureBox.Visible = false;
            log_textBox.MaxLength = 50;
            pas_textBox.MaxLength = 50;
        }

        private void pictureBox_clouse_Click(object sender, EventArgs e)
        {
            pas_textBox.UseSystemPasswordChar = false;
            pictureBox_clouse.Visible = false;
            open_pictureBox.Visible = true;
        }

        private void open_pictureBox_Click(object sender, EventArgs e)
        {
            pas_textBox.UseSystemPasswordChar = true;
            pictureBox_clouse.Visible = true;
            open_pictureBox.Visible = false;
        }
        private void roundBtn1_Click(object sender, EventArgs e)
        {
            string loguser = log_textBox.Text;
            string passuser = md5.hashPassword(pas_textBox.Text);

            var PI = new NewUser();

            if (PI.SetPersonalData(loguser, passuser))
            {
                MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Employee employee = new Employee();
                this.Hide();
                employee.Show();
            }
            else
                MessageBox.Show("Пользователь не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pas_textBox_TextChanged(object sender, EventArgs e)
        {
            if (log_textBox.Text.Length != 0 && pas_textBox.Text.Length != 0)
            { roundBtn1.Enabled = true; }
            else { roundBtn1.Enabled = false; }
        }
    }
}
