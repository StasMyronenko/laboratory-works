using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    class Garage
    {

        List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car c)
        {
            this.cars.Add(c);
        }

        public void DeleteCar(Car c)
        {
            this.cars.Remove(c);
        }

        public void GetCar(string name)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (this.cars[i].Name == name && this.cars[i].In_garage)
                {
                    this.cars[i].In_garage = false;
                    Console.WriteLine("Done");
                    break;

                }
                else if (this.cars[i].Name == name && !this.cars[i].In_garage)
                {
                    Console.WriteLine("This car isn't in garage now.");
                    break;
                }
                else if (i == this.cars.Count - 1)
                {
                    Console.WriteLine("This car not found");

                }
            }
        }

        public void GetCar(ConsoleColor color)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (this.cars[i].Color == color && this.cars[i].In_garage)
                {
                    this.cars[i].In_garage = false;
                    Console.WriteLine("Done");
                    break;

                }
                else if (this.cars[i].Color == color && !this.cars[i].In_garage)
                {
                    Console.WriteLine("This car isn't in garage now.");
                    break;
                }
                else if (i == this.cars.Count - 1)
                {
                    Console.WriteLine("This car not found");

                }
            }
        }

        public void GetCar(int dig)
        {
            if (dig < 1000)
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (this.cars[i].MaxSpeed == dig && this.cars[i].In_garage)
                    {
                        this.cars[i].In_garage = false;
                        Console.WriteLine("Done");
                        break;

                    }
                    else if (this.cars[i].MaxSpeed == dig && !this.cars[i].In_garage)
                    {
                        Console.WriteLine("This car isn't in garage now.");
                        break;
                    }
                    else if (i == this.cars.Count - 1)
                    {
                        Console.WriteLine("This car not found");

                    }
                }
            }
            else
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (this.cars[i].Year == dig && this.cars[i].In_garage)
                    {
                        this.cars[i].In_garage = false;
                        Console.WriteLine("Done");
                        break;

                    }
                    else if (this.cars[i].Year == dig && !this.cars[i].In_garage)
                    {
                        Console.WriteLine("This car isn't in garage now.");
                        break;
                    }
                    else if (i == this.cars.Count - 1)
                    {
                        Console.WriteLine("This car not found");

                    }
                }
            }

        }


        public void PutCar(string name)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (this.cars[i].Name == name && !this.cars[i].In_garage)
                {
                    this.cars[i].In_garage = true;
                    Console.WriteLine("Done");
                    break;
                }
                else if (this.cars[i].Name == name && this.cars[i].In_garage)
                {
                    Console.WriteLine("This car was parked in garage");
                    break;
                }
                else if (i == this.cars.Count - 1)
                {
                    Console.WriteLine("This car not found");

                }
            }
        }

        public void PutCar(ConsoleColor color)
        {
            for (int i = 0; i < this.cars.Count; i++)
            {
                if (this.cars[i].Color == color && !this.cars[i].In_garage)
                {
                    this.cars[i].In_garage = true;
                    Console.WriteLine("Done");
                    break;
                }
                else if (this.cars[i].Color == color && this.cars[i].In_garage)
                {
                    Console.WriteLine("This car was parked in garage");
                    break;
                }
                else if (i == this.cars.Count - 1)
                {
                    Console.WriteLine("This car not found");

                }
            }
        }

        public void PutCar(int dig)
        {
            if (dig < 1000)
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (this.cars[i].MaxSpeed == dig && !this.cars[i].In_garage)
                    {
                        this.cars[i].In_garage = true;
                        Console.WriteLine("Done");
                        break;
                    }
                    else if (this.cars[i].MaxSpeed == dig && this.cars[i].In_garage)
                    {
                        Console.WriteLine("This car was parked in garage");
                        break;
                    }
                    else if (i == this.cars.Count - 1)
                    {
                        Console.WriteLine("This car not found");

                    }
                }
            }
            else
            {
                for (int i = 0; i < this.cars.Count; i++)
                {
                    if (this.cars[i].Year == dig && !this.cars[i].In_garage)
                    {
                        this.cars[i].In_garage = true;
                        Console.WriteLine("Done");
                        break;
                    }
                    else if (this.cars[i].Year == dig && this.cars[i].In_garage)
                    {
                        Console.WriteLine("This car was parked in garage");
                        break;
                    }
                    else if (i == this.cars.Count - 1)
                    {
                        Console.WriteLine("This car not found");

                    }
                }
            }

        }



        public void ShowCars()
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                Console.BackgroundColor = this.cars[i].Color;
                Console.WriteLine(this.cars[i].ToString());
            }
            Console.BackgroundColor = before;
        }
    }
}
