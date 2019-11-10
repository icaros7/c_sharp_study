using System;

class Program
{
	static void Main(string[] args)
	{
		int n1 = 38;
		Console.WriteLine("n1 = {0}, 0x{1}", n1, Convert.ToString(n1, 2).PadLeft(8, '0'));

		int lSn1 = n1 << 2;
		int rSn1 = n1 >> 2;
		Console.WriteLine("n1's left shift 2\t= {0}\t, 0x{1}", lSn1, Convert.ToString(lSn1, 2).PadLeft(8, '0'));
		Console.WriteLine("n1's right shift 2\t= {0}\t, 0x{1}", rSn1, Convert.ToString(rSn1, 2).PadLeft(8, '0'));

		Console.WriteLine();		

		int n2 = -38;
		Console.WriteLine("n2 = {0}, 0x{1}", n2, Convert.ToString(n2, 2).PadLeft(8, '0'));

		int lSn2 = n2 << 2;
		int rSn2 = n2 >> 2;
		Console.WriteLine("n2's left shift 2\t= {0}\t, 0x{1}", lSn2, Convert.ToString(lSn2, 2).PadLeft(8, '0'));
		Console.WriteLine("n2's right shift 2\t= {0}\t, 0x{1}", rSn2, Convert.ToString(rSn2, 2).PadLeft(8, '0'));
	}
}
