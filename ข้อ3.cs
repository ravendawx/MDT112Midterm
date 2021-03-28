using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true; //playerA
            bool B; //playerB
            Console.WriteLine("Input positive number of box in tank 1: ");
            int boxoftank1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input positive number of box in tank 2: ");
            int boxoftank2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input positive number of box in tank 3: ");
           int boxoftank3 = int.Parse(Console.ReadLine());
            bool Lastplayer = bool.Parse(Console.ReadLine());


           

            while (boxoftank1 > 0 && boxoftank2 > 0 && boxoftank3 > 0) 
            {
                Console.WriteLine("Pick tank : ");
                int tank = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick number of box : ");
                int box = int.Parse(Console.ReadLine());
                          

                

            }
            if (boxoftank1 == 0 || boxoftank2 == 0 || boxoftank3 == 0)
            {
                if (Lastplayer = A)
                {
                    Console.WriteLine("B is winener");
                }
                else
                    Console.WriteLine("A is winner");
            }
           

        }

    }
}
