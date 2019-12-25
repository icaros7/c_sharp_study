using System;

namespace _BitConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			byte[] boolBytes = BitConverter.GetBytes(true);
			byte[] shortBytes = BitConverter.GetBytes((short)32000);
			byte[] intBytes = BitConverter.GetBytes(1652300);

			Console.WriteLine(BitConverter.ToString(boolBytes));
			Console.WriteLine(BitConverter.ToString(shortBytes));
			Console.WriteLine(BitConverter.ToString(intBytes));

			int n = 1652300;
			string text = n.ToString();
			int result = int.Parse(text);
			Console.WriteLine(text + "\n" + result);
		}
	}
}
