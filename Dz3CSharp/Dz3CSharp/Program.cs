using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("N 3:");
            int[] number = new int[4];
            number[0] = int.Parse(Console.ReadLine());
            if (number[0] > 10 || number[0] < 0)
            {
                Console.WriteLine("Error!");
                return;
            }
            number[1] = int.Parse(Console.ReadLine());
            if (number[1] > 10 || number[0] < 0)
            {
                Console.WriteLine("Error!");
                return;
            }
            number[2] = int.Parse(Console.ReadLine());
            if (number[2] > 10 || number[0] < 0)
            {
                Console.WriteLine("Error!");
                return;
            }
            number[3] = int.Parse(Console.ReadLine());
            if (number[3] > 10 || number[0] < 0)
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Write(number[0]);
            Console.Write(number[1]);
            Console.Write(number[2]);
            Console.Write(number[3]);

        }
    }
}
