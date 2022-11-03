using System;

namespace MyApplication
{
    class Program
    {
        static void squareArea(int a)
        {
            Console.WriteLine(a * a);
        }

        static void rectangleArea(int b, int c)
        {
            Console.WriteLine(b * c);
        }

        static void Main(string[] args)
        {
            squareArea(4);
            rectangleArea(2, 4);
        }
    }
}