using System;

namespace today
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine(now + ", " + now.Kind);

			DateTime dayForChildren = new DateTime(now.Year, 5, 5, 13, 30, 45, DateTimeKind.Utc);
			Console.WriteLine(dayForChildren + ", " + dayForChildren.Kind);
		}
	}
}
