using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeplitzMetrix
{
    class Program
    {
        bool isToeplitz(int m,int n, int[][] input)
        {
            //int i = m, j = 0;
            int temp,x,y;
            for(int i =0; i < m; i++)
            {
                temp = input[i][0];
                x = i;
                y = 0;
                while (x < m && y < n)
                {
                    if (input[x++][y++] != temp)
                        return false;
                }
            }
            for(int j = 0; j < n; j++)
            {
                temp = input[0][j];
                x = 0;
                y = j;
                while (x < m && y < n)
                {
                    if (input[x++][y++] != temp)
                        return false;
                }
            }
            return true;
        }


        static void Main(string[] args)
        {

        }
    }
}
