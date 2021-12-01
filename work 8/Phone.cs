using System;
using System.Collections.Generic;
using System.Text;

namespace work_8
{
    class Phone : BAWPhone {
        protected string Number2 { get; set; }
        public Phone(string number, string number2, int width, int height, double size_screen, ConsoleColor color)
            : base(number, width, height, size_screen, color)
        {
            this.Number2 = number2;
        }

        public void SendMMS(int n_sim, string number, string title, string text, string file)
        {
            if(n_sim == 1)
            {
                Console.WriteLine("You send message from " + this.Number + " to " + number + ". \nTitle: " + title + "\nText: " + text);
                Console.WriteLine("And file: " + file);
            }
            else if(n_sim == 2)
            {
                Console.WriteLine("You send message from " + this.Number2 + " to " + number + ". \nTitle: " + title + "\nText: " + text);
                Console.WriteLine("And file: " + file);
            }
        }

        public void GetMMS(string number)
        {
            Console.WriteLine("You get MMS from " + number);
        }

        public override void CallTo(string number)
        {
            Console.WriteLine("Enter your sim number");
        }

        public void CallTo(int n_sim, string number)
        {
            if (number == this.Number || number == this.Number2)
            {
                Console.WriteLine("You cann't calling yourself");
            }
            else if (!this._call)
            {
                this._call = true;
                this._number = number;
                Console.WriteLine("You calling " + number);
            }
            else
            {
                Console.WriteLine("Now you talking on with " + this._number);
            }
        }

        public override void SendMessage(string number, string title, string text)
        {
            Console.WriteLine("Enter your sim number");
        }

        public void SendMessage(int n_sim, string number, string title, string text)
        {
            if (n_sim == 1)
            {
                Console.WriteLine("You send message from " + this.Number + " to " + number + ". \nTitle: " + title + "\nText: " + text);

            }
            else if (n_sim == 2)
            {
                Console.WriteLine("You send message from " + this.Number2 + " to " + number + ". \nTitle: " + title + "\nText: " + text);

            }
        }

    }
}
