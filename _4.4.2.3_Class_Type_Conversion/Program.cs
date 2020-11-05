/*
 * 클래스 간의 형 변환시 unit 등을 나타내는 프로그램에서 유용
 * 가령 통화를 나타낼 경우 Dollar = Won; 이라는 코드를 사용할 경우 암시적으로 Dollar의 경우 Won에게
 * 1125를 나눈다. 라는 단순한 암시적 연산을 통해 이루어질 경우 추후 버그를 가져올 가능성이 농후하다.
 *
 * 이는 클래스 형변환을 통해 해결이 가능하다.
*/

using System;

namespace _4._4._2._3._Class_Type_Conversion
{
    public class Currency
    {
        private decimal money;
        public decimal Money => money;

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money)
            : base(money)
        {
            
        }

        public override string ToString()
        {
            return Money + $"won";
        }

        static public implicit operator Dollar(Won won)
        {
            return new Dollar(won.Money / 1125); // 클래스 암시적 형변환. 환율을 1달러 = 1125원 가정
        }

        static public implicit operator Yen(Won won)
        {
            return new Yen(won.Money / 10); // 클래스 암시적 형변환. 환율을 1엔 = 10원 가정
        }
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money)
            : base(money)
        {
            
        }

        public override string ToString()
        {
            return Money + $"dollar";
        }

        static public explicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1125); // 클래스 의도적 형변환.
        }

        static public explicit operator Yen(Dollar dollar)
        {
            return new Yen(dollar.Money * 104);
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money)
            : base(money)
        {
            
        }

        public override string ToString()
        {
            return Money + $"Yen";
        }

        static public explicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 10);
        }

        static public explicit operator Dollar(Yen yen)
        {
            return new Dollar(yen.Money / 104);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1);

            // Won won1 = dollar; // 암시적 형변환 오류 발생
            Won won2 = (Won) dollar;
            
            Console.WriteLine($"1 Dollar = " + won2);
            
            Yen yen = new Yen(13);
            Won won1 = (Won)yen;
            
            Console.WriteLine($"13 Yen = " + won1);
        }
    }
}