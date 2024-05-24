using System.Drawing;
using System.Windows.Forms;

namespace Tur_agenstvo_Framework
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.GridTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriesOfPassportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfPassportColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfTourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfHotelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfPersonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxSeriesOfPassport = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfPassport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtSearch = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtUpdate = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtDiagram = new Tur_agenstvo_Framework.GoodButton();
            this.ButtEdit = new Tur_agenstvo_Framework.GoodButton();
            this.ButtFilter = new Tur_agenstvo_Framework.GoodButton();
            this.ButtDel = new Tur_agenstvo_Framework.GoodButton();
            this.ButtAdd = new Tur_agenstvo_Framework.GoodButton();
            this.ButtLoadFromFile = new Tur_agenstvo_Framework.GoodButton();
            this.ButtSaveToFile = new Tur_agenstvo_Framework.GoodButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTable
            // 
            this.GridTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SurnameColumn,
            this.NameColumn,
            this.SecondnameColumn,
            this.SeriesOfPassportColumn,
            this.NumberOfPassportColumn,
            this.NameOfTourColumn,
            this.StartDateColumn,
            this.EndDateColumn,
            this.CountryColumn,
            this.NameOfHotelColumn,
            this.CountOfPersonColumn,
            this.CostColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridTable.Location = new System.Drawing.Point(125, 348);
            this.GridTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowHeadersWidth = 51;
            this.GridTable.Size = new System.Drawing.Size(1805, 513);
            this.GridTable.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            this.SurnameColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Имя ";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 125;
            // 
            // SecondnameColumn
            // 
            this.SecondnameColumn.HeaderText = "Отчество";
            this.SecondnameColumn.MinimumWidth = 6;
            this.SecondnameColumn.Name = "SecondnameColumn";
            this.SecondnameColumn.ReadOnly = true;
            this.SecondnameColumn.Width = 125;
            // 
            // SeriesOfPassportColumn
            // 
            this.SeriesOfPassportColumn.HeaderText = "Серия паспорта";
            this.SeriesOfPassportColumn.MinimumWidth = 6;
            this.SeriesOfPassportColumn.Name = "SeriesOfPassportColumn";
            this.SeriesOfPassportColumn.ReadOnly = true;
            this.SeriesOfPassportColumn.Width = 80;
            // 
            // NumberOfPassportColumn
            // 
            this.NumberOfPassportColumn.HeaderText = "Номер паспорта";
            this.NumberOfPassportColumn.MinimumWidth = 6;
            this.NumberOfPassportColumn.Name = "NumberOfPassportColumn";
            this.NumberOfPassportColumn.ReadOnly = true;
            this.NumberOfPassportColumn.Width = 80;
            // 
            // NameOfTourColumn
            // 
            this.NameOfTourColumn.HeaderText = "Название тура";
            this.NameOfTourColumn.MinimumWidth = 6;
            this.NameOfTourColumn.Name = "NameOfTourColumn";
            this.NameOfTourColumn.ReadOnly = true;
            this.NameOfTourColumn.Width = 125;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.HeaderText = "Дата начала тура";
            this.StartDateColumn.MinimumWidth = 6;
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Width = 90;
            // 
            // EndDateColumn
            // 
            this.EndDateColumn.HeaderText = "Дата окончания тура";
            this.EndDateColumn.MinimumWidth = 6;
            this.EndDateColumn.Name = "EndDateColumn";
            this.EndDateColumn.ReadOnly = true;
            this.EndDateColumn.Width = 90;
            // 
            // CountryColumn
            // 
            this.CountryColumn.HeaderText = "Страна прибывания";
            this.CountryColumn.MinimumWidth = 6;
            this.CountryColumn.Name = "CountryColumn";
            this.CountryColumn.ReadOnly = true;
            this.CountryColumn.Width = 125;
            // 
            // NameOfHotelColumn
            // 
            this.NameOfHotelColumn.HeaderText = "Название отеля прибывания";
            this.NameOfHotelColumn.MinimumWidth = 6;
            this.NameOfHotelColumn.Name = "NameOfHotelColumn";
            this.NameOfHotelColumn.ReadOnly = true;
            this.NameOfHotelColumn.Width = 125;
            // 
            // CountOfPersonColumn
            // 
            this.CountOfPersonColumn.HeaderText = "Количество персон";
            this.CountOfPersonColumn.MinimumWidth = 6;
            this.CountOfPersonColumn.Name = "CountOfPersonColumn";
            this.CountOfPersonColumn.ReadOnly = true;
            this.CountOfPersonColumn.Width = 90;
            // 
            // CostColumn
            // 
            this.CostColumn.HeaderText = "Стоимость";
            this.CostColumn.MinimumWidth = 6;
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.ReadOnly = true;
            this.CostColumn.Width = 125;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(419, 244);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(236, 244);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSurname.MaxLength = 100;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(167, 22);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(553, 244);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSecondName.MaxLength = 100;
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(164, 22);
            this.textBoxSecondName.TabIndex = 7;
            // 
            // textBoxSeriesOfPassport
            // 
            this.textBoxSeriesOfPassport.Location = new System.Drawing.Point(737, 244);
            this.textBoxSeriesOfPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSeriesOfPassport.Name = "textBoxSeriesOfPassport";
            this.textBoxSeriesOfPassport.Size = new System.Drawing.Size(97, 22);
            this.textBoxSeriesOfPassport.TabIndex = 8;
            // 
            // textBoxNumberOfPassport
            // 
            this.textBoxNumberOfPassport.Location = new System.Drawing.Point(853, 244);
            this.textBoxNumberOfPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumberOfPassport.Name = "textBoxNumberOfPassport";
            this.textBoxNumberOfPassport.Size = new System.Drawing.Size(119, 22);
            this.textBoxNumberOfPassport.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(441, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(577, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(739, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Серия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(861, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = " Номер";
            // 
            // ButtSearch
            // 
            this.ButtSearch.BackColor = System.Drawing.Color.Transparent;
            this.ButtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtSearch.ForeColor = System.Drawing.Color.White;
            this.ButtSearch.Image = global::Tur_agenstvo_Framework.Properties.Resources.noun_41373__2_;
            this.ButtSearch.InitialImage = null;
            this.ButtSearch.Location = new System.Drawing.Point(995, 219);
            this.ButtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtSearch.Name = "ButtSearch";
            this.ButtSearch.Size = new System.Drawing.Size(63, 63);
            this.ButtSearch.TabIndex = 15;
            this.ButtSearch.TabStop = false;
            this.ButtSearch.Click += new System.EventHandler(this.ButtSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(443, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 62);
            this.label6.TabIndex = 16;
            this.label6.Text = "Поиск клиента ";
            // 
            // ButtUpdate
            // 
            this.ButtUpdate.BackColor = System.Drawing.Color.Transparent;
            this.ButtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtUpdate.Image = global::Tur_agenstvo_Framework.Properties.Resources.refresh_1_1024__1_;
            this.ButtUpdate.Location = new System.Drawing.Point(1449, 117);
            this.ButtUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtUpdate.Name = "ButtUpdate";
            this.ButtUpdate.Size = new System.Drawing.Size(85, 78);
            this.ButtUpdate.TabIndex = 17;
            this.ButtUpdate.TabStop = false;
            this.ButtUpdate.Click += new System.EventHandler(this.ButtUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tur_agenstvo_Framework.Properties.Resources._3820288__1_;
            this.pictureBox1.Location = new System.Drawing.Point(48, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 127);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ButtDiagram
            // 
            this.ButtDiagram.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ButtDiagram.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.ButtDiagram.BorderColor = System.Drawing.Color.Cyan;
            this.ButtDiagram.BorderRadius = 25;
            this.ButtDiagram.BorderSize = 2;
            this.ButtDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtDiagram.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtDiagram.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtDiagram.Location = new System.Drawing.Point(553, 897);
            this.ButtDiagram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtDiagram.Name = "ButtDiagram";
            this.ButtDiagram.Size = new System.Drawing.Size(235, 62);
            this.ButtDiagram.TabIndex = 20;
            this.ButtDiagram.Text = "Показать диаграммы";
            this.ButtDiagram.TextColor = System.Drawing.Color.Cornsilk;
            this.ButtDiagram.UseVisualStyleBackColor = true;
            this.ButtDiagram.Click += new System.EventHandler(this.ButtDiagram_Click);
            // 
            // ButtEdit
            // 
            this.ButtEdit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ButtEdit.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.ButtEdit.BorderColor = System.Drawing.Color.Cyan;
            this.ButtEdit.BorderRadius = 25;
            this.ButtEdit.BorderSize = 2;
            this.ButtEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtEdit.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtEdit.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtEdit.Location = new System.Drawing.Point(893, 896);
            this.ButtEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtEdit.Name = "ButtEdit";
            this.ButtEdit.Size = new System.Drawing.Size(235, 62);
            this.ButtEdit.TabIndex = 19;
            this.ButtEdit.Text = "Редактирование записей";
            this.ButtEdit.TextColor = System.Drawing.Color.Cornsilk;
            this.ButtEdit.UseVisualStyleBackColor = true;
            this.ButtEdit.Click += new System.EventHandler(this.ButtEdit_Click);
            // 
            // ButtFilter
            // 
            this.ButtFilter.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtFilter.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.ButtFilter.BorderColor = System.Drawing.Color.LawnGreen;
            this.ButtFilter.BorderRadius = 15;
            this.ButtFilter.BorderSize = 2;
            this.ButtFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtFilter.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtFilter.ForeColor = System.Drawing.Color.White;
            this.ButtFilter.Location = new System.Drawing.Point(1136, 231);
            this.ButtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtFilter.Name = "ButtFilter";
            this.ButtFilter.Size = new System.Drawing.Size(231, 62);
            this.ButtFilter.TabIndex = 18;
            this.ButtFilter.Text = "Фильтр туров";
            this.ButtFilter.TextColor = System.Drawing.Color.White;
            this.ButtFilter.UseVisualStyleBackColor = false;
            this.ButtFilter.Click += new System.EventHandler(this.ButtFilter_Click);
            // 
            // ButtDel
            // 
            this.ButtDel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ButtDel.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.ButtDel.BorderColor = System.Drawing.Color.Cyan;
            this.ButtDel.BorderRadius = 25;
            this.ButtDel.BorderSize = 2;
            this.ButtDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtDel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtDel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtDel.Location = new System.Drawing.Point(1228, 896);
            this.ButtDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtDel.Name = "ButtDel";
            this.ButtDel.Size = new System.Drawing.Size(235, 63);
            this.ButtDel.TabIndex = 4;
            this.ButtDel.Text = "Удаление записи";
            this.ButtDel.TextColor = System.Drawing.Color.Cornsilk;
            this.ButtDel.UseVisualStyleBackColor = true;
            this.ButtDel.Click += new System.EventHandler(this.ButtDel_Click);
            // 
            // ButtAdd
            // 
            this.ButtAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ButtAdd.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.ButtAdd.BorderColor = System.Drawing.Color.Cyan;
            this.ButtAdd.BorderRadius = 25;
            this.ButtAdd.BorderSize = 2;
            this.ButtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtAdd.ForeColor = System.Drawing.Color.Cornsilk;
            this.ButtAdd.Location = new System.Drawing.Point(1563, 895);
            this.ButtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(235, 63);
            this.ButtAdd.TabIndex = 3;
            this.ButtAdd.Text = "Добавить запись";
            this.ButtAdd.TextColor = System.Drawing.Color.Cornsilk;
            this.ButtAdd.UseVisualStyleBackColor = false;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAdd_Click);
            // 
            // ButtLoadFromFile
            // 
            this.ButtLoadFromFile.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtLoadFromFile.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.ButtLoadFromFile.BorderColor = System.Drawing.Color.LawnGreen;
            this.ButtLoadFromFile.BorderRadius = 15;
            this.ButtLoadFromFile.BorderSize = 2;
            this.ButtLoadFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtLoadFromFile.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtLoadFromFile.ForeColor = System.Drawing.Color.White;
            this.ButtLoadFromFile.Location = new System.Drawing.Point(1668, 231);
            this.ButtLoadFromFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtLoadFromFile.Name = "ButtLoadFromFile";
            this.ButtLoadFromFile.Size = new System.Drawing.Size(231, 62);
            this.ButtLoadFromFile.TabIndex = 1;
            this.ButtLoadFromFile.Text = "Загрузить данные из файла";
            this.ButtLoadFromFile.TextColor = System.Drawing.Color.White;
            this.ButtLoadFromFile.UseVisualStyleBackColor = true;
            this.ButtLoadFromFile.Click += new System.EventHandler(this.ButtLoadFromFile_Click);
            // 
            // ButtSaveToFile
            // 
            this.ButtSaveToFile.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtSaveToFile.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.ButtSaveToFile.BorderColor = System.Drawing.Color.LawnGreen;
            this.ButtSaveToFile.BorderRadius = 15;
            this.ButtSaveToFile.BorderSize = 2;
            this.ButtSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtSaveToFile.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtSaveToFile.ForeColor = System.Drawing.Color.White;
            this.ButtSaveToFile.Location = new System.Drawing.Point(1404, 231);
            this.ButtSaveToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtSaveToFile.Name = "ButtSaveToFile";
            this.ButtSaveToFile.Size = new System.Drawing.Size(231, 62);
            this.ButtSaveToFile.TabIndex = 0;
            this.ButtSaveToFile.Text = "Сохранить данные в файл";
            this.ButtSaveToFile.TextColor = System.Drawing.Color.White;
            this.ButtSaveToFile.UseVisualStyleBackColor = true;
            this.ButtSaveToFile.Click += new System.EventHandler(this.ButtSaveToFile_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tur_agenstvo_Framework.Properties.Resources._06565992_risunok_pliazha_1__1_;
            this.ClientSize = new System.Drawing.Size(1907, 955);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtDiagram);
            this.Controls.Add(this.ButtEdit);
            this.Controls.Add(this.ButtFilter);
            this.Controls.Add(this.ButtUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberOfPassport);
            this.Controls.Add(this.textBoxSeriesOfPassport);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ButtDel);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.GridTable);
            this.Controls.Add(this.ButtLoadFromFile);
            this.Controls.Add(this.ButtSaveToFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Туристическое агенство \"Бедный студент\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GoodButton ButtSaveToFile;
        private GoodButton ButtLoadFromFile;
        private DataGridView GridTable;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn SurnameColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn SecondnameColumn;
        private DataGridViewTextBoxColumn SeriesOfPassportColumn;
        private DataGridViewTextBoxColumn NumberOfPassportColumn;
        private DataGridViewTextBoxColumn NameOfTourColumn;
        private DataGridViewTextBoxColumn StartDateColumn;
        private DataGridViewTextBoxColumn EndDateColumn;
        private DataGridViewTextBoxColumn CountryColumn;
        private DataGridViewTextBoxColumn NameOfHotelColumn;
        private DataGridViewTextBoxColumn CountOfPersonColumn;
        private DataGridViewTextBoxColumn CostColumn;
        private GoodButton ButtDel;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxSecondName;
        private TextBox textBoxSeriesOfPassport;
        private TextBox textBoxNumberOfPassport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox ButtSearch;
        private Label label6;
        private PictureBox ButtUpdate;
        private GoodButton ButtFilter;
        private GoodButton ButtEdit;
        private GoodButton ButtDiagram;
        private GoodButton ButtAdd;
        private PictureBox pictureBox1;
    }
}

