using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_work
{
    class Program
    {
        static void Main(string[] args)
        {
            float y;
            Console.WriteLine("Input X:");
            String strX = Console.ReadLine();

            float x = Convert.ToSingle(strX);
            y = Convert.ToSingle(2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) + +4 * Math.Pow(x, 2) - 5 * x + 6);
            Console.WriteLine("y = " + y);

            Console.ReadLine();
        }
    }
}
