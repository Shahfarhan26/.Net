using System;
namespace cal
{
    class Sw
    {
        static void Main (string[] args)
        {
            Console.Write("enter the first number:\t");
            float a = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the second number:\t");
            float b = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter the operation you want out of the folowing: (+,-,*,/,%,^)\t");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '+':
                    Console.Write($"{a} + {b} = {a + b} ");
                    break;
                case '-':
                    Console.Write($"{a} - {b} = {a - b} ");
                    break;
                case '*':
                    Console.Write($"{a} * {b} = {a * b} ");
                    break;
                case '/':
                    Console.Write($"{a} / {b} = {a / b} ");
                    break;
                case '%':
                    Console.Write($"{a} % {b} = {a % b} ");
                    break;
                case '^':
                    Console.Write($"{a} ^ {b} = {Math.Pow(a,b)} ");
                    break;
                default:
                    Console.Write("wrong choice");
                    break;
            }
        }
    }
}
