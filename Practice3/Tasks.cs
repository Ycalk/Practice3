using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    static class Tasks
    {
        public static void Task1 (int N)
        {
            int numLength = N.ToString().Length;
            for (int i = 0; i < numLength; i++)
            {
                Console.Write(N%10);
                N = N / 10;
            }
        }

        public static void Task2 (int N)
        {
            int counter = 0;
            for (int hundreds = 1; hundreds < 10; hundreds++)
            {
                for (int tens = 0; tens < 10; tens++)
                {
                    for (int units = 0; units < 10; units++)
                    {
                        if ((hundreds + tens + units) == N)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);         
        }

        public static void Task3 (int n)
        {
            int len = 0;
            int i = 0;
            while ( n > len + i * 9 * (int)Math.Pow(10, i - 1))
            {
                len += i * 9 * (int)Math.Pow(10, i - 1);
                i++;
            }
            int num = (int)Math.Pow(10, i - 1) + (n - len - 1) / i;
            int positionInsideNum = (n - len - 1) % i;

            char digit = num.ToString()[positionInsideNum];
            Console.WriteLine(digit);
        }

        public static void Task4(List<int> mas)
        {
            var longestMas = new List<int>();
            var subMas = new List<int> { mas[0] };

            for (int i = 1; i < mas.Count; i++)
            {
                if (mas[i] == subMas[subMas.Count - 1])
                {
                    subMas.Add(mas[i]);
                }
                else
                {
                    if (subMas.Count > longestMas.Count)
                    {
                        longestMas = new List<int>(subMas);
                    }
                    subMas = new List<int> { mas[i] };
                }
            }

            if (subMas.Count > longestMas.Count)
            {
                longestMas = new List<int>(subMas);
            }

            Console.WriteLine(longestMas.Count);
        }

        public static bool Task5(string brackets)
        {
            int count = 0;
            foreach (var bracket in brackets)
            {
                if (bracket == '(')
                {
                    count += 1;
                }
                else
                {
                    if (count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        count -= 1;
                    }  
                }
            }
            return count == 0;
        }
    }
}
