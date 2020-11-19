using System;
using System.Collections;

namespace _4._5._1._4_Interface_IEnumerable
{
    public class Hardware
    {
    }

    public class USB
    {
        string name;

        public USB(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

    }

    class Notebook : Hardware, IEnumerable
    {
        private USB[] usbList = new USB[] {new USB("USB1"), new USB("USB2")};

        public IEnumerator GetEnumerator()
        {
            return new USBEnumerator(usbList);
        }

        public class USBEnumerator : IEnumerator // 중첩 클래스로 정의된 열거자 타입
        {
            private int pos = -1;
            private int length = 0;
            private object[] list;

            public USBEnumerator(USB[] usb)
            {
                list = usb;
                length = usb.Length;
            }

            public object Current //현재 요소를 반환
            {
                get { return list[pos]; }
            }

            public bool MoveNext()
            {
                if (pos >= length - 1)
                {
                    return false;
                }

                pos++;
                return true;
            }

            public void Reset()
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
}