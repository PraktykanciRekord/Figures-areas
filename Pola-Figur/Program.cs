using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            int figura;
            int pole;
            int obwod;
            int Figura;
            Console.WriteLine("jaką figure chcesz obliczyć \n");
            Console.WriteLine("Kwadrat --- 1\n");
            Console.WriteLine("prostokąt - 2\n");
            Console.WriteLine("romb ------ 3\n");
            Console.WriteLine("trapez ---- 4\n");
            Console.WriteLine("trójkąt --- 5\n");
            Console.WriteLine("koło ------ 6\n");
            figura = int.Parse(Console.ReadLine());
            while (figura < 1 || figura > 6)
            {
                Console.WriteLine("\nnie ma takiej liczby\n");
                Console.WriteLine("\npowtórz\n");
                figura = int.Parse(Console.ReadLine());
            }
            switch (figura)
            {
                case 1:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {

                        case 1:
                            {
                                int a;
                                int p;
                                Console.WriteLine("\ndługość boku a \n");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("\npole tego kwadratu:\n ");
                                p = (a * a);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:


                            {
                                int a;
                                int obw;
                                Console.WriteLine("\ndługość boku a: \n");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nobwód tego Figurau: \n");
                                obw = (a * 4);
                                Console.WriteLine(obw);
                            }
                            break;

                    }
                    break;
                case 2:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                int a;
                                int b;
                                int p;
                                Console.WriteLine("\ndługość boku a: \n");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("\ndługość boku b: \n");
                                b = int.Parse(Console.ReadLine());
                                Console.WriteLine("\npole tego prostokąta: \n");
                                p = (a * b);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:


                            {
                                int b;
                                int a;
                                int obw;
                                Console.WriteLine("\ndługość boku a: ");
                                a = int.Parse(Console.ReadLine());
                                Console.WriteLine("\ndługość boku b: \n");
                                b = int.Parse(Console.ReadLine());
                                Console.WriteLine("\nobwód tego prostokąta: \n");
                                obw = ((a * 2) + (b * 2));
                                Console.WriteLine(obw);
                            }
                            break;

                    }
                    break;
                case 3:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                int e;
                                int f;
                                int p;

                                Console.WriteLine("\nWprowadź długość przeciwległej e \n");
                                e = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość przeciwległej f \n");
                                f = int.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego rombu to: \n");
                                p = (e * f / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:


                            {
                                int a; ;
                                int obw;

                                Console.WriteLine("\nWprowadź długość odcinka a \n");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nobwód tego rombu to: \n");
                                obw = (a * 4);
                                Console.WriteLine(obw);
                            }
                            break;

                    }
                    break;
                case 4:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                int a;
                                int b;
                                int h;
                                int p;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość wysokości h \n");
                                h = int.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego trapezu to: \n");
                                p = ((a + b) * h / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:

                            {
                                int a;
                                int b;
                                int c;
                                int d;
                                int obwód;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku c \n");
                                c = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku d \n");
                                d = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nobwód tego trapezu to: \n");
                                obwód = (a + b + c + d);
                                Console.WriteLine(obwód);
                            }
                            break;

                    }
                    break;
                case 5:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                int a;
                                int h;
                                int p;

                                Console.WriteLine("\nWprowadź długość odcinka a \n");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość wysokości h \n");
                                h = int.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego trójkąta to: \n");
                                p = ((a * h) / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:

                            {
                                int a;
                                int b;
                                int c;
                                int obwód;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku c \n");
                                c = int.Parse(Console.ReadLine());

                                Console.WriteLine("\nobwód tego trójkąta to: \n");
                                obwód = (a + b + c);
                                Console.WriteLine(obwód);
                            }
                            break;

                    }
                    break;
                case 6:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = int.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:
                            {
                                float r;
                                double p;

                                Console.WriteLine("\nWprowadź długość promienia r \n");
                                r = float.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego koła to: \n");
                                p = (Math.Pow((Math.PI * r), 2));
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:

                            {
                                float r;
                                double obw;

                                Console.WriteLine("\nWprowadź długość promienia r \n");
                                r = float.Parse(Console.ReadLine());

                                Console.WriteLine("\nobwód tego koła to: \n");
                                obw = ((Math.PI * r) * 2);
                                Console.WriteLine(obw);
                            }
                            break;

                    }
                    break;


            }
        }
    }
}