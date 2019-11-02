// IEnumberable의 약속된 작업만 보장해준다면 내가 만든 객체를 동일하게 다룰수 잇음.

using System;
using System.Collections;

class Hardware { }

class USB
{
	string name;
	public USB(string name) { this.name = name; }
	public override string ToString() { return name; }
}

class Notebook : Hardware, IEnumerable // IEnumerable 인터페이스 구현
{
	USB[] usbList = new USB[] { new USB("Homin's USB"), new USB("Yijun's USB") };

	public IEnumerator GetEnumerator()
	{
		return new USBEnumerator(usbList);
	}

	public class USBEnumerator : IEnumerator // 중첩 클래스로 정의된 열거자 타입
	{
		int pos = -1;
		int length = 0;
		object[] list;

		public USBEnumerator(USB[] usb)
		{
			list = usb;
			length = usb.Length;
		}

		public object Current // 현재 요소를 반환하도록 약속된 접근자 메서드
		{
			get { return list[pos]; }
		}

		public bool MoveNext() // 다음 순서의 요소를 지정하도록 약속된 메서드
		{
			if (pos >= length - 1) return false;

			pos++;
			return true;
		}

		public void Reset() // 처음부터 열거하고 싶을 ㄸㅐ 호출하면 되는 메서드
		{
			pos = -1;
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		Notebook notebook = new Notebook();
		foreach (USB usb in notebook)
		{
			Console.WriteLine(usb);
		}
	}
}

