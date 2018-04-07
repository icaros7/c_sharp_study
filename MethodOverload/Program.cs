using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathmatics homin = new Mathmatics();
            Console.WriteLine(homin.Abs(-10));
            Console.WriteLine(homin.Abs(-10.2234));
            Console.WriteLine(homin.Abs(-50.51m));
        }
    }

    class Mathmatics
    {
        public int Abs(int value) { return (value >= 0) ? value : -value; }
        public double Abs (double value) { return (value >= 0) ? value : -value; }
        public decimal Abs (decimal value) { return (value >= 0) ? value : -value; }
    }
}
