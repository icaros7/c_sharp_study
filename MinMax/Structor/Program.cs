using System;

namespace Structor
{
    class MainClass
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int X, int Y)
            {
                this.x = X;
                this.y = Y;
            }
            public override string ToString()
            {
                return string.Format("{0}, {1}", x, y);
            }
        }

        public static void Main(string[] args)
        {
            Point pt = new Point(10, 2);
            Console.WriteLine(pt.ToString());
        }
    }
}
