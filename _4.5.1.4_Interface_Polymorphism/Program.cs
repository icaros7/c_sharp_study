using System;

namespace _4._5._1._4_interface_polymorphism
{
    public interface IDrawingObject
    {
        void draw();
    }

    public class line : IDrawingObject
    {
        public void draw()
        {
            Console.WriteLine("line");
        }
    }

    public class rectangle : IDrawingObject
    {
        public void draw()
        {
            Console.WriteLine("rectangle");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // 인터페이스 자체는 new로 인스턴스화 할수 없음. but 인터페이스 배열은 가능함
            IDrawingObject[] instances = new IDrawingObject[] {new line(), new rectangle() };

            foreach (IDrawingObject item in instances)
            {
                item.draw(); // 인터페이스를 상속받은 개체의 Draw 메서드가 호출
            }
            
            // 자식 클래스로부터 암시적 형변환 가능
            IDrawingObject instance = new line();
            instance.draw();
        }
    }
}