using System;
using System.Runtime.InteropServices;

class Program
{
	[DllImport("User32.dll")]
	static extern int MessageBeep(uint uType);

	static int TestMethod(uint type) // 비교를 위한 정적 메서드
	{
		return 0;
	}

	static void Main(string[] args)
	{
		MessageBeep(0);
	}
}
