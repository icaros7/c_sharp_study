using System;

class Program
{
	static void Main(string[] args)
	{
		HasNoProblem();
		HasProblem();
	}

	private static void HasNoProblem()
	{
		WriteText("Argument is not NULL!!!");
	}

	private static void HasProblem()
	{
		WriteText(null);
	}

	private static void WriteText(string text)
	{
		Console.WriteLine(text.ToLower());
	}
}
