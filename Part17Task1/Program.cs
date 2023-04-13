using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part17Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }

        }
    }
}
