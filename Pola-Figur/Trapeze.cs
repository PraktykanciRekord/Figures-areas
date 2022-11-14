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
            return ((a + b) * h / 2);
        }

        public static double TrPe(double aa, double bb, double cc, double dd)
        {
            return aa + bb + cc + dd;
        }
    }
}

