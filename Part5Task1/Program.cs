using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int sum = a + b;
            int sum2 = a - b;
            int sum3 = a * b;
            float sum4 =(float) a / b;

            Console.WriteLine($"{a} / {b} = {sum}");
            Console.WriteLine($"{a} / {b} = {sum2}");
            Console.WriteLine($"{a} / {b} = {sum3}");
            Console.WriteLine($"{a} / {b} = {sum4}");
        }
    }
}
