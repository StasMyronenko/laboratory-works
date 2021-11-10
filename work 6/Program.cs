using System;

namespace work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyReverse obj = new MyReverse();
            // Console.WriteLine(obj.Rev(123));
            int[] n = { 2, 1, 3, 4, 5 };
            Console.WriteLine(obj.Max(n));
            Console.ReadLine();
        }
    }
}
