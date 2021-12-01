using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Car car1 = new Car("1 car", ConsoleColor.Red, 80, 2000);
            Car car2 = new Car("2 car", ConsoleColor.Green, 110, 2001);
            Car car3 = new Car("3 car", ConsoleColor.DarkRed, 130, 2005);
            Car car4 = new Car("4 car", ConsoleColor.Cyan, 150, 2007);
            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);
            garage.AddCar(car4);

            garage.GetCar(2000);  // get 1 car 
            garage.GetCar(ConsoleColor.Red); // get 1 car
            garage.PutCar("2 car");
            garage.PutCar(80); // put 1 car


            garage.ShowCars();

        }
    }
}
