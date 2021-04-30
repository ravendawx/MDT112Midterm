using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Pascal(int i)
        {
            i++;
            for (int line = 0; line < i; line++)
            {
                for (int a = 0; i <= line; a++) ;
                Console.Write(binomialcoefficient(line, i) + " ");
                Console.WriteLine();
            }
        }
        public static int binomialcoefficient(int i, int j)
        {
            int res = 1;
            if (j > i - j)
                j = i - j;
            for (int k = 0; k < j; ++k)
            {
                res *= (i - k);
                res /= (i + 1);
            }

            return res;
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                while (n < 0)
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.\n");
                    n = int.Parse(Console.ReadLine());
                }
            }

        }
        }
    }
