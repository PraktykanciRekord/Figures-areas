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

        static void Main(string[] args)
        {
            squareArea(4);
            rectangleArea(2, 4);
            triangleArea(4, 6);
        }
    }
}