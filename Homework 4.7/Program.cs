using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Введите марку первой машины");
            string car1name = Console.ReadLine();
            Console.WriteLine($"Введите максимальную скорость машины {car1name}");
            int car1speed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите расход топлива (л/100км) машины {car1name}");
            int car1fuel = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Введите марку второй машины");
            string car2name = Console.ReadLine();
            Console.WriteLine($"Введите максимальную скорость машины {car2name}");
            int car2speed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите расход топлива (л/100км) машины {car2name}");
            int car2fuel = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Введите марку второй машины");
            string car3name = Console.ReadLine();
            Console.WriteLine($"Введите максимальную скорость машины {car3name}");
            int car3speed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите расход топлива (л/100км) машины {car3name}");
            int car3fuel = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Топ по скорости:");

            if (car1speed > car2speed && car2speed > car3speed)
                Console.WriteLine($"1.{car1name}({car1speed})\n2.{car2name}({car2speed})\n3.{car3name}({car3speed}) ");
            else if (car1speed < car2speed && car1speed > car3speed)
                Console.WriteLine($"1.{car2name}({car2speed})\n2.{car1name}({car1speed})\n3.{car3name}({car3speed}) ");
            else if (car1speed < car2speed && car2speed < car3speed)
                Console.WriteLine($"1.{car3name}({car3speed})\n2.{car2name}({car2speed})\n3.{car1name}({car1speed}) ");
            else if (car1speed > car2speed && car1speed < car3speed)
                Console.WriteLine($"1.{car3name}({car3speed})\n2.{car1name}({car1speed})\n3.{car2name}({car2speed}) ");
            else if (car1speed > car3speed && car2speed < car3speed)
                Console.WriteLine($"1.{car1name}({car1speed})\n2.{car3name}({car3speed})\n3.{car2name}({car2speed}) ");
            else if (car1speed < car3speed && car2speed > car3speed)
                Console.WriteLine($"1.{car2name}({car2speed})\n2.{car3name}({car3speed})\n3.{car1name}({car1speed}) ");
            else
                Console.WriteLine("Эррор =(");

            Console.WriteLine("Топ по экономичности:");

            if (car1fuel < car2fuel && car2fuel < car3fuel)
                Console.WriteLine($"1.{car1name}({car1fuel})\n2.{car2name}({car2fuel})\n3.{car3name}({car3fuel}) ");
            else if (car1fuel > car2fuel && car1fuel < car3fuel)
                Console.WriteLine($"1.{car2name}({car2fuel})\n2.{car1name}({car1fuel})\n3.{car3name}({car3fuel}) ");
            else if (car1fuel > car2fuel && car2fuel > car3fuel)
                Console.WriteLine($"1.{car3name}({car3fuel})\n2.{car2name}({car2fuel})\n3.{car1name}({car1fuel}) ");
            else if (car1fuel < car2fuel && car1fuel > car3fuel)
                Console.WriteLine($"1.{car3name}({car3fuel})\n2.{car1name}({car1fuel})\n3.{car2name}({car2fuel}) ");
            else if (car1fuel < car3fuel && car2fuel > car3fuel)
                Console.WriteLine($"1.{car1name}({car1fuel})\n2.{car3name}({car3fuel})\n3.{car2name}({car2fuel}) ");
            else if (car1fuel > car3fuel && car2fuel < car3fuel)
                Console.WriteLine($"1.{car2name}({car2fuel})\n2.{car3name}({car3fuel})\n3.{car1name}({car1fuel}) ");
            else
                Console.WriteLine("Эррор =(");

        }
    }
}
