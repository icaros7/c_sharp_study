using System;
using System.IO;

namespace GC_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
		FileCreate();

		Console.WriteLine("Success to open File");
		Console.ReadLine();
        }

	private static void FileCreate()
	{
		FileStream fs = new FileStream("output.log", FileMode.Create);
		fs.Close();
	}
    }
}
