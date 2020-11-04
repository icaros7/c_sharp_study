using System;

namespace Math
{
class Math
{
    public int f(int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main(string[] Args)
    {
        var m = new Math();
        int result = m.f(5);
        Console.WriteLine($"5^2 = " + result);
    }
}
}