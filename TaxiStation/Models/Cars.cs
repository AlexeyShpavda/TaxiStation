using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStations.Models
{
    class Cars
    {
        string _carName;
        string _carNumber;
        short _yearOfManufacture;
        int _carMileage;
        short _fuelConsumption;
        // For 100 kilometers.

        public string CarName { get => _carName; set => _carName = value; }
        public string CarNumber { get => _carNumber; set => _carNumber = value; }
        public short YearOfManufacture { get => _yearOfManufacture; set => _yearOfManufacture = value; }
        public int CarMileage { get => _carMileage; set => _carMileage = value; }
        public short FuelConsumption { get => _fuelConsumption; set => _fuelConsumption = value; }

        public Cars(string carName, string carNumber, string yearOfManufacture, string carMileage, string fuelConsumption)
        {
            CarName = carName;
            CarNumber = carNumber;
            YearOfManufacture = Convert.ToInt16(yearOfManufacture);
            CarMileage = Convert.ToInt32(carMileage);
            FuelConsumption = Convert.ToInt16(fuelConsumption);
        }
    }
}
