using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_csharp
{
    internal class task5
    {
        public static void func_task5(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression using only + and - operators:");
            string input = Console.ReadLine();

        int result = CalculateExpression(input);

        Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

    static int CalculateExpression(string input)
    {
        int result = 0;
        int sign = 1;
        bool newTerm = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '+')
            {
                sign = 1;
                newTerm = true;
            }
            else if (input[i] == '-')
            {
                sign = -1;
                newTerm = true;
            }
            else if (char.IsDigit(input[i]))
            {
                int start = i;
                while (i < input.Length && char.IsDigit(input[i]))
                {
                    i++;
                }
                int term = int.Parse(input.Substring(start, i - start));
                result += sign * term;
                newTerm = false;
                i--;
            }
            else if (input[i] != ' ')
            {
                throw new Exception("Invalid character in input: " + input[i]);
            }
        }

        if (newTerm)
        {
            throw new Exception("Invalid expression: ends with an operator");
        }

        return result;
    }
}
}
