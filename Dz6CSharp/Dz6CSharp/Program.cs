using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("N 6:");


            Console.WriteLine($"Введіть  1 - для Фарангейту або 2  - для Цельсію:");
                
            int fc  = int.Parse(Console.ReadLine());

            if (fc == 1)
            {
                Console.Write($"Введіть температуру у Цельсіях:");
                double FC = double.Parse(Console.ReadLine());

                double Far = (FC * 1.8) + 32;

                Console.WriteLine(Far);
            }
            if (fc == 2)
            {
                Console.Write($"Введіть температуру у Фарангейтах:");
                double FC = double.Parse(Console.ReadLine());

                double Cels = (FC - 32) / 1.8;

                Console.WriteLine(Cels);
            }
        }
    }
}
