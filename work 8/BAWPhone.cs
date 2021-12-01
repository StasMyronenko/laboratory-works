using System;
using System.Collections.Generic;
using System.Text;

namespace work_8
{
    class BAWPhone : HousePhone
    {

        protected int Width { get; set; }

        protected int Height { get; set; }

        protected double SizeScreen { get; set; }
        protected ConsoleColor Color { get; set; }


        public BAWPhone(string number, int width, int height, double size_screen, ConsoleColor color)
            : base(number)
        {
            string str = "qwertyuiop[]asdfghjkl;'\\zxcvbnm,./!@$%^&(){}|`'\"QWERTYUIOPASDFGHJKLZXCVBNM<>?-=~";
            for (int i = 0; i < str.Length - 1; i++)
            {
                symbols.Add(str[i]);
            }
            this.Width = width;
            this.Height = height;
            this.SizeScreen = size_screen;
            this.Color = color;
        }

        public virtual void SendMessage(string number, string title, string text)
        {
            Console.WriteLine("You send message to " + number + ". \nTitle: " + title + "\nText: " + text + '\n');
        }

        public void GetMessage(string number)
        {
            Console.WriteLine(number + " send message for you.");
        }
    }
}
