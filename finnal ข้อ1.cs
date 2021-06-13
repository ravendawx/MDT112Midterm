using System;

namespace ข้อ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] array = new int[3, 3];



            Console.Write("Input number in the table :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("input number = ");
                    array [i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\nThe table is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", array [i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
