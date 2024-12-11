using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("N 2:");

            Console.Write($"Введіть число:");
            double num = double.Parse(Console.ReadLine());

            Console.Write($"Введіть відсоток від числа {num}:");
            double per = double.Parse(Console.ReadLine());
            
            if(per < 0) 
            {
                Console.WriteLine("Error!");
                return;
            }

            double sto = 100;

            double res = (num * per) / sto;
            Console.WriteLine($"Результат = " + res);

        }
    }
}
