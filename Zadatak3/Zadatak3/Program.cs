using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 39; i++)
            {
                for (int j = 1; j <= 39; j++)
                {
                    if (i == j) continue;
                    for (int k = 1; k <= 39; k++)
                    {
                        if (j == k || k == i) continue;
                        for (int l = 1; l <= 39; l++)
                        {
                            if (k == l || l == j || l == i) continue;
                            for (int m = 1; m <= 39; m++)
                            {
                                if (m == l || m == j || m == k || m == i) continue;
                                for (int n = 1; n <= 39; n++)
                                {
                                    if (m == n || n == l || n == k || n == j || n == i) continue;
                                    for (int o = 1; o <= 39; o++)
                                    {
                                        if (n == o || n == m || n == l || n == k || n == j || n == i) continue;
                                        Console.WriteLine($"{i} {j} {k} {l} {m} {n} {o}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
