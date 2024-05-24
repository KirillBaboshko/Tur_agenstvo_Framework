using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_agenstvo_Framework
{
    internal class TourInfo
    {
        public string NameOfTour { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public int CountOfPerson { set; get; }
        public string NameOfHotel { set; get; }
        public int Cost { set; get; }
        public string Country { set; get; }

        public TourInfo()
        {
            NameOfTour = "";
            StartDate = DateTime.Today;
            EndDate = DateTime.Today;
            CountOfPerson = 0;
            NameOfHotel = "";
            Cost = 0;
            Country = "";
        }
        public TourInfo(string nameTour, DateTime start, DateTime end, int count, string nameHotel, string country, int cost)
        {
            NameOfTour = nameTour.Replace(" ", "_");
            StartDate = start;
            EndDate = end;
            CountOfPerson = count;
            NameOfHotel = nameHotel.Replace(" ", "_");
            Cost = cost;
            Country = country.Replace(" ", "_");
        }
    }
}
