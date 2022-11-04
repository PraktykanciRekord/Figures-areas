using System;

namespace Areas
{
    class Areas
    {
        static void squareArea()
        {
            int a;
            int area;
            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Area of this sqaure is: ");
            area = (a * a);
            Console.WriteLine(area);
        }

        static void rectangleArea()
        {
            int b;
            int a;
            int area;
            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of side b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Area of this rectangle is: ");
            area = (a * b);
            Console.WriteLine(area);
        }

        static void triangleArea()
        {
            int a;
            int h;
            int area;

            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of height h: "); 
            h = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Area of this triangle: ");
            area = ((a * h) / 2);
            Console.WriteLine(area);
        }

        static void circleArea()
        {
            float r;
            double area;

            Console.WriteLine("Enter the value of radius r: ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Area of this circle is: ");
            area = (Math.Pow((Math.PI * r), 2));
            Console.WriteLine(area);
        }

        static void trapezeArea()
        {
            int a;
            int b;
            int h;
            int area;

            Console.WriteLine("Enter the value of side a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of height h: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Area of this trapeze is: ");
            area = ((a + b) * h / 2);
            Console.WriteLine(area);
        }

        static void rhombusArea()
        {
            int e;
            int f;
            int area;

            Console.WriteLine("Enter the value of side e: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of side f: ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Area of this rhombus is: ");
            area = (e * f / 2);
            Console.WriteLine(area);
        }

        static void Main(string[] args)
        {
            squareArea();
            //rectangleArea();
            //triangleArea();
            //circleArea();
            //trapezeArea();
            //rhombusArea();
        }
    }
}
