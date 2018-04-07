using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallRef
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1_in = Console.ReadLine();
            int num1;
            Int32.TryParse(num1_in, out num1);
            string num2_in = Console.ReadLine();
            int num2;
            Int32.TryParse(num2_in, out num2);

            Swap(ref num1,ref num2);
            Console.Write("\n\n");
            Console.WriteLine("num 1 : {0}\nnum 2 : {1}", num1, num2);
        }

        static void Swap(ref int a,ref int b)
        {
            if (a == b)
            {
                Console.Write("두개의 값이 {0}으로 같습니다!!\n", a);
            }
            else
            {
                int temp = b;
                b = a;
                a = temp;
            }
        }

    }
}
