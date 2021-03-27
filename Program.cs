using System;

namespace midterm
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

            
            if (x == y)
            {
                Console.WriteLine("least common multiple is {0}", x);
            }
            else
            {
                if (x < y)
                {
                    x = x + a;
                    Console.WriteLine("least common multiple is {0}", x);
                }
            
                else 
                {
                    y = y + b;
                    Console.WriteLine("least common multiple is {0}", y);
                }
            }
            }

        }
    }

