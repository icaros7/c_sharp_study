using System;

class Program
{
	static void Main(string[] args)
	{
		Calc(0x01, 10, 5); // 더하기 수행
		Calc(0x02 | 0x04 | 0x08, 10, 50); // ㅃㅐ기, 곱하기. 나누기를 함ㄲㅔ 수행
	}

	private static void Calc(int op, int operand1, int operand2)
	{
		if ((op & 0x01) == 0x01) // 비트 1: 더하기
		{
			Console.WriteLine(operand1 + operand2);
		}

		if ((op & 0x02) == 0x02) // 비트 2: ㅃㅐ기
		{
			Console.WriteLine(operand1 - operand2);
		}

		if ((op & 0x04) == 0x04) // 비트 3: 곱하기
		{
			Console.WriteLine(operand1 * operand2);
		}

		if ((op & 0x08) == 0x08) // 비트 4: 나누기
		{
			Console.WriteLine(operand1 / operand2);
		}
	}
}
