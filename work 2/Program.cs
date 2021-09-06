using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 3 digital number:");
            int res = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[3];
            if (res > 99 && res < 1000)
            {
                for (int i = 0; i < 3; i++)
                {
                    arr[i] = res % 10;
                    res /= 10;
                }
                if (arr[0] - arr[1] == arr[1] - arr[2])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine("Error. Not 3 digital");
            }

            Console.ReadLine();
        }
    }
}
