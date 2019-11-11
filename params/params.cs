using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(Add(1,2,3,4,5,6));
		Console.WriteLine(Add(1,2,3,4,5,6,7,8,9,10,11));
	}

	static int Add(params int[] value) // 배열로 받되, 입력타입이 한정되지 않는 다면 모든 타입의 부모 object 사용
	{
		int result = 0;

		for (int i = 0; i < value.Length; i++)
		{
			result += value[i];
		}

		return result;
	}
}
