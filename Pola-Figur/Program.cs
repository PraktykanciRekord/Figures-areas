using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var chooseFigure = new Choose(2, 2, 2, 2);
            chooseFigure.choose();

            var square = new SquareArea(2, 2, 2, 2);
            square.Square();
        }
    }
}