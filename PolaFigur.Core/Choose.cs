using System;
namespace MyApplication
{
    public class Choose
    {
        
        public Choose()
        {    
        }



        public void choose()
        {
            
            Console.WriteLine("Obliczanie pola i obwodow figur: \n");
            Console.WriteLine("Kliknij 1 aby rozpocząć program: \n");
            Console.WriteLine("Kwadrat --- 1 figura\n");
            Console.WriteLine("prostokąt - 2 fiugra\n");
            Console.WriteLine("romb ------ 3 figura\n");
            Console.WriteLine("trapez ---- 4 figura\n");
            Console.WriteLine("trójkąt --- 5 figura\n");
            Console.WriteLine("koło ------ 6 figura\n");
            var litera = Console.ReadLine();
            double numericValue;
            bool isNumber = double.TryParse(litera, out numericValue);



            while (isNumber == false)
            {
                Console.WriteLine("Bład: Powtórz");
                litera = Console.ReadLine();
                isNumber = double.TryParse(litera, out numericValue);
                continue;
            }


            if (isNumber == true)
            {
                int figura = Convert.ToInt32(litera);

                while (figura < 1 && figura > 1)
                {
                    Console.WriteLine("\nnie ma takiej liczby\n");
                    Console.WriteLine("\npowtórz\n");
                    figura = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}

