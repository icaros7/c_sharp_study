using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 100000; i++)
		{
			try
			{
				int j;
				bool su = int.TryParse("5T", out j);
			}
			catch (System.FormatException e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
			
