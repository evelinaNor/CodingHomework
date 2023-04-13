using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part19Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int pow = 1;
            int result = num;

            while (result < 1500)
            {
                Console.WriteLine(result);
                pow++;
                result = (int)Math.Pow(num, pow);
            }
        }
    }
}
