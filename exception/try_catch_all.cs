using System;

class Program
{
	static void Main(string[] args)
	{
		int di = 0;
		string txt = null;

		Console.WriteLine("This program will working 2 case\n");

		try
		{
			Console.WriteLine("Try number 1:");
			int number = 10 / di;
			Console.WriteLine("End of number 1\n");

			Console.WriteLine("Ttu number 2:");
			Console.WriteLine(txt);
			Console.WriteLine("End of number 2\n");
		}
		catch (System.NullReferenceException e)
		{
			Console.WriteLine(e.StackTrace);
		}
		catch (System.DivideByZeroException e)
		{
			Console.WriteLine(e.StackTrace);
		}
		catch (System.Exception e)
		{
			Console.WriteLine("By Exception: " + e.Message);
		}
		finally
		{
			Console.WriteLine("End of Program");
		}
	}
}
