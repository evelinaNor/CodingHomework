using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part9Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("Number is negative.");
            } 

            if (value > 0)
            {
                Console.WriteLine("Good job! You have entered a positive number.");
            }

            if (value % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }

            if (value % 4 == 0)
            {
                Console.WriteLine("The number can be divided by 4.");
            }

            if (value > 10)
            {
                Console.WriteLine("The number is bigger than 10.");
            }
        }
    }
}
