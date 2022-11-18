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

        public static double TrAr(double a, double b, double h)
        {
            double t = ((a + b) * h / 2);
            return t;
        }

        public static double TrPe(double aa, double bb, double cc, double dd)
        {
            double z = aa + bb + cc + dd;
            return z;
        }
    }
}

