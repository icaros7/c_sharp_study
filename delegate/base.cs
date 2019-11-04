using System;

class Program
{
	static void Main(string[] args)
	{
		new Program().Test();
	}

	// 델리게이트 정의
	delegate int MyDelegate(string s);

	void Test()
	{
		// 델리게이트 객체 생성
		MyDelegate m = new MyDelegate(StringToInt);

		// 델리게이트 객체를 메서드로 전달
		Run(m);
	}

	int StringToInt(string s)
	{
		return int.Parse(s);
	}

	// 델리게이트를 전달 받는 메서드
	void Run(MyDelegate m)
	{
		// 델리게이트로부터 메서드 실행
		int i = m("123");

		Console.WriteLine(i);
	}
}
