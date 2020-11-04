using System;

namespace _4._1._3_Constructor
{
    class Person
    {
        private string _name;
        private int _age;
        private string _last_name;

        public Person(string name, string lastName, int age)
        {
            _name = name;
            _last_name = lastName;
            _age = age;
            Console.WriteLine($"Welecom, " + name + $"!");
        }

        public void WhoIam() { Console.WriteLine($"My name is " + _last_name + $" " + _name + $" and I am " + _age + $" years old."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("호민", "이", 23);
            person.WhoIam();
        }
    }
}