using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO;
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
            taxiStation.TaxiStationObj = taxiStation.FillingStation("Input.txt");

            //123123123
            Console.WriteLine(taxiStation);

            Console.ReadKey();
        }
    }
}
