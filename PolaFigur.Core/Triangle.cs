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
            double g = a * h / 2;
            return g;
        }

        public static double TriPer(double z, double x, double c)
        {
            double v = z + x + c;
            return v;
        }

        
    }
}

