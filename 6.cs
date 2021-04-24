using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Char input;
                input = Console.ReadLine()[0];
                int width;
                width = int.Parse(Console.ReadLine());
                int height;
                height = int.Parse(Console.ReadLine());
                int step;
                step = int.Parse(Console.ReadLine());

                for (int a = 0; a <= step; a++)
                {
                    for (int b = 0; b < height; b++)
                    {
                        for (int c = 0; c < width * a; c++)
                        {
                            Console.Write(input);
                        }
                        Console.WriteLine("n");
                    }
                }
            
        }
    }
}
