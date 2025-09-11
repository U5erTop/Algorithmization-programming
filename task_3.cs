using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение перемнной - a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение перемнной - b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение перемнной - x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение перемнной - z");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"f = {7 * Math.Cos(b * Math.Pow(x,5) - (Math.Sin(Math.Pow(a,2) + Math.Cos(Math.Pow(x,3) + Math.Pow(z,5) - Math.Pow(a,2))))) / Math.Asin(Math.Pow(a,2)) + Math.Acos(Math.Pow(x,7) - Math.Pow(a,2))}");

            Console.ReadKey();  
        }
    }
}
