using System;
namespace MyApplication
{
    public class Triangle
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;


        public Triangle()
        {
        }

        public static double TriAr(double a, double h)
        {
            return a * h / 2;
        }

        public static double TriPer(double z, double x, double c)
        {
            return z + x + c;
        }

        
    }
}

