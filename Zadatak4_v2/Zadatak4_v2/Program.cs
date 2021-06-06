using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tenisac> tenisaci = new List<Tenisac>();

            for (int sifraTenisaca = 1; sifraTenisaca < 33; sifraTenisaca++)
            {
                tenisaci.Add(new Tenisac(sifraTenisaca, $"Tenisac_{sifraTenisaca}"));
            }

            Randomize<Tenisac>(tenisaci);

            for (int i = 1; i < tenisaci.Count + 1; i++)
            {
                Console.WriteLine($"{tenisaci[i - 1].Naziv}");
                if (i % 2 == 0)
                {
                    Console.WriteLine("--------------------");
                    continue;
                }
                Console.WriteLine("\tvs.");
            }
            Console.ReadKey();

        }

        public static void Randomize<T>(List<T> items)
        {
            Random rand = new Random();

            for (int i = 0; i < items.Count - 1; i++)
            {
                int j = rand.Next(i, items.Count);
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }
    }

    class Tenisac
    {
        int ID;
        string naziv;
        public string Naziv { get; set; }

        public Tenisac(int id, string naziv_tenisaca)
        {
            ID = id;
            Naziv = naziv_tenisaca;
        }
    }
}
