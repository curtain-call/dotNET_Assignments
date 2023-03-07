using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sys = true;
            while (sys)
            {
                int operandA;
                int.TryParse(Console.ReadLine(),out operandA);

                char operatorM;
                char.TryParse(Console.ReadLine(), out operatorM);

                int operandB;
                int.TryParse(Console.ReadLine(), out operandB);

                switch (operatorM)
                {
                    case '+':
                        Console.WriteLine("ANSWER");
                        Console.WriteLine(operandA + operandB);
                        Console.WriteLine("");
                        break;
                    case '-':
                        Console.WriteLine("ANSWER");
                        Console.WriteLine(operandA - operandB);
                        Console.WriteLine("");
                        break;
                    case '*':
                        Console.WriteLine("ANSWER");
                        Console.WriteLine(operandA * operandB);
                        Console.WriteLine("");
                        break;
                    case '/':
                        Console.WriteLine("ANSWER");
                        Console.WriteLine(operandA / operandB);
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Invalid Expression");
                        sys = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
