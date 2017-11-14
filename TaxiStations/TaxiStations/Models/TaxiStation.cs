using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TaxiStations.Readers;

namespace TaxiStations.Models
{
    class TaxiStation
    {
        List<Car> _taxiStationObj = new List<Car>();

        internal List<Car> TaxiStationObj { get => _taxiStationObj; set => _taxiStationObj = value; }

        public List<Car> FillingStation(string fileName)
        {
            List<Car> cars = new List<Car>();
            string str;
            using (StreamReader reader = new StreamReader(fileName))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    LineBreaker lr = new LineBreaker();
                    string[] words = lr.ReturnWordArr(' ', str);
                    if (str[0] == 'P')
                    // P = Passanger.
                    {
                        cars.Add(new PassengerTaxi(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));
                    }
                    else if (str[0] == 'C')
                    // C = Cargo.
                    {
                        cars.Add(new CargoTaxi(words[0], words[1], words[2], words[3], words[4], words[5], words[6]));
                    }
                }
            }
            return cars;
        }
    }
}
