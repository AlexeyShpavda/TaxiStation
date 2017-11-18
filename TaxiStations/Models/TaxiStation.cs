using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TaxiStations.Readers;
using TaxiStations.Interfaces;

namespace TaxiStations.Models
{
    class TaxiStation : IReadFiles, IWriteToFiles
    {
        List<Car> _taxiStationObj = new List<Car>();
        static int income;

        internal List<Car> TaxiStationObj { get => _taxiStationObj; set => _taxiStationObj = value; }
        public int Income { get => income; set => income = value; }

        public void ReadingFile(string fileName)
        {
            string str;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr(' ', str, 1);
                    if (str[0] == 'P')
                        TaxiStationObj.Add(new PassengerTaxi(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));
                    else if (str[0] == 'C')
                        TaxiStationObj.Add(new CargoTaxi(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));

                }
            }
        }

        public override string ToString()
        {
            string str= String.Empty;
            foreach (var element in TaxiStationObj)
            {
                str += element.ToString() + "\r\n";
            }
            return str;
        }

        public void DeleteOldCars(short year)
        {
            for (var i = 0; i < TaxiStationObj.Count; i++)
            {
                if (TaxiStationObj[i].YearOfManufacture <= year)
                {
                    TaxiStationObj.RemoveAt(i);
                    i--;
                }
            }
        }

        public void WriteToFiles(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(ToString());
                writer.WriteLine("Income of TaxiStation = " + income);
            }
        }
    }
}
