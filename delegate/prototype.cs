using System;

class MyClass
{
	// RunDelegate라는 피라미터가 int 하나, 리턴 void
	private delegate void RunDelegate(int t);

	private void RunThis(int val)
	{
		// output : 1024
		Console.WriteLine("{0}", val);
	}

	private void RunThat(int value)
	{
		// output : 0x400
		Console.WriteLine("0x{0:x}", value);
	}

	public void Perform()
	{
		// delegate 인스턴스 생성
		RunDelegate run = new RunDelegate(RunThis); // Point
		run(1024);

		// Point를 줄여서 아래와 같이 사용 가능
		run = RunThat;
		run(1024);
	}
}

class Program
{
	static void Main(string[] args)
	{
		MyClass mc = new MyClass();
		mc.Perform();
	}
}
