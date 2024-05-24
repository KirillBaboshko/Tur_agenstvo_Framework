using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_agenstvo_Framework;

namespace Tur_agenstvo_Framework
{
    internal class Record
    {
        public ClientInfo Client;
        public TourInfo Tour;
        public Record()
        {
            Client = new ClientInfo();
            Tour = new TourInfo();
        }
        public Record(ClientInfo client, TourInfo tour)
        {
            Client = client;
            Tour = tour;
        }
        public override string ToString()
        {
            return $"{Client.Surname} {Client.Name} {Client.Secondname} {Client.seriesOfPassport} {Client.numberOfPassport} {Tour.NameOfTour} {Tour.StartDate.ToString("dd.MM.yyyy")} {Tour.EndDate.ToString("dd.MM.yyyy")} {Tour.Country} {Tour.NameOfHotel} {Tour.CountOfPerson} {Tour.Cost}";
        }
    }
}

