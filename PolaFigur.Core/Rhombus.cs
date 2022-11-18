using System;
namespace MyApplication
{
    public class Rhombus
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Rhombus()
        {

        }

        public static double RhoArea(double e, double f)
        {
            double m = e * f / 2;
            return m;
        }

        public static double rhomPer(double b)
        {
            double h = b * 4;
            return h;
        }
    }
}



