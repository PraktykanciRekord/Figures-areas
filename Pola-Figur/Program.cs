using System;

namespace MyApplication
{
    class Program
    {

        private void SqArea()
        {
            SquareArea fnc = new SquareArea();
            Console.WriteLine("Podaj dlugosc");
            
            var szczur = Console.ReadLine();
            double numericValue;
            bool isNumber = double.TryParse(szczur, out numericValue);
            double a = double.Parse(Console.ReadLine());

            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur = Console.ReadLine();
                isNumber = double.TryParse(szczur, out numericValue);
                continue;

            }
            if (isNumber == true)
            {
                Console.WriteLine("\nPole tego kwadratu to: \n");
                double x = Convert.ToDouble(szczur);
                Console.WriteLine(SquareArea.SquareA(a));
            }
            
        }

        private void SqPeri()
        {
            SquareArea perm = new SquareArea();
            Console.WriteLine("Podaj dlugosc");
            double b = double.Parse(Console.ReadLine());

            var szczur = Console.ReadLine();
            double numericValue;
            bool isNumber = double.TryParse(szczur, out numericValue);
            

            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur = Console.ReadLine();
                isNumber = double.TryParse(szczur, out numericValue);
                continue;

            }
            if (isNumber == true)
            {
                Console.WriteLine("\nObwód tego kwadratu to: \n");
                double a = Convert.ToDouble(szczur);
                Console.WriteLine(SquareArea.SquareA(b));
            }
        }

        private void ReArea()
        {
            Recttangle fir = new Recttangle();
            Console.WriteLine("Wprowadź długość boku pierwszego ");
            double q = double.Parse(Console.ReadLine());
            var szczur = Console.ReadLine();

            double numericValue;
            bool isNumber = double.TryParse(szczur, out numericValue);

            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur = Console.ReadLine();
                isNumber = double.TryParse(szczur, out numericValue);
                continue;

            }
            Console.WriteLine("Wprowadź długość boku drugiego ");
            double w = double.Parse(Console.ReadLine());
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);

            while (isNumber2 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true)
            {
                Console.WriteLine("Pole tego prostokątu to: ");
                Console.WriteLine(Recttangle.recArea(q, w));
            }
        }

        private void rePem()
        {
            Recttangle per = new Recttangle(); 

            Console.WriteLine("Wprowadź długość boku pierwszego ");
            double z = double.Parse(Console.ReadLine());
            var szczur = Console.ReadLine();

            double numericValue;
            bool isNumber = double.TryParse(szczur, out numericValue);

            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur = Console.ReadLine();
                isNumber = double.TryParse(szczur, out numericValue);
                continue;

            }
            Console.WriteLine("Wprowadź długość boku drugiego ");
            double c = double.Parse(Console.ReadLine());
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);
            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true)
            {
                Console.WriteLine("Obwód tego prostokątu to: ");
                Console.WriteLine(Recttangle.rePem(z, c));
            }

        }

        private void RhomArea()
        {
            Rhombus rhAr = new Rhombus();

            Console.WriteLine("\nWprowadź długość przeciwległej e \n");
            double e = double.Parse(Console.ReadLine());

            var szczur = Console.ReadLine();

            double numericValue;
            bool isNumber = double.TryParse(szczur, out numericValue);

            while (isNumber == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur = Console.ReadLine();
                isNumber = double.TryParse(szczur, out numericValue);
                continue;

            }
            Console.WriteLine("\nWprowadź długość przeciwległej f \n");
            double f = double.Parse(Console.ReadLine());
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);
            while (isNumber2 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true)
            {
                Console.WriteLine("\npole tego rombu to: \n");
                Console.WriteLine(Rhombus.RhoArea(e, f));

            }
        }

        static void Main(string[] args)
        {

            var chooseFigure = new Choose();
            chooseFigure.choose();

            Program wkn = new Program();
            wkn.SqArea();

            Program sqp = new Program();
            sqp.SqPeri();

            Program re = new Program();
            re.ReArea();

            Program RePem = new Program();
            RePem.rePem();
        }
    }
}