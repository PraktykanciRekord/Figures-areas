using System;
namespace MyApplication
{
    public class Circle
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Circle()
        {
        }

        public static double CirAr(double r)
        {
            double q = (Math.Pow((Math.PI * r), 2));
            return q;
        }

        public static double CirPer(double rr)
        {
            double z = Math.PI * rr * 2;
            return z;
        }

    }
}

