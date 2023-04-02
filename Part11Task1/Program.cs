using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers");
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
               Console.WriteLine($"The first number {number1} is bigger than the second number {number2}");
            else if (number1 == number2)
                Console.WriteLine($"The first number {number1} and the second number {number1} are equal");
            else if (number2 > number3)
                Console.WriteLine($"The second number {number2} is bigger than the third number {number3}");
            else if (number3 > number1)
                Console.WriteLine($"The third number {number3} is bigger than the first number {number1}");
        }
    }
}
