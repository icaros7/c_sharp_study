using System;

namespace swapref
{
	class Program
	{
		static void Main(string[] args)
		{
			int v1 = 5;
			int v2 = 10;

			Console.WriteLine("Before Swap. v1 = " + v1 + ", v2 = " + v2);

			SwapValue1(ref v1, ref v2); // via ref

			Console.WriteLine("After Swap. v1 = " + v1 + ", v2 = " + v2);

			Console.WriteLine("End of ref\n\nAfter this point, it's value");

			v1 = 5;
			v2 = 10;
			SwapValue2(v1, v2); // via value

			Console.WriteLine("Before Swap. v1 = " + v1 + ", v2 = " + v2);

			SwapValue2(v1, v2); // via value

			Console.WriteLine("After Swap. v1 = " + v1 + ", v2 = " + v2);

		}

		private static void SwapValue1(ref int v1, ref int v2) // via ref
		{
			int temp = v1;
			v1 = v2;
			v2 = temp;
		}

		private static void SwapValue2(int v1, int v2) // via value
		{
			int temp = v1;
			v1 = v2;
			v2 = temp;
		}
	}
}
