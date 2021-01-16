using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = new int[5];
            int zbroj;
            double prosjek;

            KlasaC instancaObjekta = new KlasaC();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                brojevi[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();
            zbroj = instancaObjekta.Zbroj(brojevi);
            prosjek = instancaObjekta.Prosjek(brojevi);
            Console.WriteLine($"Zbroj brojeva: {zbroj}");
            Console.WriteLine($"Prosjek brojeva: {prosjek}");
            Console.ReadKey();

        }
    }

    class KlasaC
    {
        public int Zbroj(int[] brojevi)
        {
            int zbroj = 0;
            foreach (int broj in brojevi) zbroj += broj;
            return zbroj;
        }

        public double Prosjek(int[] brojevi)
        {
            return (double)Zbroj(brojevi) / (double)brojevi.Length;
        }
    }
}
