using System;

namespace Span
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime endOfYear = new DateTime(DateTime.UtcNow.Year, 12, 31, 23, 59, 59, DateTimeKind.Utc);
			DateTime now = DateTime.UtcNow;

			Console.WriteLine("오늘: {0}", now);

			TimeSpan gap = endOfYear - now;
			Console.WriteLine("올해 남은 시간: {0}시간", gap.TotalHours);
		}
	}
}
