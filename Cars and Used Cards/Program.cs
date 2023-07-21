using Cars_Object;
using System.ComponentModel.Design;
using UsedCars_Object;
using Validator_Object;

Car.cars.Add(new Car());
Car.cars.Add(new Car("Toyota", "Camry", 2022, 25000.00m));
Car.cars.Add(new Car("Honda", "Accord", 2021, 27000.00m));
Car.cars.Add(new Car("Ford", "Mustang", 2023, 35000.75m));
Car.cars.Add(new UsedCar("Toyota", "Camry", 2019, 18000.00m, 40000));
Car.cars.Add(new UsedCar("Honda", "Accord", 2018, 17000.00m, 45000));
Car.cars.Add(new UsedCar("Ford", "Mustang", 2017, 22000.00m, 35000));
Console.WriteLine("Welcome to the car buyer app.");
Car.ListCars();

bool runProgram = true;
//determine if admin
Console.WriteLine("Are you an admin?");
bool admin = Validator.Continue();
while (runProgram)
{
    int input = -1;
    bool modifyCar = false;
    bool buyCar = false;
    //If user isn't an admin then they can buy a car.
    if (!admin)
    {
        while (true)//validation loop
        {
            Console.WriteLine("Enter the Index of the car you would like to buy.");
            input = Validator.IntValidator();
            if (input > 0 && input < Car.cars.Count())
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and " + Car.cars.Count());
            }
        }
        //buy car
        Car boughtCar = Car.Remove(input);
        Console.WriteLine("You bought a " + boughtCar.Model);
        Car.ListCars();
        //sell car back
        if (Car.BuyBack(boughtCar))
        {
            Car.ListCars();
        }
    }
    //if user is an admin then they can modify or custom buy cars to add to the list.
    else
    {

        while (!modifyCar && !buyCar)
        {
            Console.WriteLine("Welcome Admin. Please enter the index of the car you want to modify.");
            Console.WriteLine("Or press type \"buy\" to purchase new cars for the app.");
            string response = Console.ReadLine().ToLower().Trim();
            if (int.TryParse(response, out input))
            {
                if (input > 0 && input < Car.cars.Count())
                {
                    modifyCar = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and " + Car.cars.Count());
                }
            }

            else if ("buy".Contains(response))
            {
                buyCar = true;
            }
            else
            {
                Console.WriteLine("Invalid response.");
            }
        }



        //modify car
        if (modifyCar)
        {

            Car newCar = Car.ModifyCar(Car.cars[input]);
            Console.WriteLine($"Modified Car Make: {newCar.Model}, Model:");
        }
        //by brand new 2013 dodge chargers
        if (buyCar)
        {
            Console.WriteLine("Only generic brand new 2013 Dodge Chargers are available at this time.");
            Console.WriteLine("Would you like to add one to the inventory?");
            while (Validator.Continue())
            {
                Console.WriteLine("One 2013 Dodge Charger added to inventory.");
                Car.cars.Add(new Car());
                Console.WriteLine("Buy another?");
            }
        }
        //view updated inventory
        Console.WriteLine("View updated inventory?");
        if (Validator.Continue())
        {
            Car.ListCars();
        }
    }
    Console.WriteLine("Continue using app?");
    runProgram=Validator.Continue();
}
Console.WriteLine("Good Bye");