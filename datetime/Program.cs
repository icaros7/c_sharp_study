using System;

namespace Timer
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime before = DateTime.Now;
			Sum();
			DateTime after = DateTime.Now;

			long gap = after.Ticks - before.Ticks;
			Console.WriteLine("Total Ticks: {0}", gap);
			Console.WriteLine("Millisecond: {0}", gap / 10000);
			Console.WriteLine("Second: {0}", gap / 10000 / 1000);
		}

		private static long Sum()
		{
			long sum = 0;

			for (int i = 0; i < 10000000; i++)
			{
				sum += i;
			}

			return sum;
		}
	}
}
