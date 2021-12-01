using System;
using System.Collections.Generic;
using System.Text;

namespace work_8
{
    class HousePhone : DiskPhone
    {
        public HousePhone(string number)
            : base(number)
        {
            symbols.AddRange(new char[] { '*', '#' });
        }

        public void CallFrom(string number)
        {
            if (!this._call)
            {
                this._call = true;
                Console.WriteLine(number + " calling you");
                this._number = number;
            }
            else
            {
                Console.WriteLine("Now you talking with " + this._number + ", but " + number + " calling you");
            }
        }
    }
}
