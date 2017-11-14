using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStations.Models
{
    class PassengerTaxi : Car
    {
        short _numberOfPassangers;
        short _tripPrice;
        // For 5 kilometers.

        public short NumberOfPassangers { get => _numberOfPassangers; set => _numberOfPassangers = value; }
        public short TripPrice { get => _tripPrice; set => _tripPrice = value; }

        public PassengerTaxi(string carName, string carNumber, string yearOfManufacture, string carMileage,
            string fuelConsumption, string numberOfPassangers, string tripPrice) : base(carName, carNumber, yearOfManufacture, carMileage, fuelConsumption)
        {
            NumberOfPassangers = Convert.ToInt16(numberOfPassangers);
            TripPrice = Convert.ToInt16(tripPrice);
        }


    }
}
