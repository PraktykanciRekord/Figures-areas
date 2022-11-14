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

        private void RhomPer()
        {
            Rhombus rhAr = new Rhombus();

            Console.WriteLine("\nWprowadź długość boku b \n");
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
           
                Console.WriteLine("\nobowd tego rombu to: \n");
                Console.WriteLine(Rhombus.rhomPer(b));
            }

        private void TrapAr()
        {
            Trapeze tr = new Trapeze();

            Console.WriteLine("\nWprowadź długość boku a \n");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
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
            Console.WriteLine("\nWprowadź długość boku b \n");
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);
            while (isNumber2 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            Console.WriteLine("\nWprowadź długość wysokości h \n");
            var szczur3 = Console.ReadLine();
            bool isNumber3 = double.TryParse(szczur3, out numericValue);

            while (isNumber3 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur3 = Console.ReadLine();
                isNumber3 = double.TryParse(szczur3, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true && isNumber3 == true)
            {
                Console.WriteLine("\npole tego trapezu to: \n");
                Console.WriteLine(Trapeze.TrAr(a,b,h));
            }
        }

        private void TrapPer()
        {
            Trapeze TrPe = new Trapeze();

            Console.WriteLine("\nWprowadź długość boku a \n");
            double aa = double.Parse(Console.ReadLine());
            double bb = double.Parse(Console.ReadLine());
            double cc = double.Parse(Console.ReadLine());
            double dd = double.Parse(Console.ReadLine());

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
            Console.WriteLine("\nWprowadź długość boku b \n");
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);
            while (isNumber2 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            Console.WriteLine("\nWprowadź długość boku c \n");
            var szczur3 = Console.ReadLine();
            bool isNumber3 = double.TryParse(szczur3, out numericValue);

            while (isNumber3 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur3 = Console.ReadLine();
                isNumber3 = double.TryParse(szczur3, out numericValue);
                continue;

            }
            Console.WriteLine("\nWprowadź długość boku d \n");
            var szczur4 = Console.ReadLine();
            bool isNumber4 = double.TryParse(szczur4, out numericValue);

            while (isNumber4 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur4 = Console.ReadLine();
                isNumber4 = double.TryParse(szczur4, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true && isNumber3 == true && isNumber4 == true)
            {
                Console.WriteLine("\nobwód tego trapezu to: \n");
                
                Console.WriteLine(Trapeze.TrPe(aa,bb,cc,dd));
            }
        }

        private void TriArea()
        {
            Triangle trAr = new Triangle();
            Console.WriteLine("\nWprowadź długość boku a \n");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

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
            Console.WriteLine("\nWprowadź długość wysokości h \n");
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
                Console.WriteLine("\nPole tego trójkąta to: \n");
                Console.WriteLine(Triangle.TriAr(a, h));
            }
        }

        private void TriPer()
        {
            Triangle trPer = new Triangle();
            Console.WriteLine("\nWprowadź długość boku a \n");
            double z = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
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
            Console.WriteLine("\nWprowadź długość boku b \n");
            var szczur2 = Console.ReadLine();
            bool isNumber2 = double.TryParse(szczur2, out numericValue);
            while (isNumber2 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur2 = Console.ReadLine();
                isNumber2 = double.TryParse(szczur2, out numericValue);
                continue;

            }
            Console.WriteLine("\nWprowadź długość boku c \n");
            var szczur3 = Console.ReadLine();
            bool isNumber3 = double.TryParse(szczur3, out numericValue);
            while (isNumber3 == false)
            {

                Console.WriteLine("podaj cyfrę");
                szczur3 = Console.ReadLine();
                isNumber3 = double.TryParse(szczur3, out numericValue);
                continue;

            }
            if (isNumber == true && isNumber2 == true && isNumber3 == true)
            {
                Console.WriteLine("\nObwód tego trójkąta to: \n");
                
                Console.WriteLine(Triangle.TriPer(z,x,c));
            }
        }
        private void cirArea()
        {
            Circle cirAr = new Circle();
            Console.WriteLine("\nWprowadź długość promienia \n");
            double r = double.Parse(Console.ReadLine());
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
                Console.WriteLine("\nPole tego kwadratu to: \n");
                
                Console.WriteLine(Circle.CirAr(r));
            }

        }

        private void cirPer()
        {
            Circle cirPer = new Circle();

            Console.WriteLine("\nWprowadź długość boku \n");
            double rr = double.Parse(Console.ReadLine());
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
                Console.WriteLine("\nPole tego kwadratu to: \n");
                
                Console.WriteLine(Circle.CirPer(rr));
            }
        }

        static void Main(string[] args)
        {

            var chooseFigure = new Choose();
            chooseFigure.choose();

            Program wkn = new Program();
            wkn.SqArea();
            wkn.SqPeri();

            Program re = new Program();
            re.ReArea();
            re.rePem();
            

            Program RhomPer = new Program();
            RhomPer.RhomPer();
            RhomPer.RhomArea();

            Program Trp = new Program();
            Trp.TrapAr();
            Trp.TrapPer();
            
            Program Tri = new Program();
            Tri.TriArea();
            Tri.TriPer();

            Program cir = new Program();
            cir.cirArea();
            cir.cirPer();
        }
    }
}