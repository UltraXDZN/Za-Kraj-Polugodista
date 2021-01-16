using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unsite broj: ");
            int n = int.Parse(Console.ReadLine());
            int zbroj = 0;
            for (int i=1; i<=n; i++)
            {
                zbroj += i;
            }
            Console.WriteLine($"Zbroj prvih n brojeva je {zbroj}.");
            Console.ReadKey();

            
        }
    }
}
