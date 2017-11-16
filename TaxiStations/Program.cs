using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiStations.Interfaces;
using TaxiStations.Models;
using TaxiStations.Readers;

namespace TaxiStations
{
    class Program
    {
        static void Main()
        {
            string l = "=====================================";
            LineBreaker line = new LineBreaker();

            TaxiStation taxiStation = new TaxiStation();
            taxiStation.FillingStation("input.txt");

            Console.Write(taxiStation);

            Console.ReadKey();
        }
    }
}
