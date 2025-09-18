using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine($"a) = {x >=0 && (Math.Pow(y,2) != 4)}");

            Console.WriteLine($"б) = {(x * y != 0) || (y > x)}");
        }
    }
}
