using System;

namespace Perimeters
{
    class FiguresPerimeters
    {
        static void squarePerimeter(int a)
        {
            Console.WriteLine(a * 4);
        }

        static void rectanglePerimeter(int b, int c)
        {
            Console.WriteLine(b * 2 + c * 2);
        }

        static void trianglePerimeter(int cc, int mm, int yy)
        {
            Console.WriteLine(cc + mm + yy);
        }

        static void trapezePerimeter(int q, int w, int e, int qq)
        {
            Console.WriteLine(q + w + e + qq);
        }

        static void circlePerimeter(int r)
        {
            Console.WriteLine((Math.PI * r) * 2);
        }

        static void rhombusPerimeter(int zz, int xx, int cc, int bb)
        {
            Console.WriteLine(zz + xx + cc + bb);
        }

        static void Main(string[] args)
        {
            squarePerimeter(4);
            rectanglePerimeter(6, 2);
            trianglePerimeter(2, 2, 2);
            trapezePerimeter(6, 7, 2, 2);
            circlePerimeter(5);
            rhombusPerimeter(4, 4, 4, 4);  
        }
    }
}