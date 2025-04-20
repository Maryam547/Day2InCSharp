// See https://aka.ms/new-console-template for more information
using System;
namespace Day2
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Enter Character Please: ");
            char x = char.Parse(Console.ReadLine());
            int y = x;
            Console.WriteLine(y);
            #endregion
            #region task2
            Console.WriteLine("Enter Number Please: ");
            int c = int.Parse(Console.ReadLine());
            char t = (char)c;
            Console.WriteLine(t);
            #endregion
            #region task3
            Console.WriteLine("Enter Number Please: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            #endregion
            #region task4
            Console.WriteLine("Enter First Number Please: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number Please: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + num1 * num2);
            #endregion
            #region task5
            Console.WriteLine("Enter Degree Please: ");
            int deg = int.Parse(Console.ReadLine());
            switch (deg / 10)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B+");
                    break;
                case 7:
                    Console.WriteLine("B");
                    break;
                case 6:
                    Console.WriteLine("C+");
                    break;
                case 5:
                    Console.WriteLine("C");
                    break;
                case 4:
                    Console.WriteLine("D+");
                    break;
                case 3:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
            #endregion

            #region Task6
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
                #endregion

            }
        }
    }
}
