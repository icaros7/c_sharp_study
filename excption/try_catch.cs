using System;

class Program
{
	static void Main(string[] args)
	{
		int div = 0;

		try
		{
			int quo = 10 / div;
		}
		catch (System.DivideByZeroException)
		{
			Console.WriteLine("잡앗다 요거 요놈요놈");
		}
	}
}
