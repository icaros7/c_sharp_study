/*
 * 연산자 오버로드를 통해 + 연산자가 수행하는 행동을 재정의 할 수 있다.
 */

using System;

namespace _4._4._2._Operator_Overload
{
    class Kilo
    {
        private double mass;

        public Kilo(double mass)
        {
            this.mass = mass;
        }

        public override string ToString()
        {
            return this.mass + $"kg";
        }

        public static Kilo operator +(Kilo op1, Kilo op2)
        {
            return new Kilo(op1.mass + op2.mass);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Kilo kg1 = new Kilo(5.57);
            Kilo kg2 = new Kilo(10.99);

            Kilo kg3 = kg1 + kg2;
            Console.WriteLine(kg3.ToString());
        }
    }
}