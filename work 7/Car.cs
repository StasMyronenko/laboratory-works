using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    class Car
    {
        string name;

        public string Name
        {
            set
            {
                this.name = value;
            }

            get
            {

                return this.name;
            }
        }

        ConsoleColor color;

        public ConsoleColor Color
        {
            set
            {
                this.color = value;
            }

            get
            {

                return this.color;
            }
        }

        short speed;

        public short MaxSpeed
        {
            set
            {
                this.speed = value;
            }

            get
            {

                return this.speed;
            }
        }

        short year;

        public short Year
        {
            set
            {
                this.year = value;
            }

            get
            {

                return this.year;
            }
        }

        bool in_garage;
        public bool In_garage
        {
            set
            {
                this.in_garage = value;
            }
            get
            {
                return this.in_garage;
            }
        }

        public Car(string name, ConsoleColor color, short speed, short year)
        {
            this.Name = name;
            this.Color = color;
            this.MaxSpeed = speed;
            this.Year = year;
            this.In_garage = true;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Year: {this.Year}, In garage: {this.In_garage}";
        }
    }
}
