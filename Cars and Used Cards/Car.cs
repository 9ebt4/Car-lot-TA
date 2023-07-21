using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsedCars_Object;
using Validator_Object;

namespace Cars_Object
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }
        public Car()
        {
            Make = "Dodge";
            Model = "Charger";
            Year = 2013;
            Price = 45000m;
        }
        public static List<Car> cars = new List<Car>();
        public static string ToString(Car car)
        {

            return String.Format("{0,-15}{1,-15}{2,-15}{3,15}", car.Make, car.Model, car.Year, car.Price);

        }

        public static void ListCars()
        {
            Console.WriteLine(String.Format("#  {0,-15}{1,-15}{2,-15}{3,15}{4,15}", "Make", "Model", "Year", "Price", "Mileage"));
            Console.WriteLine(String.Format("-  {0,-15}{1,-15}{2,-15}{3,15}{4,15}", "----", "-----", "----", "-----", "-------"));
            for (int i = 1; i < cars.Count; i++)
            {
                if (cars[i] is UsedCar uCar)
                {
                    Console.WriteLine($"{i}. {UsedCar.ToString(uCar)}");
                }
                else
                {
                    Console.WriteLine($"{i}. {Car.ToString(cars[i])}");
                }
            }
        }

        public static Car Remove(int index)
        {
            Car newCar = cars[index];
            cars.RemoveAt(index);
            return newCar;

        }

        public static bool BuyBack(Car car)
        {
            Console.WriteLine("Would you like to sell your car back?");
            if (Validator.Continue())
            {
                if (car is UsedCar uCar)
                {
                    cars.Add(new UsedCar(uCar.Make, uCar.Model, uCar.Year, uCar.Price, uCar.Mileage + 10000));
                }
                else
                {
                    cars.Add(new UsedCar(car.Make, car.Model, car.Year, car.Price, 10000));
                }
                return true;
            }
            return false;
        }
        public static Car ModifyCar(Car car)
        {
            if (car is UsedCar uCar)
            {
                Console.WriteLine("Modify Make?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new make.");
                    string make = Console.ReadLine().Trim();
                    Console.WriteLine($"Confirm {make} as the new make name.");
                    if (Validator.Continue())
                    {
                        uCar.Make = make;
                    }
                    else
                    {
                        Console.WriteLine("Make Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify Model?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new Model.");
                    string model = Console.ReadLine().Trim();
                    Console.WriteLine($"Confirm {model} as the new model name.");
                    if (Validator.Continue())
                    {
                        uCar.Model = model;
                    }
                    else
                    {
                        Console.WriteLine("Model Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify Year?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new Year.");
                    int year = Validator.IntValidator();
                    Console.WriteLine($"Confirm {year} as the new year");
                    if (Validator.Continue())
                    {
                        uCar.Year = year;
                    }
                    else
                    {
                        Console.WriteLine("Year Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify price?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new price.");
                    decimal price = Validator.DecimalValidator();
                    Console.WriteLine($"Confirm {price} as the new price");
                    if (Validator.Continue())
                    {
                        uCar.Price = price;
                    }
                    else
                    {
                        Console.WriteLine("Price Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify Mileage?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new mileage.");
                    decimal price = Validator.DecimalValidator();
                    Console.WriteLine($"Confirm {price} as the new mileage");
                    if (Validator.Continue())
                    {
                        uCar.Price = price;
                    }
                    else
                    {
                        Console.WriteLine("Mileage Change Cancelled.");
                    }
                }
                return uCar;

            }
            else
            {

                Console.WriteLine("Modify Make?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new make.");
                    string make = Console.ReadLine().Trim();
                    Console.WriteLine($"Confirm {make} as the new make name.");
                    if (Validator.Continue())
                    {
                        car.Make = make;
                    }
                    else
                    {
                        Console.WriteLine("Make Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify Model?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new Model.");
                    string model = Console.ReadLine().Trim();
                    Console.WriteLine($"Confirm {model} as the new model name.");
                    if (Validator.Continue())
                    {
                        car.Model = model;
                    }
                    else
                    {
                        Console.WriteLine("Model Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify Year?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new Year.");
                    int year = Validator.IntValidator();
                    Console.WriteLine($"Confirm {year} as the new year");
                    if (Validator.Continue())
                    {
                        car.Year = year;
                    }
                    else
                    {
                        Console.WriteLine("Year Change Cancelled.");
                    }
                }
                Console.WriteLine("Modify price?");
                if (Validator.Continue())
                {
                    Console.WriteLine("Enter new price.");
                    decimal price = Validator.DecimalValidator();
                    Console.WriteLine($"Confirm {price} as the new price");
                    if (Validator.Continue())
                    {
                        car.Price = price;
                    }
                    else
                    {
                        Console.WriteLine("Price Change Cancelled.");
                    }
                }
                return car;
            }


        }
    }
}