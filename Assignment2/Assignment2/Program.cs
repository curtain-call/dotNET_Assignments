using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        List<int> PrimeFactorize(int input)
        {
            System.Diagnostics.Debug.Assert(input > 0);
            if (input == 1)
            {
                Console.WriteLine("NO RESULT");
                return null;
            }
            
            if(input == 1) { }
            List<int> a = new List<int>();
            for (int pri = 2; pri < input; pri++)
            {
                while (input % pri == 0 && pri != input)
                {
                    a.Add(pri);
                    input /= pri;
                }
            }
            a.Add(input);
            return a;
        }

        static void Main(string[] args)
        {
            int input;
            int.TryParse(Console.ReadLine(),out input);
            Program res = new Program();
            List<int> result = res.PrimeFactorize(input);

            if(result != null)
                foreach(int i in result)
                {
                     Console.WriteLine(i);
                }

            Console.ReadKey();
        }
    }
}
