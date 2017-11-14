using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.homin.Output();
            //Person Yijun = new Person("Yijun Park"); 컴파일 에러! Person 메서드는 Private 수준으로 보호되기에, 클래스 내부에서 선 생성 아니면 불가능.
        }
    }

    class Person
    {
        static public new Person homin = new Person("Homin Rhee"); //유일하게 가능.

        public string name;

        private Person(string inname)
        {
            name = inname;
        }

        public void Output()
        {
            Console.WriteLine("위대한 그분의 성함은 " + name + "님 입니다.");
        }
    }
}
