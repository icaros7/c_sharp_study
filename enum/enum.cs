using System;

namespace enum_cs
{
	class Program
	{
		enum City
		{
			Seoul, // 0
			Daejun, // 1
			Busan = 5, // 5
			Incheon = 10 // 10
		}

		static void Main(string[] args)
		{
			City myCity;

			// enum 타입에 값을 대입
			myCity = City.Seoul;

			// enum을 int로 변환(Casting)하는 방법
			int cityValue = (int) myCity;

			if (myCity == City.Seoul) Console.WriteLine("Hello, Seoul!");
			else Console.WriteLine("Do you have a plan, going to Seoul?");
		}
	}
}
