using System;

namespace App
{
	struct Vector
	{
		public int X;
		public int Y;

		public Vector(int x, int y) // 매개변수를 가진 생성자
		{
			this.X = x;
			this.Y = y; //구조체가 가진 필드 초기화
		}

		public override string ToString() // System.Object의 ToString을 재정의
		{
			return "X : "+ X + ", Y : " + Y;
		}
	}

	class Point
	{
		public int X;
		public int Y;

		public Point()
		{
			X = 0;
			Y = 0;
		}

		public Point(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}
		public override string ToString()
		{
			return "X : " + X + ", Y : " + Y;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Vector v1 = new Vector(); // new를 사용해서 인스턴스 생성 가능
			Vector v2; // new 없이도 가능.

			Vector v3 = new Vector(5, 10); // 명시적으로 생성자 지정 가능...

			Console.WriteLine(v3);

			Vector v4;
			v4.X = 5;
			v4.Y = 6;
			Vector v5 = v4; // 값 형식의 대입
			Console.WriteLine("Change v4 to 12,24. Original is 5,6");
			v4.X = 12;
			v4.Y = 24;

			Point pt1 = new Point();
			pt1.X = 6;
			pt1.Y = 12;

			Point pt2 = pt1;
			Console.WriteLine("Change pt1 24,48. Original is 6,12");
			pt1.X = 24;
			pt1.Y = 48;

			Console.WriteLine("v4 = " + v4);
			Console.WriteLine("v5 = " + v5);
			Console.WriteLine("pt1 = " + pt1);
			Console.WriteLine("pt2 = " + pt2);
		}
	}
}
