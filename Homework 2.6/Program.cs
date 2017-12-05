using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Hey you! Enter a first operand below:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Great job! Now enter a second operand:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Amazing! Now tell me — what kind of operation would you like to perform with these operands? (+, -, *, /, %)");
            char c = char.Parse(Console.ReadLine());
            
            switch (c)
            {
                case '+':
                    Console.WriteLine("Summing, huh? Here's your answer:");
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine("EXTRAction! Here's your answer:");
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine("Multiplicate those numbers! Here's your answer:");
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    Console.WriteLine("Divide and rule! Here's your answer:");
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                case '%':
                    Console.WriteLine("Weird choice... But here's your answer:");
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("No, no, no... Use +, -, *, / or % next time");
                    break;
            }

            //Console.WriteLine("Wow! Here's your answer:");

            //if (c == '+')
            //{
            //    Console.WriteLine($"{a} + {b} = {a + b}");
            //}
            //else if (c == '-')
            //{
            //    Console.WriteLine($"{a} - {b} = {a - b}");
            //}
            //else if (c == '*')
            //{
            //    Console.WriteLine($"{a} * {b} = {a * b}");
            //}
            //else if (c == '/')
            //{
            //    Console.WriteLine($"{a} / {b} = {a / b}");
            //}
            //else if (c == '%')
            //{
            //    Console.WriteLine($"{a} % {b} = {a % b}");
            //}
            //else
            //{
            //    Console.WriteLine("No, no, no... Use +, -, *, / or %");
            //}

        }
    }
}
