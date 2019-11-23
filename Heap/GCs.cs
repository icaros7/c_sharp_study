using System;

namespace GCs
{
	class Program
	{
		static void Main(string[] args)
		{
			Program pg = new Program();
			Console.WriteLine(GC.GetGeneration(pg));
		}
	}
}
