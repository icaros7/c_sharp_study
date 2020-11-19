﻿using System;
using System.Collections;

namespace _4._5._1._4_Interface_IComparer
{
    class IntegerCompare : IComparer // IComparer를 상속받는 타입 정의
    {
        /*
         * IComparer 인터페이스의 Compare 메서드를 구현.
         * 이 메서드는 Array.Sort 메서드 내에서 콜백으로 호출
         */
        public int Compare(object x, object y)
        {
            int xValue = (int) x;
            int yValue = (int) y;

            if (xValue > yValue) return -1; //내림차순 정렬이 되도록 -1 반환
            else if (xValue == yValue) return 0;

            return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {1, 2, 3, 4, 5};
            
            // IComparer를 상속받은 IntegerComapre 인스턴스 전달
            Array.Sort(intArray, new IntegerCompare());
            foreach (int item in intArray)
            {
                Console.Write(item + ", ");
            }
        }
    }
}