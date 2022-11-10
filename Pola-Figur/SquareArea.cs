using System;

namespace MyApplication
{
    public class SquareArea
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public SquareArea()
        {
            
        }

        public void Square()
        {

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
            }
        }
    }




