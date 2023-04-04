using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part13Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            switch(number1)
            {
                case 1:
                    int addition = number1 + number2 + number3;
                    Console.WriteLine($"{number1} + {number2} + {number3} = {addition}");
                    break;
                case 2:
                    int modulus = number1 % number3;
                    Console.WriteLine($"{number1} % {number2} = {modulus}");
                    break;

                case 3:
                    int multiplication = number2 * number3;
                    Console.WriteLine($"{number2} * {number3} = {multiplication}");
                    break;
                default: Console.WriteLine("Wrong, the first number must be between 1-3 in order to get any result. Please enter numbers again");
                    break;
            }
        }
    }
}
