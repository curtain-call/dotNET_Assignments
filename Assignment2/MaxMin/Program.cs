using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        int getMax(int[] input)
        {
            int result = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (result < input[i])
                    result = input[i];
            }
            return result;
        }

        int getMin(int[] input)
        {
            int result = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (result > input[i])
                    result = input[i];
            }
            return result;
        }

        int getAverage(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
            }
            return result / input.Length;
        }

        int getSum(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result += input[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
