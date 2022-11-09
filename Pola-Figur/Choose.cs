using System;
namespace MyApplication
{
    public class Choose
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Choose(double figura, double pole, double obwod, double Figura)
        {
            this.figura = figura;
            this.pole = pole;
            this.obwod = obwod;
            this.Figura = Figura;
        }



        public void choose()
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
}

