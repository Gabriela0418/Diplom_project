namespace Diplom_project
{
    partial class Employee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iBtn_man = new FontAwesome.Sharp.IconButton();
            this.iBtn_cus = new FontAwesome.Sharp.IconButton();
            this.iBtn_exp = new FontAwesome.Sharp.IconButton();
            this.iBtn_sup = new FontAwesome.Sharp.IconButton();
            this.iBtn_comp = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo_pict_home = new System.Windows.Forms.PictureBox();
            this.panelTitlBar = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.Clous_btn = new FontAwesome.Sharp.IconPictureBox();
            this.FullScreen_btn = new FontAwesome.Sharp.IconPictureBox();
            this.Exit_btn = new FontAwesome.Sharp.IconPictureBox();
            this.lbITitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pict_home)).BeginInit();
            this.panelTitlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clous_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iBtn_man);
            this.panelMenu.Controls.Add(this.iBtn_cus);
            this.panelMenu.Controls.Add(this.iBtn_exp);
            this.panelMenu.Controls.Add(this.iBtn_sup);
            this.panelMenu.Controls.Add(this.iBtn_comp);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(357, 853);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 390);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(357, 60);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Сотрудники";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iBtn_man
            // 
            this.iBtn_man.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_man.FlatAppearance.BorderSize = 0;
            this.iBtn_man.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_man.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtn_man.ForeColor = System.Drawing.Color.Black;
            this.iBtn_man.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.iBtn_man.IconColor = System.Drawing.Color.Black;
            this.iBtn_man.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_man.IconSize = 32;
            this.iBtn_man.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_man.Location = new System.Drawing.Point(0, 330);
            this.iBtn_man.Name = "iBtn_man";
            this.iBtn_man.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iBtn_man.Size = new System.Drawing.Size(357, 60);
            this.iBtn_man.TabIndex = 5;
            this.iBtn_man.Text = "Производители";
            this.iBtn_man.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_man.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtn_man.UseVisualStyleBackColor = true;
            this.iBtn_man.Click += new System.EventHandler(this.iBtn_man_Click);
            // 
            // iBtn_cus
            // 
            this.iBtn_cus.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_cus.FlatAppearance.BorderSize = 0;
            this.iBtn_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_cus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtn_cus.ForeColor = System.Drawing.Color.Black;
            this.iBtn_cus.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iBtn_cus.IconColor = System.Drawing.Color.Black;
            this.iBtn_cus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_cus.IconSize = 34;
            this.iBtn_cus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_cus.Location = new System.Drawing.Point(0, 270);
            this.iBtn_cus.Name = "iBtn_cus";
            this.iBtn_cus.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iBtn_cus.Size = new System.Drawing.Size(357, 60);
            this.iBtn_cus.TabIndex = 4;
            this.iBtn_cus.Text = "Заказчики";
            this.iBtn_cus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_cus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtn_cus.UseVisualStyleBackColor = true;
            this.iBtn_cus.Click += new System.EventHandler(this.iBtn_cus_Click);
            // 
            // iBtn_exp
            // 
            this.iBtn_exp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_exp.FlatAppearance.BorderSize = 0;
            this.iBtn_exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_exp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtn_exp.ForeColor = System.Drawing.Color.Black;
            this.iBtn_exp.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iBtn_exp.IconColor = System.Drawing.Color.Black;
            this.iBtn_exp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_exp.IconSize = 32;
            this.iBtn_exp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_exp.Location = new System.Drawing.Point(0, 210);
            this.iBtn_exp.Name = "iBtn_exp";
            this.iBtn_exp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iBtn_exp.Size = new System.Drawing.Size(357, 60);
            this.iBtn_exp.TabIndex = 3;
            this.iBtn_exp.Text = "Отчет о расходах";
            this.iBtn_exp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_exp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtn_exp.UseVisualStyleBackColor = true;
            this.iBtn_exp.Click += new System.EventHandler(this.iBtn_exp_Click);
            // 
            // iBtn_sup
            // 
            this.iBtn_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_sup.FlatAppearance.BorderSize = 0;
            this.iBtn_sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_sup.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtn_sup.ForeColor = System.Drawing.Color.Black;
            this.iBtn_sup.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iBtn_sup.IconColor = System.Drawing.Color.Black;
            this.iBtn_sup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_sup.IconSize = 36;
            this.iBtn_sup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_sup.Location = new System.Drawing.Point(0, 150);
            this.iBtn_sup.Name = "iBtn_sup";
            this.iBtn_sup.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iBtn_sup.Size = new System.Drawing.Size(357, 60);
            this.iBtn_sup.TabIndex = 2;
            this.iBtn_sup.Text = "Поставки";
            this.iBtn_sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_sup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtn_sup.UseVisualStyleBackColor = true;
            this.iBtn_sup.Click += new System.EventHandler(this.iBtn_sup_Click);
            // 
            // iBtn_comp
            // 
            this.iBtn_comp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iBtn_comp.FlatAppearance.BorderSize = 0;
            this.iBtn_comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_comp.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iBtn_comp.ForeColor = System.Drawing.Color.Black;
            this.iBtn_comp.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iBtn_comp.IconColor = System.Drawing.Color.Black;
            this.iBtn_comp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_comp.IconSize = 34;
            this.iBtn_comp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_comp.Location = new System.Drawing.Point(0, 90);
            this.iBtn_comp.Name = "iBtn_comp";
            this.iBtn_comp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iBtn_comp.Size = new System.Drawing.Size(357, 60);
            this.iBtn_comp.TabIndex = 1;
            this.iBtn_comp.Text = "Компоненты";
            this.iBtn_comp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtn_comp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtn_comp.UseVisualStyleBackColor = true;
            this.iBtn_comp.Click += new System.EventHandler(this.iBtn_comp_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Logo_pict_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(357, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo_pict_home
            // 
            this.Logo_pict_home.Image = global::Diplom_project.Properties.Resources.logo;
            this.Logo_pict_home.Location = new System.Drawing.Point(14, 13);
            this.Logo_pict_home.Name = "Logo_pict_home";
            this.Logo_pict_home.Size = new System.Drawing.Size(316, 71);
            this.Logo_pict_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_pict_home.TabIndex = 1;
            this.Logo_pict_home.TabStop = false;
            this.Logo_pict_home.Click += new System.EventHandler(this.Logo_pict_home_Click);
            // 
            // panelTitlBar
            // 
            this.panelTitlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.panelTitlBar.Controls.Add(this.lblfecha);
            this.panelTitlBar.Controls.Add(this.lblhora);
            this.panelTitlBar.Controls.Add(this.Clous_btn);
            this.panelTitlBar.Controls.Add(this.FullScreen_btn);
            this.panelTitlBar.Controls.Add(this.Exit_btn);
            this.panelTitlBar.Controls.Add(this.lbITitleChildForm);
            this.panelTitlBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlBar.Location = new System.Drawing.Point(357, 0);
            this.panelTitlBar.Name = "panelTitlBar";
            this.panelTitlBar.Size = new System.Drawing.Size(905, 90);
            this.panelTitlBar.TabIndex = 1;
            this.panelTitlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlBar_MouseDown);
            // 
            // lblfecha
            // 
            this.lblfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfecha.Location = new System.Drawing.Point(749, 65);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(45, 16);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "label2";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblhora.ForeColor = System.Drawing.Color.Navy;
            this.lblhora.Location = new System.Drawing.Point(747, 34);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(68, 22);
            this.lblhora.TabIndex = 5;
            this.lblhora.Text = "label1";
            // 
            // Clous_btn
            // 
            this.Clous_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clous_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Clous_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clous_btn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Clous_btn.IconColor = System.Drawing.SystemColors.ControlText;
            this.Clous_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clous_btn.IconSize = 25;
            this.Clous_btn.Location = new System.Drawing.Point(828, 3);
            this.Clous_btn.Name = "Clous_btn";
            this.Clous_btn.Size = new System.Drawing.Size(25, 25);
            this.Clous_btn.TabIndex = 4;
            this.Clous_btn.TabStop = false;
            this.Clous_btn.Click += new System.EventHandler(this.Clous_btn_Click);
            // 
            // FullScreen_btn
            // 
            this.FullScreen_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreen_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.FullScreen_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
            this.FullScreen_btn.IconColor = System.Drawing.SystemColors.ControlText;
            this.FullScreen_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FullScreen_btn.IconSize = 25;
            this.FullScreen_btn.Location = new System.Drawing.Point(853, 3);
            this.FullScreen_btn.Name = "FullScreen_btn";
            this.FullScreen_btn.Size = new System.Drawing.Size(25, 25);
            this.FullScreen_btn.TabIndex = 3;
            this.FullScreen_btn.TabStop = false;
            this.FullScreen_btn.Click += new System.EventHandler(this.FullScreen_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_btn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.Exit_btn.IconColor = System.Drawing.SystemColors.ControlText;
            this.Exit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exit_btn.IconSize = 25;
            this.Exit_btn.Location = new System.Drawing.Point(878, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(25, 25);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // lbITitleChildForm
            // 
            this.lbITitleChildForm.AutoSize = true;
            this.lbITitleChildForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbITitleChildForm.Location = new System.Drawing.Point(88, 27);
            this.lbITitleChildForm.Name = "lbITitleChildForm";
            this.lbITitleChildForm.Size = new System.Drawing.Size(171, 26);
            this.lbITitleChildForm.TabIndex = 1;
            this.lbITitleChildForm.Text = "Главное меню";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkOrange;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 60;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(19, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(60, 60);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Gray;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(357, 90);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(905, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.chart1);
            this.panelDesktop.Controls.Add(this.label9);
            this.panelDesktop.Controls.Add(this.radioButton3);
            this.panelDesktop.Controls.Add(this.radioButton2);
            this.panelDesktop.Controls.Add(this.radioButton1);
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Controls.Add(this.grid);
            this.panelDesktop.Location = new System.Drawing.Point(357, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(905, 753);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 328);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(902, 422);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.MediumBlue;
            title1.Name = "Title1";
            title1.Text = "Общая сатистика по компонентам за все время";
            this.chart1.Titles.Add(title1);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label9.Location = new System.Drawing.Point(-19, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(933, 10);
            this.label9.TabIndex = 22;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(693, 260);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 23);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.Text = "Бары";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(348, 260);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(179, 23);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.Text = "Круговой график";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(30, 260);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(200, 23);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Столбчатый график";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 140);
            this.label7.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label6.Location = new System.Drawing.Point(426, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 140);
            this.label6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label5.Location = new System.Drawing.Point(27, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 10);
            this.label5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(27, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 10);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(27, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 10);
            this.label3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diplom_project.Properties.Resources.glav;
            this.pictureBox1.Location = new System.Drawing.Point(483, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(196, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество компонентов на складе";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label8.Location = new System.Drawing.Point(27, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 65);
            this.label8.TabIndex = 9;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(562, 51);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(217, 131);
            this.grid.TabIndex = 18;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 853);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitlBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pict_home)).EndInit();
            this.panelTitlBar.ResumeLayout(false);
            this.panelTitlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clous_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iBtn_comp;
        private FontAwesome.Sharp.IconButton iBtn_cus;
        private FontAwesome.Sharp.IconButton iBtn_exp;
        private FontAwesome.Sharp.IconButton iBtn_sup;
        private FontAwesome.Sharp.IconButton iBtn_man;
        private System.Windows.Forms.PictureBox Logo_pict_home;
        private System.Windows.Forms.Panel panelTitlBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbITitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox Exit_btn;
        private FontAwesome.Sharp.IconPictureBox Clous_btn;
        private FontAwesome.Sharp.IconPictureBox FullScreen_btn;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}