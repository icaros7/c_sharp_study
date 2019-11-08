using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			string txt = Console.ReadLine();

			#if Homin_Rhee
			if (string.IsNullOrEmpty(txt) != true) Console.WriteLine("Homnin Rhee : {0}", txt);

			#elif Yijun_Park
			Console.WriteLine("Yijun Park : {0}~", txt);

			#else
			Console.WriteLine("WHO ARE U :(");

			#endif
		}
	}
}
