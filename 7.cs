using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("day = ");
            day = int.Parse(Console.ReadLine());
            day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;

            int time;
            Console.WriteLine("time = ");
            time = int.Parse(Console.ReadLine());

            
            string[] menu = new string[] { "Breakfast Set", "Weekend Set", "Coffee" };
            Console.WriteLine("menu = ");
            string Menu = Console.ReadLine();
            foreach()

            



        }
    }
}
