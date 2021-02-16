using System;
using System.Globalization;
namespace Uri1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor;
            int[] vetor1;
            vetor = new int[20];
            vetor1 = new int[20];
            int i, k, g;
            k = 0;
            g = 0;
            double s;
            i = 0;
            s = 0;

            for (int v = 0; v <= 41; v++)
            {
                if (v != 0 && v <= 40)
                {
                    if (v % 2 == 0)
                    {
                        vetor[g] = v;
                        g += 1;
                    }
                    else if (v % 2 != 0)
                    {
                        vetor1[k] = v;
                        k += 1;
                    }
                }
            }

            for (int c = 0; c < 20; c++)
            {
                if (i == 0)
                {
                    i = 1;
                    s = (double)1.0 + 3.0 / 2.0;
                }
                else if (c >= 2)
                {
                    s = (double)s + vetor1[c] / vetor[c];
                }
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
