using System;

namespace _4._1._2_Method2
{
    class Math
    {
        public int GetAera(int x)
        {
            return x * x;
        }

        public int GetValue()
        {
            return 10;
        }

        public void Output(string precon, int value)
        {
            Console.WriteLine(precon + value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var m = new Math();
            int result = m.GetAera(m.GetAera(m.GetValue()));
            
            m.Output("결과 : ", result);
        }
    }
}