using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_agenstvo_Framework
{
    public partial class FormFilter : Form
    {
        mainForm buffF;
        List<int> indexesOfFilter = new List<int>();
        public FormFilter(mainForm f)
        {
            InitializeComponent();
            buffF = f;
        }

        private void ButtFilter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buffF.records.Count; i++)
            {
                if ((textBox4.Text == buffF.records[i].Tour.NameOfTour && textBox4.Text != "") || (textBox5.Text == buffF.records[i].Tour.Country && textBox5.Text != "") || (dateTimePicker1.Value.ToString("dd.MM.yyyy") == buffF.records[i].Tour.StartDate.ToString("dd.MM.yyyy") && dateTimePicker1.Value != DateTime.Now) || (dateTimePicker2.Value.ToString("dd.MM.yyyy") == buffF.records[i].Tour.EndDate.ToString("dd.MM.yyyy")) && (dateTimePicker2.Value != DateTime.Now) || (comboBox1.Text == buffF.records[i].Tour.NameOfHotel && comboBox1.Text != "") || (Convert.ToInt32(numericUpDown1.Value) == buffF.records[i].Tour.CountOfPerson && Convert.ToInt32(numericUpDown1.Value) != 0))
                {
                    indexesOfFilter.Add(i);
                }
            }
            buffF.FilterTable(indexesOfFilter);
            this.Close();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }
    }
}
