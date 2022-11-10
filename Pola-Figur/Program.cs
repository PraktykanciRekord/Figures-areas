using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var chooseFigure = new Choose();
            chooseFigure.choose();
          

            var square = new SquareArea();
            square.Square();

            var rectangle = new Recttangle();
            rectangle.rectangle();

            var rhombus = new Rhombus();
            rhombus.rhombus();

            var trapeze = new Trapeze();
            trapeze.trapeze();

            var triangle = new Triangle();
            triangle.triangle();

            var circle = new Circle();
            circle.circle();
        }
    }
}