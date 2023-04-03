using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 22;
            double square = Math.Pow(number, 2);
            double cube = Math.Pow(number, 3);

            Console.WriteLine(number);
            Console.WriteLine(square);
            Console.WriteLine(cube);

        }
    }
}
