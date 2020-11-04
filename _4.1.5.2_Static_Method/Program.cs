/*
 * 정적 메서드의 경우 내부에서 인스턴스 객체엔 접근 할 수 없다.
 * 대신 new로 할당된 다른 객체 없이도 단독 사용이 가능 하단 점이 다르다.
 */

using System;

namespace _4._1._5._2_Static_Method
{
    class Person 
    {
        private static int TotalInstance;
        private string _name;
        
        public Person(string name)
        {
            TotalInstance++;
            _name = name;
        }

        static public void Output()
        {
            Console.WriteLine(TotalInstance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person.Output();
            var p = new Person("호민");
            Person.Output();
        }
    }
}