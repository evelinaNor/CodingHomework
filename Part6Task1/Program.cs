using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                int sum = 5 * i;
                Console.WriteLine($"5 x {i} = {sum}");
            }

        }
    }
}
