using System;

namespace Perimeters
{
    class Areas
    {
        static void squareArea(int a)
        {
            Console.WriteLine(a * a);
        }

        static void rectangleArea(int b, int c)
        {
            Console.WriteLine(b * c);
        }

        static void triangleArea(int z, int h)
        {
            Console.WriteLine(z * h / 2);
        }

        static void circleArea(int r)
        {
            Console.WriteLine(Math.Pow((Math.PI * r), 2));
        }

        static void trapezeArea(int t, int i, int pp)
        {
            Console.WriteLine((t + i) * pp / 2);
        }

        static void rhombusArea(int e, int f)
        {
            Console.WriteLine(e * f / 2);
        }

        static void Main(string[] args)
        {
            squareArea(4);
            rectangleArea(2, 4);
            triangleArea(4, 6);
            circleArea(2);
            trapezeArea(2, 2, 10);
            rhombusArea(10, 5);
        }
    }
}