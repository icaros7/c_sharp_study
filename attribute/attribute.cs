using System;

namespace attribute_cs
{
	class AuthorAttribute : System.Attribute
	{

		string name;
		int version;
		public AuthorAttribute(string name, int version)
		{
			this.name = name;
			this.version = version;
		}
	}

	[Author("Homin Rhee", 1)]
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Halo World!");
		}
	}
}
