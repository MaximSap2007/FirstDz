using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"Це 1 номер, а 2 знаходиться у файлі під назвою 'Dz1CSharp'");

            Console.WriteLine("N 1:");
            Console.Write($"Введіть число:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 || number < 100)
            {
                if (calc(number))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Число {number} ділится на 3!");
                    Console.WriteLine("Fizz");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число {number} НЕ ділится на 3!");
                    Console.BackgroundColor = ConsoleColor.Black;
                };

                if (calc2(number))
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Число {number} ділится на 5!");
                    Console.WriteLine("Buzz");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число {number} НЕ ділится на 5!");
                    Console.BackgroundColor = ConsoleColor.Black;
                };
            }
            else 
            {
                Console.WriteLine("Error!");return;
            }
        }
        static bool calc(int num)
        {
            return num % 3 == 0;
        }

        static bool calc2(int num)
        {
            return num % 5 == 0;
        }
    }
}
