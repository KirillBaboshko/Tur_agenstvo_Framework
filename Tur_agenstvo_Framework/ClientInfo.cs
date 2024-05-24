using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tur_agenstvo_Framework
{
    internal class ClientInfo
    {
        public string Name { set; get; }
        public string Surname { set; get; }
        public string Secondname { set; get; }

        public int seriesOfPassport { set; get; }
        public int numberOfPassport { set; get; }
        public void SetSeriesOfPassportt(int value)
        {
            if (value.ToString().Length == 4)
            {
                seriesOfPassport = value;
            }
            else
            {
                MessageBox.Show("Серия паспорта должна состоять из 4 цифр "); ;
            }
        }
        public void SetNumberOfPassport(int value)
        {
            if (value.ToString().Length == 6)
            {
                numberOfPassport = value;
            }
            else
            {
                MessageBox.Show("Номер паспорта должен состоять из 6 цифр "); ;
            }
        }

        public ClientInfo()
        {
            Name = "";
            Surname = "";
            Secondname = "";
            seriesOfPassport = 0000;
            numberOfPassport = 000000;
        }
        public ClientInfo(string name, string surname, string secondename, int series, int number)
        {
            Name = name.Replace(" ", "_"); ;
            Surname = surname.Replace(" ", "_"); ;
            Secondname = secondename.Replace(" ", "_"); ;
            SetNumberOfPassport(number);
            SetSeriesOfPassportt(series);
        }
    };
}
