using System;

namespace _4._5._1._3_Callback_Method
{
    public delegate bool CompareDelegate(int args1, int args2);
    class SortObject // 배열 정렬
    {
        private int[] numbers;

        public SortObject(int[] numbers)
        {
            this.numbers = numbers; // 배열을 생성자 매개변수를 통해 받아 저장
        }

        public void Sort(CompareDelegate compareMethod)
        {
            int temp; // 임시 저장소

            for (int i = 0; i < numbers.Length; i++) // 배열의 old 순서대로 각 차례를 현 가장 작은 값과 비교
            {
                int Pos = i;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (compareMethod(numbers[j], numbers[Pos]))
                    {
                        Pos = j;
                    }
                }

                temp = numbers[Pos]; // 다음 서로 위치를 교체
                numbers[Pos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + $" ");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] Arr = new int[] {10, 5, 0, 1, 4, 6, 5, 3, 19, 2};
            
            SortObject so = new SortObject(Arr);
            so.Sort(Up);
            so.Display();
            
            Console.WriteLine();
            
            so.Sort(Down);
            so.Display();
        }

        public static bool Up(int args1, int args2)
        {
            return (args1 < args2);
        }

        public static bool Down(int args1, int args2)
        {
            return (args1 > args2);
        }
    }
}