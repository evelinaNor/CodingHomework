using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 32;
            int digit1 = number / 10;
            int digit2 = number % 10;
            int result = digit1 * digit2;

            Console.WriteLine(number);
            Console.WriteLine($"{digit1} * {digit2} = {result}");
        }
    }
}
