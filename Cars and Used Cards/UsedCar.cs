using Cars_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCars_Object
{
    public class UsedCar:Car
    {
        public double Mileage { get; set; }
        public UsedCar(string make, string model, int year, decimal price, double mileage):base( make, model, year, price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public static string ToString(UsedCar car)
        {
            return string.Format("{0,-15}{1,-15}{2,-15}{3,15}{4,15}", car.Make, car.Model, car.Year, car.Price, car.Mileage);
        }
        
    }
}
