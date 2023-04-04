using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part12Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two numbers:");
       
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 || number1 == 0) 
            {
                Console.WriteLine($"{number1} is bigger than {number2} or is equal to 0");
            }

            if (number2 > number1 || number2 == 5)
            {
                Console.WriteLine($"{number2} is bigger than {number1} or is equal to 5");
            }

            if (number1 > number2 && number1 == 20)
            {
                Console.WriteLine($"{number1} is bigger than {number2} and is equal to 20");
            }

            if (number2 > number1 && number2 < 100)
            {
                Console.WriteLine($"{number2} is bigger than {number1} and is less than 100");
            }
        }
    }
}
