using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc m = new Calc();
            int Result = m.getValue(m.getNum());
            m.printf("결과 값 : ", Result);
        }
    }
    class Calc
    {
        public int getValue(int x)
        {
            return x * x;
        }
        public int getNum()
        {
            return 10;
        }
        public void printf(string Sentense, int value)
        {
            Console.WriteLine(Sentense + value);
        }
    }
}
