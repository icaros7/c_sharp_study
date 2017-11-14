using Homin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_static_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Homin = new Person("Homin Rhee");
            Console.Write("========================\n");
            Person YiJun = new Person("Yijun Park");
        }
    }
}

namespace Homin
{
    class Person
    {
        string name;

        public Person(string inname)
        {
            name = inname;
            Console.Write("아마 이것은 두번째로 실행될 것 입니다. " + name + "\n");
        }

        static Person()
        {
            Console.Write("아마 이 정적 생성자는 처음만 실행될 것 입니다.\n");
        }
    }
}
