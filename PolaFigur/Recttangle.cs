using System;
namespace MyApplication
{
    public class Recttangle
    {
        public double figura;
        public double pole;
        public double obwod;
        public double Figura;

        public Recttangle()
        {
           
        }

        public static double recArea(double q, double w)
        {
            return q * w;
           
        }


        public static double rePem(double z, double c)
        {
            return z * 2 + c * 2;
        }
    }
}

