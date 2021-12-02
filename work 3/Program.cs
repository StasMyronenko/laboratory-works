using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 lab2
 У всіх завданнях даного пункту потрібно вивести логічне значення True, якщо приведений вислів для запропонованих початкових даних є істинним, і значення False у супротивному випадку. Всі числа, для яких вказано кількість цифр (двозначне число, тризначне число і т.д.), вважаються цілими. 
Перевірити істинність вислову: "Цифри даного тризначного числа утворюють арифметичну прогресію". 
 */

namespace work_3
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
