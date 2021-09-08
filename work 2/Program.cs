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
            int nn;
            do
            {
                Console.Write("Enter start number: ");
                nn = Convert.ToInt32(Console.ReadLine());
            } while (nn < 0);
            int nk;
            do
            {
                Console.Write("Enter end number: ");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk < 0 && nk < nn);

            double res = 1;
            double ak;
            for(int k = nn; k <= nk; k++)
            {
                ak = (Math.Pow(k, 2) + Math.Pow(-1, (Math.Pow(k, 2) + Math.Pow(-1, k) * k)) * k) / (3 * Math.Pow(k, 2) + 5);
                res *= ak;
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
