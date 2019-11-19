using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i < 100000; i++)
		{
			try
			{
				int j = Int32.Parse("202T");
			}
			catch (System.FormatException)
			{
			}
		}
	}
}
			
