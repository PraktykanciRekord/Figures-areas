﻿using System;
namespace MyApplication
{
    public class Recttangle
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Recttangle()
        {
           
        }

        public void rectangle()
        {
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
        }
    }
}

