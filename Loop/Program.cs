using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x < 10; x++) {
                Console.WriteLine(x + "단 시작!");
                Console.WriteLine(" ");
                for (int y = 1; y < 10; y++)
                {
                    Console.WriteLine(x + " * " + y + " = " + x * y);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
