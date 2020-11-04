/*
 * 다향성 중 메서드 오버라이드에 관하여...
 *
 * 이는 암시적 형 변환시 유용하게 쓰일 수 있다.
 * 부모 클래스에서 virtual 예약어를 통해 오버라이드 원하는 메서드를 미리 명시 하여 사용한다.
*/
using System;

namespace Poly
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine($"이동하였다!");
        }        
    }

    class Lion : Mammal
    {
        override public void Move()
        {
            Console.WriteLine($"네 발로 이동한다.");
        }
    }

    class Whale : Mammal
    {
        override public void Move()
        {
            Console.WriteLine($"수영하여 이동한다.");
        }
    }

    class Human : Mammal
    {
        override public void Move()
        {
            Console.WriteLine($"두 발로 이동한다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.Move();
            Mammal one = lion; // 부모 타입으로 형 변환
            one.Move();
            
            Human human = new Human();
            human.Move();
            Mammal two = human;
            two.Move();
            
            Mammal three = new Mammal();
            three.Move();
        }
    }
}