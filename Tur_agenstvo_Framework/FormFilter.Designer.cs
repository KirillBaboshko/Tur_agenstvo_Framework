using System.Drawing;
using System.Windows.Forms;

namespace Tur_agenstvo_Framework
{
    partial class FormFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtFilter = new Tur_agenstvo_Framework.GoodButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(200, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметры для фильтрации";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IHG Hotels & Resorts",
            "Джей В. Марриотт",
            "Марриотт Бонвой",
            "Хилтон Хонорс",
            "Мир Хаятт",
            "Рэдиссон",
            "Эмбасси Сьютс",
            "Резиденс Инн Марриотт"});
            this.comboBox1.Location = new System.Drawing.Point(223, 233);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(532, 235);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown1.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label16.Location = new System.Drawing.Point(346, 227);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 25);
            this.label16.TabIndex = 45;
            this.label16.Text = "Количество персон";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label15.Location = new System.Drawing.Point(76, 227);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "Название отеля";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(469, 126);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 20);
            this.textBox5.TabIndex = 43;
            this.textBox5.MaxLength = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label14.Location = new System.Drawing.Point(385, 119);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 25);
            this.label14.TabIndex = 42;
            this.label14.Text = "Страна";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(469, 176);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label13.Location = new System.Drawing.Point(354, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 25);
            this.label13.TabIndex = 40;
            this.label13.Text = "Дата конца";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 179);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label12.Location = new System.Drawing.Point(76, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Дата начала";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 126);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 20);
            this.textBox4.TabIndex = 37;
            this.textBox4.MaxLength = 100;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label11.Location = new System.Drawing.Point(112, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Название";
            // 
            // ButtFilter
            // 
            this.ButtFilter.BackColor = System.Drawing.Color.Lavender;
            this.ButtFilter.BackgroundColor = System.Drawing.Color.Lavender;
            this.ButtFilter.BorderColor = System.Drawing.Color.DimGray;
            this.ButtFilter.BorderRadius = 20;
            this.ButtFilter.BorderSize = 2;
            this.ButtFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtFilter.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtFilter.ForeColor = System.Drawing.Color.Black;
            this.ButtFilter.Location = new System.Drawing.Point(258, 295);
            this.ButtFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtFilter.Name = "ButtFilter";
            this.ButtFilter.Size = new System.Drawing.Size(186, 54);
            this.ButtFilter.TabIndex = 50;
            this.ButtFilter.Text = "Фильтровать ";
            this.ButtFilter.TextColor = System.Drawing.Color.Black;
            this.ButtFilter.UseVisualStyleBackColor = true;
            this.ButtFilter.Click += new System.EventHandler(this.ButtFilter_Click);
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.ButtFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFilter";
            this.Text = "Фильтрация";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label16;
        private Label label15;
        private TextBox textBox5;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private TextBox textBox4;
        private Label label11;
        private GoodButton ButtFilter;
    }
}