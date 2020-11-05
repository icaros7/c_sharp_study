using System;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.CompilerServices;

public class Math
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y) // 이 부분을 통해 알 수 있는것은 메서드의 반환값으로 메서드 사용 가능. 메서드의 인자로 메서드 전달 가능.
    {
        return x + y;
    }

    static int Sub(int x, int y)
    {
        return x - y;
    }

    static int Multi(int x, int y)
    {
        return x * y;
    }

    static int Div(int x, int y)
    {
        return x / y;
    }

    private CalcDelegate[] methods;

    public Math()
    {
        // static 메서드를 가르키는 델리게이드 배열 초기화
        methods = new CalcDelegate[] {Math.Add, Math.Sub, Math.Multi, Math.Div};
    }

    // methods 배열에 담긴 델리게이트를 opCode에 따라 호출
    public void Calc(char opCode, int op1, int op2)
    {
        switch (opCode)
        {
            case '+':
                Console.WriteLine(op1 + $" + " + op2 + $" = " + methods[0](op1, op2));
                break;

            case '-':
                Console.WriteLine(op1 + $" - " + op2 + $" = " + methods[1](op1, op2));
                break;
            case '*':
            case 'x':
                Console.WriteLine(op1 + $" * " + op2 + $" = " + methods[2](op1, op2));
                break;
            case '/':
                Console.WriteLine(op1 + $" / " + op2 + $" = " + methods[3](op1, op2));
                break;
        }
    }
}

namespace _4._5._1._3_Delegate
{
    public class Program
    {
        //3개의 매개변수를 받고 void 를 반환하는 델리게이트 정의
        delegate void WorkDelegate(char arg1, int arg2, int arg3);
        
        public static void Main(string[] args)
        {
            Math math = new Math();
            WorkDelegate work = math.Calc;

            work('+', 10, 5);
            work('-', 10, 5);
            work('*', 10, 5);
            work('x', 10, 5);
            work('/', 10, 5);
        }
    }
}