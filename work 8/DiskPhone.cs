using System;
using System.Collections.Generic;
using System.Text;

namespace work_8
{
    class DiskPhone
    {
        protected bool _call = false;

        protected string _number = "";

        protected string number;
        public string Number
        {
            set
            {
                if (Int32.TryParse(value, out _))
                {
                    this.number = value;
                }
                else
                {
                    this.number = "Number incorrect, try again";
                }
            }
            get
            {
                return this.number;
            }
        }

        protected List<char> symbols;

        public List<char> Symbols()
        {
            return this.symbols;
        }

        public void ShowSymbols()
        {
            for (int i = 0; i < this.symbols.Count; i++)
            {
                Console.Write(Convert.ToString(this.symbols[i]) + ' ');
            }
            Console.WriteLine();
        }

        public DiskPhone(string number)
        {
            this.Number = number;
            symbols = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        }

        public virtual void CallTo(string number)
        {
            if(number == this.Number)
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

        public void CallFrom()
        {
            if (!this._call)
            {
                this._call = true;
                Console.WriteLine("Someone calling you");
            }
            else
            {
                Console.WriteLine("Now you talking");
            }
        }

        public void DropCall()
        {
            if (this._call)
            {
                this._call = false;
                this._number = "";
                Console.WriteLine("You drop phone");
            }
            else
            {
                Console.WriteLine("You talk on now");
            }
        }

    }
}
