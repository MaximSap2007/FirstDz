using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("N 4:");
            int[] number = new int[6];
            number[0] = int.Parse(Console.ReadLine());
            number[1] = int.Parse(Console.ReadLine());
            number[2] = int.Parse(Console.ReadLine());

            number[3] = int.Parse(Console.ReadLine());
            number[4] = int.Parse(Console.ReadLine());
            number[5] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ввдеіть номери для заміни(a і b):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == 1 || b == 2)
            {
                Console.Write(number[1]);
                Console.Write(number[0]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 1 || b == 3)
            {
                Console.Write(number[2]);
                Console.Write(number[1]);
                Console.Write(number[0]);

                Console.Write(number[3]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 1 || b == 4)
            {
                Console.Write(number[3]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[0]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 1 || b == 5)
            {
                Console.Write(number[4]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[0]);
                Console.Write(number[5]);
                return;
            }

            if (a == 1 || b == 6)
            {
                Console.Write(number[5]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[4]);
                Console.Write(number[0]);
            }
            //
            if (a == 2 || b == 3)
            {
                Console.Write(number[0]);
                Console.Write(number[2]);
                Console.Write(number[1]);

                Console.Write(number[3]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 2 || b == 4)
            {
                Console.Write(number[0]);
                Console.Write(number[3]);
                Console.Write(number[2]);

                Console.Write(number[1]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 2 || b == 5)
            {
                Console.Write(number[0]);
                Console.Write(number[4]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[1]);
                Console.Write(number[5]);
                return;
            }

            if (a == 2 || b == 6)
            {
                Console.Write(number[0]);
                Console.Write(number[5]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[0]);
                Console.Write(number[1]);
                return;
            }
            //
            if (a == 3 || b == 4)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[3]);

                Console.Write(number[2]);
                Console.Write(number[4]);
                Console.Write(number[5]);
                return;
            }

            if (a == 3 || b == 5)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[4]);

                Console.Write(number[3]);
                Console.Write(number[2]);
                Console.Write(number[5]);
                return;
            }

            if (a == 3 || b == 6)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[5]);

                Console.Write(number[3]);
                Console.Write(number[4]);
                Console.Write(number[2]);
                return;
            }
            //
            if (a == 4 || b == 5)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[4]);
                Console.Write(number[3]);
                Console.Write(number[5]);
                return;
            }

            if (a == 4 || b == 6)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[5]);
                Console.Write(number[4]);
                Console.Write(number[3]);
                return;
            }
            //
            if (a == 5 || b == 6)
            {
                Console.Write(number[0]);
                Console.Write(number[1]);
                Console.Write(number[2]);

                Console.Write(number[3]);
                Console.Write(number[5]);
                Console.Write(number[4]);
                return;
            }
        }
    }
}
