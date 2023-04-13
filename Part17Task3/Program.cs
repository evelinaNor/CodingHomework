using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }

        }
    }
}
