using System;

namespace MyApplication
{
    public class SquareArea
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public SquareArea(double figura, double pole, double obwod, double Figura)
        {
            this.figura = figura;
            this.pole = pole;
            this.obwod = obwod;
            this.Figura = Figura;
        }

        public void Choose()
        {
            double figura;
            double pole;
            double obwod;
            double Figura;
            Console.WriteLine("jaką figure chcesz obliczyć \n");
            Console.WriteLine("Kwadrat --- 1\n");
            Console.WriteLine("prostokąt - 2\n");
            Console.WriteLine("romb ------ 3\n");
            Console.WriteLine("trapez ---- 4\n");
            Console.WriteLine("trójkąt --- 5\n");
            Console.WriteLine("koło ------ 6\n");
            figura = double.Parse(Console.ReadLine());
            while (figura < 1 || figura > 6)
            {
                Console.WriteLine("\nnie ma takiej liczby\n");
                Console.WriteLine("\npowtórz\n");
                figura = double.Parse(Console.ReadLine());
            }
            switch (figura)
            {
                case 1:
                    Console.WriteLine("\npole = 1\n");
                    Console.WriteLine("obwód = 2\n");
                    Figura = double.Parse(Console.ReadLine());
                    switch (Figura)
                    {

                        case 1:
                            {
                                double a;
                                double p;
                                bool succes = false;
                                
                                
                                    while (succes == false)
                                    {

                                        Console.WriteLine("\ndługość boku a \n");
                                        string t = Console.ReadLine();
                                        if (t == "")
                                        {
                                            Console.WriteLine("Puste");
                                            continue;
                                        }
                                        else
                                        {

                                            try
                                            {
                                                a = double.Parse(t);
                                            }
                                            catch (FormatException)
                                            {
                                                Console.WriteLine("Musi byc liczba");
                                                continue;
                                            }

                                        }
                                        succes = true;
                                    break;
                                    }
                                   a = double.Parse(Console.ReadLine());
                                   Console.WriteLine("\npole tego kwadratu:\n ");
                                   p = (a * a);
                                   Console.WriteLine(p);                              
                            }
                            break;
                        case 2:

                            {
                                double a;
                                double obw;
                                bool succes = false;
                                Console.WriteLine("\ndługość boku a: \n");
                                a = double.Parse(Console.ReadLine());
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
                    Figura = double.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                double a;
                                double p;
                                bool succes = false;
                                while (succes == false)
                                {

                                    Console.WriteLine("\ndługość boku a \n");
                                    string t = Console.ReadLine();
                                    if (t == "")
                                    {
                                        Console.WriteLine("Puste");
                                        continue;
                                    }
                                    else
                                    {

                                        try
                                        {
                                            a = double.Parse(t);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Musi byc liczba");
                                            continue;
                                        }

                                    }
                                    succes = true;
                                    break;
                                } succes = false;

                                double b;
                                while (succes == false)
                                {

                                    Console.WriteLine("\ndługość boku b \n");
                                    string u = Console.ReadLine();
                                    if (u == "")
                                    {
                                        Console.WriteLine("Puste");
                                        continue;
                                    }
                                    else
                                    {

                                        try
                                        {
                                            b = double.Parse(u);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Musi byc liczba");
                                            continue;
                                        }

                                    }
                                    succes = true;
                                    break;
                                }

                                Console.WriteLine("\ndługość boku a: \n");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("\ndługość boku b: \n");
                                b = double.Parse(Console.ReadLine());
                                Console.WriteLine("\npole tego prostokąta: \n");
                                p = (a * b);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:


                            {
                                double b;
                                double a;
                                double obw;
                                Console.WriteLine("\ndługość boku a: ");
                                a = double.Parse(Console.ReadLine());
                                Console.WriteLine("\ndługość boku b: \n");
                                b = double.Parse(Console.ReadLine());
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
                    Figura = double.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                double e;
                                double f;
                                double p;

                                Console.WriteLine("\nWprowadź długość przeciwległej e \n");
                                e = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość przeciwległej f \n");
                                f = double.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego rombu to: \n");
                                p = (e * f / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:


                            {
                                double a; ;
                                double obw;

                                Console.WriteLine("\nWprowadź długość odcinka a \n");
                                a = double.Parse(Console.ReadLine());

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
                    Figura = double.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                double a;
                                double b;
                                double h;
                                double p;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość wysokości h \n");
                                h = double.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego trapezu to: \n");
                                p = ((a + b) * h / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:

                            {
                                double a;
                                double b;
                                double c;
                                double d;
                                double obwód;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku c \n");
                                c = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku d \n");
                                d = double.Parse(Console.ReadLine());

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
                    Figura = double.Parse(Console.ReadLine());
                    switch (Figura)
                    {
                        case 1:

                            {
                                double a;
                                double h;
                                double p;

                                Console.WriteLine("\nWprowadź długość odcinka a \n");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość wysokości h \n");
                                h = double.Parse(Console.ReadLine());

                                Console.WriteLine("\npole tego trójkąta to: \n");
                                p = ((a * h) / 2);
                                Console.WriteLine(p);
                            }
                            break;
                        case 2:

                            {
                                double a;
                                double b;
                                double c;
                                double obwód;

                                Console.WriteLine("\nWprowadź długość boku a \n");
                                a = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku b \n");
                                b = double.Parse(Console.ReadLine());

                                Console.WriteLine("\nWprowadź długość boku c \n");
                                c = double.Parse(Console.ReadLine());

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
                    Figura = double.Parse(Console.ReadLine());
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