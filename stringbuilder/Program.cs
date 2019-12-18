using System;
using System.Diagnostics;
using System.Text;

namespace _StringBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch st = new Stopwatch();
			Console.WriteLine("Try \"txt + \"1\"\" 300000 times");

			string txt = "Hello World!";
			st.Start();
			for (int i = 0; i < 300000; i++)
			{
				txt += "1";
			}
			st.Stop();
			Console.WriteLine("\n1st Try Done!\n1st Try Took {0}ms", st.ElapsedTicks / 1000);

			Console.WriteLine("\n\nPreparing 2nd Try!");
			st.Reset();
			txt = "Hello World!";
			StringBuilder sb = new StringBuilder();
			sb.Append(txt);

			Console.WriteLine("Try \"StringBuilder.Append(\"1\")");
			st.Start();
			for (int i = 0; i < 300000; i++)
			{
				sb.Append("1");
			}
			st.Stop();
			Console.WriteLine("\n2nd Try Done!\n2nd Try Took {0}ms", st.ElapsedTicks / 1000);
		}
	}
}
