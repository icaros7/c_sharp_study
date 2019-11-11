using System;

class Program
{
	static void Main(string[] args)
	{
		int i;

		unsafe
		{
			Add(&i, 5, 10, 15);
		}

		Console.WriteLine(i);

		GC.Collect();
		Console.WriteLine("GC Done!");

		unsafe
		{
			Add(&i, 10);
		}

		Console.WriteLine(i);
	}

	unsafe static void Add(int *p, params int[] value)
	{
		fixed (int* result = p)
		{
			for (int i = 0; i < value.Length; i++)
			{
				*p += value[i];
			}
		}
	}
}
