using System;

namespace Inheritance
{
    public class Computer
    {
        protected bool powerStatus = false;
        public string name;

        public void boot()
        {
            Console.WriteLine(this.name + $" booting!");
            this.powerStatus = true;
        }

        public void shutdown()
        {
            Console.WriteLine(this.name + $" shutdown...");
            this.powerStatus = false;
        }

        public void reset()
        {
            Console.WriteLine(this.name + $" Reset!");
            this.powerStatus = true;
        }

        public string thisPowerOn()
        {
            return $"Is " + this.name + $" power On? : " + this.powerStatus;
        }

        public Computer(string _name)
        {
            name = _name;
            Console.WriteLine($"\nNew devices : " + this.name);
        }

    }

    public class Laptop : Computer // 참고로 C#은 단일 상속만 지원한다. Laptop : Computer, IT 등은 불가능.
    {
        private bool fingerScan;
        public bool hasFingerScan() { return fingerScan; }

        public Laptop(string _name, bool _scan)
            : base(_name)
        {
            fingerScan = _scan;
        }
    }

    public class Desktop : Computer
    {
        private int ac;
        public int acVolt() { return ac; }

        public Desktop(string _name, int _ac)
            : base(_name)
        {
            ac = _ac;
        }
    }

    public class AllInOne : Computer
    {
        public AllInOne(string _name)
            : base(_name)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var surface = new AllInOne("Surface");
            surface.boot();
            Console.WriteLine(surface.thisPowerOn());
            surface.shutdown();
            Console.WriteLine(surface.thisPowerOn());
            
            var macBook = new Laptop("macBook", true);
            macBook.boot();
            Console.WriteLine($"Is it has TouchID? : " + macBook.hasFingerScan());
            Console.WriteLine(macBook.thisPowerOn());
            
            var ryzen = new Desktop("Ryzen", 220);
            ryzen.boot();
            Console.WriteLine($"Ryzen desktop is " + ryzen.acVolt() + $"V");
            Console.WriteLine(ryzen.thisPowerOn());
        }
    }
}