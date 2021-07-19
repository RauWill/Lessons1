using System;
namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum;
            double result;

            Console.WriteLine("Введите первое число");
            firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            secondNum = double.Parse(Console.ReadLine());

            result = (firstNum + secondNum) / 2;

            Console.WriteLine("Среднее арифметическое число: " + result);
        }
    }
}
