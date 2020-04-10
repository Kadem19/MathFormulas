using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
           CircCircumference();

           CircArea();

           HemisphereVol();

           TriArea();

           QuadEquation();
        }
         static double GetRadius()
        {
            string userInput;
            double radius;
            Console.WriteLine("Enter radius: ");
            userInput = Console.ReadLine();
            radius = double.Parse(userInput);
            
            return radius;
        }

        static (double, double, double) GetABC()
        {
            string userInput;
            double a;
            double b;
            double c;
            
            Console.Write("Enter A: ");
            userInput = Console.ReadLine();
            a = double.Parse(userInput);
            
            Console.Write("Enter B: ");
            userInput = Console.ReadLine();
            b = double.Parse(userInput);

            Console.Write("Enter C: ");
            userInput = Console.ReadLine();
            c = double.Parse(userInput);

            return (a, b, c);  
        }

        public static void CircCircumference()
        {
            double radius;
            Console.WriteLine("Circle Circumference");
            radius = GetRadius();
            double circumference = 2.0 * Math.PI * radius;
            Console.WriteLine("Circle Circumference is: " + circumference);
            Console.WriteLine("--------------------------------");
        }

        public static void CircArea()
        {
            double radius;
            Console.WriteLine("Circle Area");
            radius = GetRadius();
            double area = Math.PI * radius * radius;
            Console.WriteLine("Circle area is: {0}", area);
            Console.WriteLine("--------------------------------");
        }

        public static void HemisphereVol()
        {
            double radius;
            double volume;
            Console.WriteLine("Hemisphere Volume");
            radius = GetRadius();
            volume = 4.0 / 3.0 * Math.PI * radius * radius * radius / 2.0;
            Console.WriteLine($"Hemisphere volume is: {volume}");
            Console.WriteLine("--------------------------------");
        }

        public static void TriArea()
        {
            Console.WriteLine("Heron's Formula");
            double area;
            double a, b, c;
            (a, b, c) = GetABC();
            
            double p = (a + b + c) / 2.0;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Triangle area is: {area}");
            Console.WriteLine("--------------------------------");
        }

        public static void QuadEquation()

        { 
            Console.WriteLine("Quadratic Equation");
            double a, b, c;
            (a, b, c) = GetABC();
            double x1 = (-b + Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a);
            Console.WriteLine($"Solution 1: {x1}");
            Console.WriteLine($"Solution 2: {x2}");
            Console.WriteLine("--------------------------------");
        }
    }
}
