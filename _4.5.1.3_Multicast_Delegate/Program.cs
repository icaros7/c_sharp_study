using System;

namespace _4._5._1._3_Multicast_Delegate
{
    public class Program
    {
        delegate void CalcDelegate(int x, int y);
            
        static void Add(int x, int y){ Console.WriteLine(x + $" + " + y + $" = " + (x + y));}
        static void Sub(int x, int y){ Console.WriteLine(x + $" - " + y + $" = " + (x - y));}
        static void Multi(int x, int y){ Console.WriteLine(x + $" * " + y + $" = " + (x * y));}
        static void Div(int x, int y){ Console.WriteLine(x + $" / " + y + $" = " + (x / y));}
        
        public static void Main(string[] args)
        {
            CalcDelegate calc = Add;

            calc += Sub; // += 연산자를 이용해 메서드를 델리게이트 인스턴스에 추가
            calc += Multi;
            calc += Div;

            calc(10, 5);
            
            Console.WriteLine("\n\n");
            calc -= Div; // -= 연산자를 이용해 델리게이트 인스턴스에서 Div만 제거

            calc(10, 5);
            
            Console.WriteLine("\n\n");
            calc += Multi;

            calc(10, 5);
            
            Console.WriteLine("\n\n");
            calc -= Sub;

            calc(10, 5);
        }
    }
}