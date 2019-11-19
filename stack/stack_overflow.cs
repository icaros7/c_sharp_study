using System;

class Program
{
	static void Main(string[] args)
	{
		Recursive(1);
	}

	private static void Recursive(long n)
	{
		long i = 5, j = 6, k = 7, m = 8, nn = 9;
		Console.WriteLine(n);
		Recursive(n + 1);
	}
}
