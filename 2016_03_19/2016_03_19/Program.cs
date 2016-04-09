using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_03_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string napis;
            int cos = 100;
            napis = "Hello world";
            System.String napis2;
            napis2 = "My first program on c#";
            Console.WriteLine(napis+ " " + cos);
            
           string txt = Console.ReadLine();*/

            /*int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("suma: {0} \niloczyn: {1}", y + x, y * x);
            if (x + y % 2 == 0)
                Console.WriteLine("suma jest przysta");
            else
                Console.WriteLine("suma jest nieparzysta");*/

            /* int a = int.Parse(Console.ReadLine());
             if (a<53)
             {
                 Console.WriteLine("liczba: {0}", a);
                 if (a >= 0)
                     Console.WriteLine("liczba nieujemna");
                 else
                     Console.WriteLine("liczba niedodatnia");*/

            double x, y, z;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            if (x == 0)
                Console.WriteLine("to nie jest rownanie kwadratowe");
            else
            {
                Console.WriteLine("rownianie ma postac:  {0}x^2 + {1}x + {2} = 0");
                double delta = 
            }
        }
    }
}
