using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_args
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("암것도 없는데염??");
            }
            else
            {
                Console.WriteLine(args[0]);
            }
        }
    }
}
