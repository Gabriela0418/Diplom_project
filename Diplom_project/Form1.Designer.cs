namespace Diplom_project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_textBox = new System.Windows.Forms.TextBox();
            this.pas_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_clouse = new System.Windows.Forms.PictureBox();
            this.open_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundBtn1 = new Diplom_project.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "ВХОД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ЛОГИН";
            // 
            // log_textBox
            // 
            this.log_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.log_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_textBox.Location = new System.Drawing.Point(616, 138);
            this.log_textBox.Name = "log_textBox";
            this.log_textBox.Size = new System.Drawing.Size(244, 27);
            this.log_textBox.TabIndex = 3;
            this.log_textBox.TextChanged += new System.EventHandler(this.pas_textBox_TextChanged);
            // 
            // pas_textBox
            // 
            this.pas_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pas_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pas_textBox.Location = new System.Drawing.Point(616, 188);
            this.pas_textBox.Name = "pas_textBox";
            this.pas_textBox.Size = new System.Drawing.Size(244, 27);
            this.pas_textBox.TabIndex = 5;
            this.pas_textBox.TextChanged += new System.EventHandler(this.pas_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "ПАРОЛЬ";
            // 
            // pictureBox_clouse
            // 
            this.pictureBox_clouse.Image = global::Diplom_project.Properties.Resources.eyes_clouse;
            this.pictureBox_clouse.Location = new System.Drawing.Point(875, 184);
            this.pictureBox_clouse.Name = "pictureBox_clouse";
            this.pictureBox_clouse.Size = new System.Drawing.Size(47, 41);
            this.pictureBox_clouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clouse.TabIndex = 10;
            this.pictureBox_clouse.TabStop = false;
            this.pictureBox_clouse.Click += new System.EventHandler(this.pictureBox_clouse_Click);
            // 
            // open_pictureBox
            // 
            this.open_pictureBox.Image = global::Diplom_project.Properties.Resources.eyes;
            this.open_pictureBox.Location = new System.Drawing.Point(875, 187);
            this.open_pictureBox.Name = "open_pictureBox";
            this.open_pictureBox.Size = new System.Drawing.Size(47, 35);
            this.open_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.open_pictureBox.TabIndex = 9;
            this.open_pictureBox.TabStop = false;
            this.open_pictureBox.Click += new System.EventHandler(this.open_pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diplom_project.Properties.Resources.entrance;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.roundBtn1.Font = new System.Drawing.Font("Elephant", 13.8F);
            this.roundBtn1.ForeColor = System.Drawing.Color.White;
            this.roundBtn1.Location = new System.Drawing.Point(503, 246);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Radius = 30;
            this.roundBtn1.Size = new System.Drawing.Size(417, 64);
            this.roundBtn1.TabIndex = 7;
            this.roundBtn1.Text = "ВОЙТИ";
            this.roundBtn1.UseVisualStyleBackColor = false;
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(999, 374);
            this.Controls.Add(this.pictureBox_clouse);
            this.Controls.Add(this.open_pictureBox);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.pas_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.log_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox log_textBox;
        private System.Windows.Forms.TextBox pas_textBox;
        private System.Windows.Forms.Label label3;
        private RoundBtn roundBtn1;
        private System.Windows.Forms.PictureBox open_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox_clouse;
    }
}

