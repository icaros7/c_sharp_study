using System;
using System.IO;

namespace _stream
{
	class Program
	{
		static void Main(string[] args)
		{
			MemoryStream ms = new MemoryStream();

			StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
			sw.WriteLine("Hello world!");
			sw.WriteLine("Homin Rhee");
			sw.Write(32000);
			sw.Flush();

			//잊지않고 Pos값 초기화
			ms.Position = 0;

			StreamReader sr = new StreamReader(ms, Encoding.UTF8);
			string txt = sr.ReadToEnd();
			Console.WriteLine(txt);
		
		}
	}
}
