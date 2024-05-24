using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tur_agenstvo_Framework
{
    public partial class FormAdd : Form
    {
        Record buffrecord;
        mainForm buffF;
        public FormAdd()
        {
            InitializeComponent();
        }
        public FormAdd(mainForm f)
        {
            InitializeComponent();
            buffF = f;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "000000";
            }
            if (textBox8.Text == "")
            {
                textBox8.Text = "0000";
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            if (textBox7.Text.All(Char.IsDigit) == true && textBox8.Text.All(Char.IsDigit) == true && textBox9.Text.All(Char.IsDigit) == true)
             {
                    buffrecord = new Record(new ClientInfo(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text)), new TourInfo(textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(numericUpDown1.Value), comboBox1.Text, textBox5.Text, Convert.ToInt32(textBox9.Text)));
                    this.buffF.AddRecord(buffrecord);
                    this.Close();
            }
            else
            { 
               MessageBox.Show("Вы ввели неправильный символ в поле для цифр");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }
    }
}
