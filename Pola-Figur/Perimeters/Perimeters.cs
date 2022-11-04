using System;

namespace Perimeters
{
    class Perimeters
    {

        static void squarePerimeter()
        {
            int a;
            int perimeter;
            Console.WriteLine("Enter value: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Perimeter of this square is: ");
            perimeter = (a * 4);
            Console.WriteLine(perimeter);
        }

        static void rectanglePerimeter()
        {
            int b;
            int a;
            int perimeter;
            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of side b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Perimeter of this rectangle is: ");
            perimeter = ((a * 2) + (b * 2));
            Console.WriteLine(perimeter);
        }

        static void trianglePerimeter()
        {
            int a;
            int b;
            int c;
            int perimeter;

            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Perimeter of this triangle is: ");
            perimeter = (a + b + c);
            Console.WriteLine(perimeter);
        }

        static void trapezePerimeter()
        {
            int a;
            int b;
            int c;
            int d;
            int perimeter;

            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side c: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side d: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Perimeter of this trapeze is: ");
            perimeter = (a + b + c + d);
            Console.WriteLine(perimeter);
        }

        static void circlePerimeter()
        {
            float r;
            double pem;

            Console.WriteLine("Enter value of radius r: ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Perimeter of this circle is: ");
            pem = ((Math.PI * r) * 2);
            Console.WriteLine(pem);
        }

        static void rhombusPerimeter()
        {
            int a;
            int pem;

            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Perimeter of this rhombus is: ");
            pem = (a * 4);
            Console.WriteLine(pem);
        }

        static void Main(string[] args)
        {
            squarePerimeter();
            //rectanglePerimeter();
            //trianglePerimeter();
            //trapezePerimeter();
            ///circlePerimeter();
            //rhombusPerimeter();  

        }
    }
}