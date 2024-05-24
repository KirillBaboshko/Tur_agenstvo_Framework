using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Tur_agenstvo_Framework;
using static System.Console;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Linq;
namespace Tur_agenstvo_Framework
{

    public partial class mainForm : Form
    {
        string path = @"D:\TourAgent\TourAgentDB.txt";
        internal List<Record> records = new List<Record>();
        public mainForm()
        {
            InitializeComponent();

        }
        private void ButtSaveToFile_Click(object sender, EventArgs e)
        {
            File.Delete(path);

            for (int i = 0; i < records.Count; i++)
            {
                if (i == 0)
                {
                    File.AppendAllText(path, records[i].ToString());
                }
                else
                {
                    File.AppendAllText(path, $"\n{records[i].ToString()}");
                }

            }
        }
        private void ButtLoadFromFile_Click(object sender, EventArgs e)
        {
            string[] fileText = File.ReadAllLines(path);
            foreach (string str in fileText)
            {
                str.Replace("\n", "");
                string[] info = str.Split(new char[] { ' ' });
                Record buffrecord = new Record();
                for (int i = 0; i < info.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                buffrecord.Client.Surname = info[i];
                                break;
                            }
                        case 1:
                            {
                                buffrecord.Client.Name = info[i];
                                break;
                            }
                        case 2:
                            {
                                buffrecord.Client.Secondname = info[i];
                                break;
                            }
                        case 3:
                            {
                                buffrecord.Client.seriesOfPassport = Convert.ToInt32(info[i]);
                                break;
                            }
                        case 4:
                            {
                                buffrecord.Client.numberOfPassport = Convert.ToInt32(info[i]);
                                break;
                            }
                        case 5:
                            {
                                buffrecord.Tour.NameOfTour = info[i];
                                break;
                            }
                        case 6:
                            {
                                buffrecord.Tour.StartDate = Convert.ToDateTime(info[i]);
                                break;
                            }
                        case 7:
                            {
                                buffrecord.Tour.EndDate = Convert.ToDateTime(info[i]);
                                break;
                            }
                        case 8:
                            {
                                buffrecord.Tour.Country = info[i];
                                break;
                            }
                        case 9:
                            {
                                buffrecord.Tour.NameOfHotel = info[i];
                                break;
                            }
                        case 10:
                            {
                                buffrecord.Tour.CountOfPerson = Convert.ToInt32(info[i]);
                                break;
                            }
                        case 11:
                            {
                                buffrecord.Tour.Cost = Convert.ToInt32(info[i]);
                                break;
                            }
                        default:
                            {
                                WriteLine("Ошибка при считывании из файла");
                                break;
                            }

                    }
                }
                records.Add(buffrecord);
            }
            for (int i = 0; i < records.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = (i + 1).ToString();
                row.Cells.Add(cell);
                string[] str = records[i].ToString().Split(new char[] { ' ' });
                for (int j = 0; j < str.Length; j++)
                {
                    DataGridViewCell buffcell = new DataGridViewTextBoxCell();
                    str[j] = str[j].Replace("_", " ");
                    buffcell.Value = str[j];
                    row.Cells.Add(buffcell);
                }
                GridTable.Rows.Add(row);
            }
        }

        private void ButtAdd_Click(object sender, EventArgs e)
        {
            FormAdd newForm = new FormAdd(this);
            newForm.Show();

        }
        internal void AddRecord(Record rec)
        {
            records.Add(rec);
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = (records.Count).ToString();
            row.Cells.Add(cell);
            string[] str = records[records.Count - 1].ToString().Split(new char[] { ' ' });
            for (int i = 0; i < str.Length; i++)
            {
                DataGridViewCell buffcell = new DataGridViewTextBoxCell();
                str[i] = str[i].Replace("_", " ");
                buffcell.Value = str[i];
                row.Cells.Add(buffcell);
            }
            GridTable.Rows.Add(row);
        }
        internal void UpdateTable()
        {
            GridTable.Rows.Clear();
            for (int i = 0; i < records.Count; i++)
            {
                AddRow(i);
            }

        }
        internal void FilterTable(List<int> indexes)
        {
            GridTable.Rows.Clear();
            foreach (var index in indexes)
            {
                AddRow(index);
            }
        }
        private void AddRow(int i)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            cell.Value = (i + 1).ToString();
            row.Cells.Add(cell);
            string[] str = records[i].ToString().Split(new char[] { ' ' });
            for (int j = 0; j < str.Length; j++)
            {
                DataGridViewCell buffcell = new DataGridViewTextBoxCell();
                str[j] = str[j].Replace("_", " ");
                buffcell.Value = str[j];
                row.Cells.Add(buffcell);
            }
            GridTable.Rows.Add(row);
        }
        private void ButtDel_Click(object sender, EventArgs e)
        {
            FormDel newForm = new FormDel(this);
            newForm.Show();
        }
        private void ButtSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSeriesOfPassport.Text.All(Char.IsDigit) == true && textBoxNumberOfPassport.Text.All(Char.IsDigit) == true)
            {
                if (textBoxNumberOfPassport.Text == "")
                {
                    textBoxNumberOfPassport.Text = "000000";
                }
                  
                if (textBoxSeriesOfPassport.Text == "")
                {
                    textBoxSeriesOfPassport.Text = "0000";
                }
                ClientInfo buffClient = new ClientInfo(textBoxName.Text, textBoxSurname.Text, textBoxSecondName.Text, Convert.ToInt32(textBoxSeriesOfPassport.Text), Convert.ToInt32(textBoxNumberOfPassport.Text));
                for (int i = 0; i < records.Count; i++)
                {
                    if ((textBoxNumberOfPassport.Text == "000000" && textBoxSeriesOfPassport.Text == "0000") && ((records[i].Client.Name == buffClient.Name) && (records[i].Client.Surname == buffClient.Surname) && (records[i].Client.Secondname == buffClient.Secondname)))
                    {
                        GridTable.Rows.Clear();
                        AddRow(i);
                        break;
                    }
                    else if ((textBoxName.Text == "" && textBoxSurname.Text == "" && textBoxSecondName.Text == "") && ((records[i].Client.seriesOfPassport == buffClient.seriesOfPassport) && (records[i].Client.numberOfPassport == buffClient.numberOfPassport)))
                    {
                        GridTable.Rows.Clear();
                        AddRow(i);
                        break;
                    }
                    else if (((records[i].Client.Name == buffClient.Name) && (records[i].Client.Surname == buffClient.Surname) && (records[i].Client.Secondname == buffClient.Secondname) && (records[i].Client.seriesOfPassport == buffClient.seriesOfPassport) && (records[i].Client.numberOfPassport == buffClient.numberOfPassport)))
                    {
                        GridTable.Rows.Clear();
                        AddRow(i);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный символ в поле для цифр");
            }
        }

        private void ButtUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void ButtFilter_Click(object sender, EventArgs e)
        {
            FormFilter newForm = new FormFilter(this);
            newForm.Show();
        }

        private void ButtEdit_Click(object sender, EventArgs e)
        {
            FormEdit newForm = new FormEdit(this);
            newForm.Show();
        }

        private void ButtDiagram_Click(object sender, EventArgs e)
        {
            FormDiagram newForm = new FormDiagram(this);
            newForm.Show();
        }
    }
}
