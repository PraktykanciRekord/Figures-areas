using System;

namespace Perimeters
{
    class FiguresPerimeters
    {
        static void squarePerimeter()
        {
            int a;
            int pole;
            Console.WriteLine("Wprowadź długość boku ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Obwód tego kwadratu to : ");
            pole = (a * 4);
            Console.WriteLine(pole);
        }

        static void rectanglePerimeter()
        {
            int b;
            int a;
            int obwod;
            Console.WriteLine("Wprowadź długość boku a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź długość boku b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("obwód tego prostokątu to: ");
            obwod = ((a * 2) + (b * 2));
            Console.WriteLine(obwod);
        }

        static void trianglePerimeter()
        {
            int a;
            int b;
            int c;
            int obwód;

            Console.WriteLine("Wprowadź długość boku a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wprowadź długość boku b ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wprowadź długość boku c ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("obwód tego trójkąta to: ");
            obwód = (a + b + c);
            Console.WriteLine(obwód);
        }

        static void trapezePerimeter()
        {
            int a;
            int b;
            int c;
            int d;
            int obwód;

            Console.WriteLine("Wprowadź długość boku a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wprowadź długość boku b ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wprowadź długość boku c ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Wprowadź długość boku d ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("obwód tego trapezu to: ");
            obwód = (a + b + c + d);
            Console.WriteLine(obwód);
        }

        static void circlePerimeter()
        {
            float r;
            double obw;

            Console.WriteLine("Wprowadź długość promienia r ");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("obwód tego koła to: ");
            obw = ((Math.PI * r) * 2);
            Console.WriteLine(obw);
        }

        static void rhombusPerimeter()
        {
            int a; 
            int obw;

            Console.WriteLine("Wprowadź długość odcinka a ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("obwód tego rombu to: ");
            obw = (a * 4);
            Console.WriteLine(obw);
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