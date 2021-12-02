using System;

/*
 Added
2.  Гараж шейха 
Створити клас, який буде уособлювати Гараж Шейха. Створити клас, який буде уособлювати Автомобіль. В Гаражі зберігається необмежена кількість Автомобілів. Шейх може купити новий Автомобіль в Гараж, чи викинути існуючий. Також Шейх може взяти машину покататися за певними критеріями: за ім’ям машини, кольором, швидкістю, року випуску (за всіма параметрами, або частково). Після введення параметру на екран виводяться всі Автомобілі з Гаражу Шейха, які підходять за цими параметрами

 */

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
