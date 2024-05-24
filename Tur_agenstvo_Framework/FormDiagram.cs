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
    public partial class FormDiagram : Form
    {
        mainForm buffF;
        bool flag=true;
        public FormDiagram(mainForm f)
        {
            InitializeComponent();
            buffF = f;
            for (int i = 0; i < buffF.records.Count; i++)
            {
                flag = true;
                for (int j=0;j< ChartTurName.Series[0].Points.Count;j++)
                {
                    if (buffF.records[i].Tour.NameOfTour== ChartTurName.Series[0].Points[j].AxisLabel)
                    {
                        ChartTurName.Series[0].Points[j].SetValueY(ChartTurName.Series[0].Points[j].YValues.First()+1);
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    ChartTurName.Series[0].Points.Add(1,1);
                    ChartTurName.Series[0].Points[ChartTurName.Series[0].Points.Count - 1].AxisLabel = buffF.records[i].Tour.NameOfTour.Replace("_", " "); ;
                }
            }
            flag = true;
            for (int i = 0; i < buffF.records.Count; i++)
            {
                for (int j = 0; j < ChartCost.Series[0].Points.Count; j++)
                {
                    if (buffF.records[i].Tour.CountOfPerson == ChartCost.Series[0].Points[j].XValue)
                    {
                        ChartCost.Series[0].Points[j].SetValueY(ChartCost.Series[0].Points[j].YValues.First() + buffF.records[i].Tour.Cost);
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    ChartCost.Series[0].Points.AddXY( buffF.records[i].Tour.CountOfPerson, buffF.records[i].Tour.Cost);
                }
            }
        }
    }
}
