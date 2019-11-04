using System;

namespace flag_cs
{
	class Program
	{
		[Flags]
		enum Border
		{
			None = 0, Top = 1, Right = 2, Bottom = 4, Left = 8
		}

		static void Main(string[] args)
		{
			// OR 연산자로 다중 플래그 할당
			Border b = Border.Top | Border.Bottom;

			// AND 연산자로 플래그 체크
			if ((b & Border.Top) != 0) // 만약 b에 Top 멤버가 잇다면
			{
				// HasFlag()이용하여 플래그 체크
				if (b.HasFlag(Border.Bottom))
				{
					// Top,Bottom 출력
					Console.WriteLine(b.ToString());
				}
			}
		}
	}
}
