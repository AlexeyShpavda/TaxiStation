using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStations.Models
{
    class CargoTaxi : Car
    {
        int _carrying;
        // Kilograms.
        short _pricePerHour;

        public int Carrying { get => _carrying; set => _carrying = value; }
        public short PricePerHour { get => _pricePerHour; set => _pricePerHour = value; }

        public CargoTaxi(string carName, string carNumber, string yearOfManufacture, string carMileage,
                    string fuelConsumption, string carrying, string pricePerHour) : base(carName, carNumber, yearOfManufacture, carMileage, fuelConsumption)
        {
            Carrying = Convert.ToInt32(carrying);
            PricePerHour = Convert.ToInt16(pricePerHour);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("|Carrying: {0,-12}|PricePerHour: {1,-3}", Carrying, PricePerHour);
        }

        public override int ReturnsIncome(short hours)
        {
            if(hours <= 1)
                return hours * PricePerHour;
            else
                return ((1 * PricePerHour) + ((hours - 1) * (PricePerHour / 2)));
        }
    }
}
