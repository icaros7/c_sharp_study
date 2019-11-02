using System;

namespace Interface
{
    interface IObjectToString {}

    class Computer {}

    class Person : IObjectToString
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Person : " + this.name;
        }
    }

    class Program
    {
        private static void DisplayObject(object obj)
        {
            if (obj is IObjectToString)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        static void Main(string[] args)
        {
            DisplayObject(new Computer());
            DisplayObject(new Person("Homin Rhee"));
        }
    }
}
