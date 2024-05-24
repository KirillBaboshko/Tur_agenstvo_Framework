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

namespace Tur_agenstvo_Framework
{
    public partial class FormEdit2 : Form
    {
        int indexOfRecords;
        mainForm buffF;
        public FormEdit2(mainForm f, int index)
        {
            InitializeComponent();
            textBox1.Text = f.records[index].Client.Name;
            textBox2.Text = f.records[index].Client.Surname;
            textBox3.Text = f.records[index].Client.Secondname;
            textBox7.Text = f.records[index].Client.seriesOfPassport.ToString();
            textBox8.Text = f.records[index].Client.numberOfPassport.ToString();
            textBox4.Text = f.records[index].Tour.NameOfTour;
            textBox5.Text = f.records[index].Tour.Country;
            dateTimePicker1.Value = f.records[index].Tour.StartDate;
            dateTimePicker2.Value = f.records[index].Tour.EndDate;
            comboBox1.Text = f.records[index].Tour.NameOfHotel;
            numericUpDown1.Value = f.records[index].Tour.CountOfPerson;
            textBox9.Text = f.records[index].Tour.Cost.ToString();
            indexOfRecords = index;
            buffF = f;
        }

        private void Edit_Click(object sender, EventArgs e)
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
                for (int i = 0; i < buffF.records.Count; i++)
                {
                    if (i == indexOfRecords)
                    {
                        buffF.records[i].Client.Name = textBox1.Text;
                        buffF.records[i].Client.Surname = textBox2.Text;
                        buffF.records[i].Client.Secondname = textBox3.Text;
                        buffF.records[i].Client.seriesOfPassport = Convert.ToInt32(textBox7.Text);
                        buffF.records[i].Client.numberOfPassport = Convert.ToInt32(textBox8.Text);
                        buffF.records[i].Tour.NameOfTour = textBox4.Text;
                        buffF.records[i].Tour.Country = textBox5.Text;
                        buffF.records[i].Tour.StartDate = dateTimePicker1.Value;
                        buffF.records[i].Tour.EndDate = dateTimePicker2.Value;
                        buffF.records[i].Tour.NameOfHotel = comboBox1.Text;
                        buffF.records[i].Tour.CountOfPerson = Convert.ToInt32(numericUpDown1.Value);
                        buffF.records[i].Tour.Cost = Convert.ToInt32(textBox9.Text);
                    }
                }
                buffF.UpdateTable();
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
