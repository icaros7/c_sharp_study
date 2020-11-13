/*
 * 클래스는 다중 상속이 불가능 하다. 따라서 추상 클래스를 사용 할 경우 클래스에 여러가지 추상 클래스를 상속 하여 줄수 없다.
 * 하지만 Interface는 가능하여 아래와 같은 코드도 사용이 가능하다.
 */

using System;

namespace _4._5._1._4_Interface
{
    public class Computer
    {
        
    }

    interface IMonitor // 메서드 시그니처만 포함 하고 있는 인터페이스
    {
        void TurnOn();
    }
    
    interface IKeyboard { } // 비어 있는 인터페이스 정의 가능

    public class Notebook : Computer, IMonitor, IKeyboard
    {
        public void TurnOn()
        { 
            Console.WriteLine("Turn On!"); // 추상 메서드와 달리 override 예약어가 필요 없음
        }
        public Notebook() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.TurnOn();
        }
    }
}