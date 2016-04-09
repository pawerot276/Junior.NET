using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_04_09
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tab = new int[30];
            Random R = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = R.Next(0, 100);
            }

            int u = 0;

            //wypiswanie
            foreach (var i in tab)
            {
                System.Console.WriteLine("Tablica[{0}]={1}", u, i);
                u++;
            }

            //max
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
            }
            Console.WriteLine("MAX={0}", max);

            //suma
            int suma = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma = suma + tab[i];
            }
            Console.WriteLine("suma={0}", suma);        

            int x = 72;
            int y = 48;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            Console.WriteLine("NWD={0}", x);


            sort(tab);

            //wypisz
            for (int i = 0; i < tab.Length; i++)
            {
                System.Console.WriteLine("Tablica[{0}]={1}", i, tab[i]);
            }

        }
        static void sort(int[] tab)
        {
            int x, j;
            for (int i = 1; i < tab.Length; i++)
            {
                x = tab[i];
                j = i - 1;
                while (j > 0 && x < tab[j])
                {
                    tab[j + 1] = tab[j];
                    j = j - 1;
                }
                tab[j + 1] = x;
            }
        }
    }
}
