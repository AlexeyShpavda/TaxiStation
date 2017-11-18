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
            string l = "====================================================================================================================";
            LineBreaker line = new LineBreaker();

            TaxiStation taxiStation = new TaxiStation();
            taxiStation.ReadingFile("input.txt");

            // List of Cars in TaxiStation.
            Console.WriteLine("Initial data");
            Console.WriteLine(l);
            Console.Write(taxiStation);
            Console.WriteLine(l);

            // Remove from the park cars, the year of manufacture is less than 2000.
            taxiStation.DeleteOldCars(2000);
            Console.WriteLine("After removing old cars");
            Console.WriteLine(l);
            Console.Write(taxiStation);
            Console.WriteLine(l);

            // Sort cars in ascending order of mileage.
            taxiStation.TaxiStationObj.Sort();
            Console.WriteLine("After sorting");
            Console.WriteLine(l);
            Console.Write(taxiStation);
            Console.WriteLine(l);

            // Сalculates TaxiStation income per day.
            foreach(var car in taxiStation.TaxiStationObj)
            {
                short hoursOrlength;
                if(car is CargoTaxi)
                {
                    Console.Write("Enter the number of hours worked --> ");
                }
                else
                {
                    Console.Write("Enter the length of the trip (km.) --> ");
                }
                hoursOrlength = Convert.ToInt16(Console.ReadLine());
                taxiStation.Income += car.ReturnsIncome(hoursOrlength);
            }
            Console.WriteLine("Income of TaxiStation = " + taxiStation.Income);

            // Write down a list of cars and income in file.
            taxiStation.WriteToFiles("output.txt");

            Console.ReadKey();
        }
    }
}
