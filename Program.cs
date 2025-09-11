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
            //1 https://learn.microsoft.com/ru-ru/dotnet/api/system.text.regularexpressions.match?view=net-6.0
            //Console.WriteLine("Введите значение перемнной - t");
            //double t = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите значение перемнной - l");
            //double l = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"R = {3 * Math.Pow(t,2) + 3 * Math.Pow(l,5) + 4.9}");

            //Console.WriteLine("Введите значение перемнной - y");
            //double y = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"N = {3 * Math.Pow(y,2) + Math.Sqrt(y + 1)}");


            Console.WriteLine("Введите значение перемнной - x");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение перемнной - y");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"R = {Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y),2 + 6.835)) + Math.Exp(x))}");

            Console.ReadKey();  
        }
    }
}
