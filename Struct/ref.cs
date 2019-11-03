using System;

namespace App
{
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
			Point pt1 = null;

			Change1(pt1); // 메서드 호출 : 얕은 복사
			Console.WriteLine("pt1 : " + pt1);

			Change2(ref pt1); // 메서드 호출 : ref 사용
			Console.WriteLine("pt1 = X : " + pt1.X + ", Y : " + pt1.Y);
		}

		private static void Change1(Point pt) // 얕은 복사
		{
			pt = new Point();

			pt.X = 77;
			pt.Y = 77;
		}

		private static void Change2(ref Point pt) // ref를 이용한 참조에 의한 호출
		{
			pt = new Point();

			pt.X = 77;
			pt.Y = 77;
		}
	}
}
