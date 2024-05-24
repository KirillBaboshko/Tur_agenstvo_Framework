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
    public partial class FormEdit : Form
    {
        mainForm buffF;
        public FormEdit(mainForm f)
        {
            InitializeComponent();
            buffF = f;
            string[] arr = new string[f.records.Count];
            for (int i = 0; i < f.records.Count; i++)
            {
                arr[i] = f.records[i].ToString();
            }
            checkedListBox1.Items.AddRange(arr);
        }

        private void Butt_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection col = checkedListBox1.CheckedIndices;
            for (int i = 0; i < buffF.records.Count; i++)
            {
                if (col.Contains(i))
                {
                    FormEdit2 fe = new FormEdit2(buffF, i);
                    fe.Show();
                }
            }
            this.Close();
        }
    }
}
