using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            float broj = int.Parse(Console.ReadLine());
            Dictionary<string, bool> djeljivost = new Dictionary<string, bool>();
            djeljivost.Add("Broj je djeljiv s 4", broj % 4 == 0);
            djeljivost.Add("Broj je djeljiv s 6", broj % 6 == 0);
            djeljivost.Add("Broj je djeljiv sa 4 i sa 6", broj % 4 == 0 && broj % 6 == 0);
            djeljivost.Add("Broj nije djeljiv sa 4 ni sa 6", broj % 4 != 0 && broj % 6 != 0);
            foreach (var kv in djeljivost) if (kv.Value) Console.WriteLine(kv.Key);
            Console.ReadKey();
        }
    }
}
