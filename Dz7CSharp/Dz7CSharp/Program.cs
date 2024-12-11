using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz7CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("N 7:");

            Console.WriteLine($"Початок:");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine($"Кінець:");
            int b = int.Parse(Console.ReadLine());

            if(a  < b)
            {
                Console.Write($"Результат:");
                for (int i = a; i < b; i+=2) 
                {
                    Console.WriteLine(i);
                }
            }
            if(b < a)
            {
                Console.Write($"Результат:");
                for (int i = b;i < a; i+=2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
