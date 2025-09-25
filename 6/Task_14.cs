using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X (|X| < 1): ");
            double X = double.Parse(Console.ReadLine());

            Console.Write("Введите N (> 0): ");
            int N = int.Parse(Console.ReadLine());

            double sum = 0.0;
            for (int k = 1; k <= N; k++)
            {
                double term = Math.Pow(-1, k + 1) * Math.Pow(X, k) / k;
                sum += term;
            }

            Console.WriteLine($"Приближённое значение ln(1+X): {sum}");
            Console.WriteLine($"Точное значение ln(1+X): {Math.Log(1 + X)}");

            Console.ReadKey();
        }
    }
}
