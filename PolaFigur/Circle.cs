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
            return (Math.Pow((Math.PI * r), 2));
        }

        public static double CirPer(double rr)
        {
            return Math.PI * rr * 2;
        }

    }
}

