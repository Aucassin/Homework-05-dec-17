using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_dec_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
//ПОСЛЕДОВАТЕЛЬНЫЙ IF
            //double lowprice = 27.5;
            //double highprice = 39.2;

            //Console.WriteLine("Enter a new price in \"XX,XX\" format");
            //double price = double.Parse(Console.ReadLine());

            //if (price <= lowprice)

            //    Console.WriteLine("Price is extremely low");
            //if (price >= highprice)

            //    Console.WriteLine("Price is extremely high");


//ВЛОЖЕННЫЙ IF

            double lowprice = 27.5;
            double highprice = 39.2;
            double superlowprice = 17.5;
            double superhighprice = 69.2;


            Console.WriteLine("Enter a new price in \"XX,XX\" format");
            double price = double.Parse(Console.ReadLine());

            if (price <= lowprice)
            {
                Console.WriteLine("Price is low");
                {
                    if (price <= superlowprice)
                        Console.WriteLine("Price is extremely low");
                }
            }

            if (price >= highprice)
            {
                Console.WriteLine("Price is high");
                {
                    if (price >= superhighprice)
                        Console.WriteLine("Price is extremely high");
                }
            }

        }
    }
}
