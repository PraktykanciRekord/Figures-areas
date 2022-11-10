using System;
namespace MyApplication
{
    public class Trapeze
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;


        public Trapeze()
        {

        }

        public void trapeze()
        {
            Console.WriteLine("\npole = 1\n");
            Console.WriteLine("obwód = 2\n");

            Figura = int.Parse(Console.ReadLine());
            switch (Figura)
            {
                case 1:

                    {

                        Console.WriteLine("\nWprowadź długość boku a \n");
                        var szczur = Console.ReadLine();

                        double numericValue;
                        bool isNumber = double.TryParse(szczur, out numericValue);

                        while (isNumber == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur = Console.ReadLine();
                            isNumber = double.TryParse(szczur, out numericValue);
                            continue;

                        }
                        Console.WriteLine("\nWprowadź długość boku b \n");
                        var szczur2 = Console.ReadLine();
                        bool isNumber2 = double.TryParse(szczur2, out numericValue);
                        while (isNumber2 == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur2 = Console.ReadLine();
                            isNumber2 = double.TryParse(szczur2, out numericValue);
                            continue;

                        }
                        Console.WriteLine("\nWprowadź długość wysokości h \n");
                        var szczur3 = Console.ReadLine();
                        bool isNumber3 = double.TryParse(szczur3, out numericValue);

                        while (isNumber3 == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur3 = Console.ReadLine();
                            isNumber3 = double.TryParse(szczur3, out numericValue);
                            continue;

                        }
                        if (isNumber == true && isNumber2 == true && isNumber3 == true)
                        {
                            Console.WriteLine("\npole tego trapezu to: \n");
                            double a = Convert.ToDouble(szczur);
                            double b = Convert.ToDouble(szczur2);
                            double h = Convert.ToDouble(szczur3);
                            double p;
                            p = (a + b) * h / 2;
                            Console.WriteLine(p);
                        }
                    }
                    break;
                case 2:

                    {

                        Console.WriteLine("\nWprowadź długość boku a \n");
                        var szczur = Console.ReadLine();

                        double numericValue;
                        bool isNumber = double.TryParse(szczur, out numericValue);

                        while (isNumber == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur = Console.ReadLine();
                            isNumber = double.TryParse(szczur, out numericValue);
                            continue;

                        }
                        Console.WriteLine("\nWprowadź długość boku b \n");
                        var szczur2 = Console.ReadLine();
                        bool isNumber2 = double.TryParse(szczur2, out numericValue);
                        while (isNumber2 == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur2 = Console.ReadLine();
                            isNumber2 = double.TryParse(szczur2, out numericValue);
                            continue;

                        }
                        Console.WriteLine("\nWprowadź długość boku c \n");
                        var szczur3 = Console.ReadLine();
                        bool isNumber3 = double.TryParse(szczur3, out numericValue);

                        while (isNumber3 == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur3 = Console.ReadLine();
                            isNumber3 = double.TryParse(szczur3, out numericValue);
                            continue;

                        }
                        Console.WriteLine("\nWprowadź długość boku d \n");
                        var szczur4 = Console.ReadLine();
                        bool isNumber4 = double.TryParse(szczur4, out numericValue);

                        while (isNumber4 == false)
                        {

                            Console.WriteLine("podaj cyfrę");
                            szczur4 = Console.ReadLine();
                            isNumber4 = double.TryParse(szczur4, out numericValue);
                            continue;

                        }
                        if (isNumber == true && isNumber2 == true && isNumber3 == true && isNumber4 == true)
                        {
                            Console.WriteLine("\nobwód tego trapezu to: \n");
                            double a = Convert.ToDouble(szczur);
                            double b = Convert.ToDouble(szczur2);
                            double c = Convert.ToDouble(szczur3);
                            double d = Convert.ToDouble(szczur4);
                            double p;
                            p = a + b + c + d;
                            Console.WriteLine(p);
                        }
                    }
                    break;

            }
        }
    }
}

