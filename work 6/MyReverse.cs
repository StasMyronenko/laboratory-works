using System;
using System.Collections.Generic;
using System.Text;

namespace work_6
{
    class MyReverse
    {
        public int Rev(int a)
        {
            if(a == 0)
            {
                return 0;
            }
            return (a % 10) * Convert.ToInt32(Math.Pow(10, Convert.ToString(a).Length - 1)) + Rev(Convert.ToInt32(a / 10));
            
        }

        public string Rev(string str, char mag = ',')
        {

            bool simple = true;
            int magic_index = 0;
            

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == mag)
                {
                    simple = false;
                    magic_index = i;
                    break;
                }
            }
            
            if (str.Length == 1)
            {
                return str;
                }
            if (simple)
            {
                return str[str.Length - 1] + Rev(str.Remove(str.Length - 1));
            }
            else
            {
                string str1 = "";
                string str2 = "";
                for (int i = 0; i < magic_index; i++)
                {
                    str1 += str[i];
                }
                for(int i = magic_index + 1; i < str.Length; i++)
                {
                    str2 += str[i];
                }
                return Rev(str1) + mag + Rev(str2);
            }
        }

        public double Rev(double dig)
        {
            double frac = dig % 1;
            int whole = Convert.ToInt32(dig - dig % 1);
            Console.WriteLine(whole);

            int count = 0;
            while (frac % 1 > 0)
            {
                count++;
                frac *= 10;
            }
            Console.WriteLine(frac);
            return Rev(whole) + Convert.ToDouble(Rev(Convert.ToInt32(frac))) / Math.Pow(10, count);
        }

        public void Rev(ref int[] n)
        {
            int temp;
            for(int i = 0; i < Convert.ToInt32(n.Length / 2); i++)
            {
                temp = n[i];
                n[i] = n[n.Length - 1 - i];
                n[n.Length - 1 - i] = temp;
            }
        }

        public void Rev(int[] n, out int[] a)
        {
            a = n;
            int temp;
            for (int i = 0; i < Convert.ToInt32(a.Length / 2); i++)
            {
                temp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = temp;
            }
        }
        
        public int Min(int[] n)
        {
            int min = n[0];
            for(int i = 1; i < n.Length; i++)
            {
                if(n[i] < min)
                {
                    min = n[i];
                }
            }
            return min;
        }

        public int Max(int[] n)
        {
            int max = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > max)
                {
                    max = n[i];
                }
            }
            return max;
        }

    }
}
