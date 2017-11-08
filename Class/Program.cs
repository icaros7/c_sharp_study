using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Book
    {
        public string title;
        public decimal ISBN13;
        public string contents;
        public string writer;
        public int lastpage;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book Homin = new Book();
            Homin.title = "호민의 이야기";
            Homin.ISBN13 = 1234567890112;
            Homin.contents = "호민 인생사 이야기";
            Homin.writer = "이호민";
            Homin.lastpage = 1;
            
            string title = Homin.title;
            decimal ISBN13 = Homin.ISBN13;
            string contents = Homin.contents;
            string writer = Homin.writer;
            int last = Homin.lastpage;

            Action<string> cw = Console.WriteLine;
            cw("책 이름\t\t\t : " + title);
            cw("책 ISBN 13자리\t\t : " + ISBN13);
            cw("책 내용 요약\t\t : " + contents);
            cw("책 저자\t\t\t : " + writer);
            cw("마지막으로 본 페이지\t : " + last);
        }
    }
}
