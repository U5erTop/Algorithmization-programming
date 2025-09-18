using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 7!
            double x1 = 3.5, y1 = 0.9; 
            double x2 = 2, y2 = 0;     


            double distanceA = Math.Sqrt(x1 * x1 + y1 * y1);
            double distanceB = Math.Sqrt(x2 * x2 + y2 * y2);

            if (Math.Abs(distanceA - distanceB) < 0.0001) 
            {
                Console.WriteLine("Точки A и B находятся на одинаковом расстоянии от начала координат");
            }
            else if (distanceA < distanceB)
            {
                Console.WriteLine("Точка A ближе к началу координат");
            }
            else
            {
                Console.WriteLine("Точка B ближе к началу координат");
            }

            
            Console.WriteLine($"Расстояние от A(0,0) до точки A({x1},{y1}): {distanceA:F4}");
            Console.WriteLine($"Расстояние от A(0,0) до точки B({x2},{y2}): {distanceB:F4}");


            Console.ReadKey();
        }
    }
}
