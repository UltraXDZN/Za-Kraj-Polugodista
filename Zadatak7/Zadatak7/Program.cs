using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite duljinu niza: ");
            int duljinaNiza = int.Parse(Console.ReadLine());
            int[] niz = new int[duljinaNiza];
            for (int i=0; i<duljinaNiza; i++)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                niz[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(niz);
            Console.Write("\nSortirani niz je: ");
            foreach (int broj in niz)
            {
                Console.Write(broj + " ");
            }
            Console.ReadKey();
        }
    }
}
