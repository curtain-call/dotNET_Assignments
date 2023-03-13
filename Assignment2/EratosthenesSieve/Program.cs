using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EratosthenesSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);

            //int bound = (int)Math.Sqrt(n);
            int[] seq = new int[n];

            for (int i = 2; i < n; i++)
            {
                seq[i] = i;
            }

            for (int i = 2;i*i < n; i++)
            {
                if (seq[i] != 0)
                {
                    for (int j = i * 2; j < n; j += i)
                        seq[j] = 0;
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (seq[i] != 0)
                    Console.WriteLine(seq[i]);
            }
            Console.ReadKey();
        }
    }
}
