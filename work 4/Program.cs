using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter count elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float[] arr = new float[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool now = false;

            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if(!now && arr[i + 1] >= arr[i])
                {
                    now = true;
                    count++;
                }
                else if(now && arr[i + 1] < arr[i])
                {
                    now = false;
                }
            }
            Console.WriteLine("Count intervals is {0}", count);
            Console.ReadLine();
        }
    }
}
