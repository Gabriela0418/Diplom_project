namespace Diplom_project
{
    partial class Сomponents
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
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.edCB = new System.Windows.Forms.ComboBox();
            this.manufCB = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.colTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_Box = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textBox
            // 
            this.search_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.search_textBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textBox.Location = new System.Drawing.Point(27, 37);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(299, 28);
            this.search_textBox.TabIndex = 0;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.search_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(345, 31);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(173, 39);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 267);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(99)))));
            this.add_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(27, 98);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(260, 39);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(99)))));
            this.update_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(305, 98);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(260, 39);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "Изменить";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(99)))));
            this.del_button.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F);
            this.del_button.ForeColor = System.Drawing.Color.White;
            this.del_button.Location = new System.Drawing.Point(588, 98);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(260, 39);
            this.del_button.TabIndex = 5;
            this.del_button.Text = "Удалить";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // edCB
            // 
            this.edCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edCB.FormattingEnabled = true;
            this.edCB.Location = new System.Drawing.Point(546, 489);
            this.edCB.Name = "edCB";
            this.edCB.Size = new System.Drawing.Size(227, 24);
            this.edCB.TabIndex = 54;
            // 
            // manufCB
            // 
            this.manufCB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.manufCB.FormattingEnabled = true;
            this.manufCB.Location = new System.Drawing.Point(258, 574);
            this.manufCB.Name = "manufCB";
            this.manufCB.Size = new System.Drawing.Size(227, 24);
            this.manufCB.TabIndex = 53;
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(258, 489);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(227, 24);
            this.typeComboBox.TabIndex = 52;
            // 
            // colTB
            // 
            this.colTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.colTB.Location = new System.Drawing.Point(546, 574);
            this.colTB.Name = "colTB";
            this.colTB.Size = new System.Drawing.Size(145, 22);
            this.colTB.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(543, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "Количество компонентов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(542, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 22);
            this.label8.TabIndex = 49;
            this.label8.Text = "Единица измерения";
            // 
            // nomTB
            // 
            this.nomTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nomTB.Location = new System.Drawing.Point(258, 663);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(227, 22);
            this.nomTB.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Номинал";
            // 
            // numTB
            // 
            this.numTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numTB.Location = new System.Drawing.Point(381, 620);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(104, 22);
            this.numTB.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(27, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Заводской номер детали";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Производитель";
            // 
            // desTB
            // 
            this.desTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.desTB.Location = new System.Drawing.Point(258, 535);
            this.desTB.Name = "desTB";
            this.desTB.Size = new System.Drawing.Size(227, 22);
            this.desTB.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Тип";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameTB.Location = new System.Drawing.Point(258, 450);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(227, 22);
            this.nameTB.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Наименование";
            // 
            // update_Box
            // 
            this.update_Box.BackColor = System.Drawing.Color.White;
            this.update_Box.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_Box.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.update_Box.IconColor = System.Drawing.SystemColors.ControlText;
            this.update_Box.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update_Box.IconSize = 40;
            this.update_Box.Location = new System.Drawing.Point(530, 32);
            this.update_Box.Name = "update_Box";
            this.update_Box.Size = new System.Drawing.Size(40, 40);
            this.update_Box.TabIndex = 6;
            this.update_Box.TabStop = false;
            this.update_Box.Click += new System.EventHandler(this.update_Box_Click);
            // 
            // Сomponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 706);
            this.Controls.Add(this.edCB);
            this.Controls.Add(this.manufCB);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.colTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.desTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_Box);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox);
            this.Name = "Сomponents";
            this.Text = "Компоненты";
            this.Load += new System.EventHandler(this.Сomponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button del_button;
        private FontAwesome.Sharp.IconPictureBox update_Box;
        private System.Windows.Forms.ComboBox edCB;
        private System.Windows.Forms.ComboBox manufCB;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox colTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
    }
}