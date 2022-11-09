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
                figura = int.Parse(Console.ReadLine());
            }

        }
    }

    public void Square(double figura)
    {
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
                            Console.WriteLine("\nWprowadź długość boku \n");
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
                            if (isNumber == true)
                            {
                                Console.WriteLine("\nPole tego kwadratu to: \n");
                                double a = Convert.ToDouble(szczur);
                                double p;
                                p = a * 2;
                                Console.WriteLine(p);
                            }
                        }
                        break;
                    case 2:

                        {
                            Console.WriteLine("\nWprowadź długość boku a\n");
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
                            if (isNumber == true)
                            {
                                Console.WriteLine("\nObwód tego kwadratu to: \n");
                                double a = Convert.ToDouble(szczur);
                                double p;
                                p = a * 4;
                                Console.WriteLine(p);
                            }
                        }
                        break;

                }
                break;
        }

        public void rectangle()
        {
      case 2:
        Console.WriteLine("\npole = 1\n");
        Console.WriteLine("obwód = 2\n");
        Figura = int.Parse(Console.ReadLine());
        switch (Figura)
        {
            case 1:

                {

                    Console.WriteLine("Wprowadź długość boku a ");
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
                    Console.WriteLine("Wprowadź długość boku b ");
                    var szczur2 = Console.ReadLine();
                    bool isNumber2 = double.TryParse(szczur2, out numericValue);

                    while (isNumber2 == false)
                    {

                        Console.WriteLine("podaj cyfrę");
                        szczur2 = Console.ReadLine();
                        isNumber2 = double.TryParse(szczur2, out numericValue);
                        continue;

                    }
                    if (isNumber == true && isNumber2 == true)
                    {
                        Console.WriteLine("Pole tego prostokątu to: ");
                        double a = Convert.ToDouble(szczur);
                        double b = Convert.ToDouble(szczur2);

                        double p;
                        p = a * b;
                        Console.WriteLine(p);
                    }
                }
                break;
            case 2:

                {

                    Console.WriteLine("Wprowadź długość boku a ");
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
                    Console.WriteLine("Wprowadź długość boku b ");
                    var szczur2 = Console.ReadLine();
                    bool isNumber2 = double.TryParse(szczur2, out numericValue);
                    while (isNumber == false)
                    {

                        Console.WriteLine("podaj cyfrę");
                        szczur2 = Console.ReadLine();
                        isNumber2 = double.TryParse(szczur2, out numericValue);
                        continue;

                    }
                    if (isNumber == true && isNumber2 == true)
                    {
                        Console.WriteLine("Obwód tego prostokątu to: ");
                        double a = Convert.ToDouble(szczur);
                        double b = Convert.ToDouble(szczur2);

                        double p;
                        p = (a * 2) + (b * 2);
                        Console.WriteLine(p);
                    }
                }
                break;

        }
        break;
    }

    public void Rhombus()
    {
      case 3:
        Console.WriteLine("\npole = 1\n");
        Console.WriteLine("obwód = 2\n");
        Figura = int.Parse(Console.ReadLine());
        switch (Figura)
        {
            case 1:

                {

                    Console.WriteLine("\nWprowadź długość przeciwległej e \n");
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
                    Console.WriteLine("\nWprowadź długość przeciwległej f \n");
                    var szczur2 = Console.ReadLine();
                    bool isNumber2 = double.TryParse(szczur2, out numericValue);
                    while (isNumber2 == false)
                    {

                        Console.WriteLine("podaj cyfrę");
                        szczur2 = Console.ReadLine();
                        isNumber2 = double.TryParse(szczur2, out numericValue);
                        continue;

                    }
                    if (isNumber == true && isNumber2 == true)
                    {
                        Console.WriteLine("\npole tego rombu to: \n");
                        double e = Convert.ToDouble(szczur);
                        double f = Convert.ToDouble(szczur2);
                        double p;
                        p = (e * f / 2);
                        Console.WriteLine(p);
                    }
                }
                break;
            case 2:

                {
                    {
                        Console.WriteLine("\nWprowadź długość boku a\n");
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
                        if (isNumber == true)
                        {
                            Console.WriteLine("\nObwód tego rombu to: \n");
                            double a = Convert.ToDouble(szczur);
                            double p;
                            p = a * 4;
                            Console.WriteLine(p);
                        }
                    }
                }
                break;

        }
        break;
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
        break;
    }

    public void triangle()
    {
      case 5:
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
                    Console.WriteLine("\nWprowadź długość wysokości h \n");
                    var szczur2 = Console.ReadLine();
                    bool isNumber2 = double.TryParse(szczur2, out numericValue);
                    while (isNumber2 == false)
                    {

                        Console.WriteLine("podaj cyfrę");
                        szczur2 = Console.ReadLine();
                        isNumber2 = double.TryParse(szczur2, out numericValue);
                        continue;

                    }
                    if (isNumber == true && isNumber2 == true)
                    {
                        Console.WriteLine("\nPole tego trójkąta to: \n");
                        double a = Convert.ToDouble(szczur);
                        double h = Convert.ToDouble(szczur2);

                        double p;
                        p = ((a * h) / 2);
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
                    if (isNumber == true && isNumber2 == true && isNumber3 == true)
                    {
                        Console.WriteLine("\nObwód tego trójkąta to: \n");
                        double a = Convert.ToDouble(szczur);
                        double b = Convert.ToDouble(szczur2);
                        double c = Convert.ToDouble(szczur3);

                        double p;
                        p = a + b + c;
                        Console.WriteLine(p);
                    }
                }
                break;

        }
        break;
    }

    public void circle()
    {
      case 6:
        Console.WriteLine("\npole = 1\n");
        Console.WriteLine("obwód = 2\n");
        Figura = int.Parse(Console.ReadLine());
        switch (Figura)
        {
            case 1:
                {
                    Console.WriteLine("\nWprowadź długość boku \n");
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
                    if (isNumber == true)
                    {
                        Console.WriteLine("\nPole tego kwadratu to: \n");
                        double a = Convert.ToDouble(szczur);
                        double p;
                        p = (Math.Pow((Math.PI * a), 2));
                        Console.WriteLine(p);
                    }
                }
                break;
            case 2:

                {
                    Console.WriteLine("\nWprowadź długość boku \n");
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
                    if (isNumber == true)
                    {
                        Console.WriteLine("\nPole tego kwadratu to: \n");
                        double a = Convert.ToDouble(szczur);
                        double p;
                        p = ((Math.PI * a) * 2);
                        Console.WriteLine(p);
                    }
                }
                break;

        }
        break;
    }

}
}