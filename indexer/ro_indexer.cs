using System;

class Notebook
{
	int inch;
	int memoryGB;

	public Notebook(int display, int memory)
	{
		this.inch = display;
		this.memoryGB = memory;
	}

	public int this[string propertyNAme] // 문자열 인덱스
	{
		get
		{
			switch (propertyNAme)
			{
				case "모니터":
					return inch;

				case "메모리":
					return memoryGB;
			}
			return -1;
		}
	}
}


class Program
{
	static void Main(string[] args)
	{
		Notebook nt1 = new Notebook(13, 16);

		Console.WriteLine("화면 : " + nt1["모니터"] + "\"");
		Console.WriteLine("메모리 : " + nt1["메모리"] + "GiB");
	}
}
