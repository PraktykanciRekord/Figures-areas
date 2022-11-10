using System;
namespace MyApplication
{
    public class Choose
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Choose()
        {
            
        }



        public void choose()
        {
            double figura;
            double pole;
            double obwod;
            double Figura;
            Console.WriteLine("Obliczanie pola i obwodow figur: \n");
            Console.WriteLine("Kwadrat --- 1 figura\n");
            Console.WriteLine("prostokąt - 2 fiugra\n");
            Console.WriteLine("romb ------ 3 figura\n");
            Console.WriteLine("trapez ---- 4 figura\n");
            Console.WriteLine("trójkąt --- 5 figura\n");
            Console.WriteLine("koło ------ 6 figura\n");
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

