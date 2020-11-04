using System;

namespace _4._1_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var csharp = new Book
            {
                author = "정성택",
                title = "시작하세요! C# 6.0 프로그래밍",
                iSBN = 9791158380075,
                contents = "C# 6.0 프로그래밍;",
                pageCount = 752
            };

        }
    }

    class Book
    {
        public string title;
        public decimal iSBN;
        public string contents;
        public string author;
        public int pageCount;
    }
}