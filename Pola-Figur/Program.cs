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
            double a = Int32.Parse(Console.ReadLine());

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
            double b = Int32.Parse(Console.ReadLine());

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
            double q = Int32.Parse(Console.ReadLine());
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
            double w = Int32.Parse(Console.ReadLine());
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
            double z = Int32.Parse(Console.ReadLine());
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
            double c = Int32.Parse(Console.ReadLine());
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