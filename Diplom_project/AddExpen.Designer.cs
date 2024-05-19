namespace Diplom_project
{
    partial class AddExpen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.compCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manufCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // compCB
            // 
            this.compCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compCB.FormattingEnabled = true;
            this.compCB.Location = new System.Drawing.Point(263, 120);
            this.compCB.Name = "compCB";
            this.compCB.Size = new System.Drawing.Size(227, 24);
            this.compCB.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(114, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 38);
            this.label5.TabIndex = 67;
            this.label5.Text = "НОВЫЙ ЗАКАЗ";
            // 
            // numTB
            // 
            this.numTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numTB.Location = new System.Drawing.Point(366, 252);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(124, 22);
            this.numTB.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 82);
            this.label4.TabIndex = 65;
            this.label4.Text = "Количество компонентов для заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Дата заказа";
            // 
            // manufCB
            // 
            this.manufCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manufCB.FormattingEnabled = true;
            this.manufCB.Location = new System.Drawing.Point(263, 162);
            this.manufCB.Name = "manufCB";
            this.manufCB.Size = new System.Drawing.Size(227, 24);
            this.manufCB.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Заказчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "Компонент";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(99)))));
            this.addBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(37, 335);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(451, 39);
            this.addBtn.TabIndex = 60;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diplom_project.Properties.Resources.sup1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // AddExpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 609);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.compCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddExpen";
            this.Text = "Добавление расхода";
            this.Load += new System.EventHandler(this.AddExpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox compCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manufCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}