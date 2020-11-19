using System;

namespace _4._5._1._4_Loosing_Coupling
{
    interface IPower
    {
        void TurnOn();
    }

    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor : Turn On!");
        }
    }

    class Computer : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer : Turn On!");
        }
    }

    class Switch
    {
        public void PowerOn(IPower machine)
        {
            machine.TurnOn();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Monitor monitor = new Monitor();
            Computer computer = new Computer();
            Switch sw1 = new Switch();
            sw1.PowerOn(computer);
            sw1.PowerOn(monitor);
        }
    }
}