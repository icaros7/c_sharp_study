using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("생성자 호출 전");
            Person person = new Person();
            Console.WriteLine("생성자 호출 후");
        }
    }
    class Person
    {
        string name;

        public Person()
        {
            name = "Homin Rhee";
            Console.WriteLine("생성자 호출 완료");
        }
    }
}
