using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Input a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b = ");
            b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            while (x != y)
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            if (x == y)
            {
                Console.WriteLine("least common multiple is {0}",x);
            }
            else
            {
                Console.WriteLine("least common multiple is {0}", x);
            }
        }
    }
}
