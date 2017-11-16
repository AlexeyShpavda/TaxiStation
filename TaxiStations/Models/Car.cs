using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStations.Models
{
    abstract class Car
    {
        string _carName;
        string _carNumber;
        short _yearOfManufacture;
        int _carMileage;
        short _fuelConsumption;
        // For 100 kilometers.

        protected string CarName { get => _carName; set => _carName = value; }
        protected string CarNumber { get => _carNumber; set => _carNumber = value; }
        protected short YearOfManufacture { get => _yearOfManufacture; set => _yearOfManufacture = value; }
        protected int CarMileage { get => _carMileage; set => _carMileage = value; }
        protected short FuelConsumption { get => _fuelConsumption; set => _fuelConsumption = value; }

        public Car(string carName, string carNumber, string yearOfManufacture, string carMileage, string fuelConsumption)
        {
            CarName = carName;
            CarNumber = carNumber;
            YearOfManufacture = Convert.ToInt16(yearOfManufacture);
            CarMileage = Convert.ToInt32(carMileage);
            FuelConsumption = Convert.ToInt16(fuelConsumption);
        }

        public override string ToString()
        {
            string str = CarName + " " + CarNumber + " " + YearOfManufacture.ToString() + " " + CarMileage.ToString() + " " + FuelConsumption.ToString();
            return str;
        }
    }
}
