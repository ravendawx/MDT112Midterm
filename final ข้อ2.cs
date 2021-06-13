using System;

namespace ข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            string user1;
            string user2;
            string user3;
            string user4;


            Console.Write("Username: ");
            user1 = Console.ReadLine();
            int[] inputValues;
            string prompt = $"Please enter multiple integers (1, 2, 3): ";
            Console.Write(prompt);
            while (!TryParseIntegerList(Console.ReadLine(), out inputValues))
            {

                Console.Write(prompt);
            }

        }
        public static bool TryParseIntegerList(string input, out int[] inputValues)
        {
            inputValues = default;
            string[] splits = input.Split(",");
            int[] result = new int[splits.Length];
            for (int i = 0; i < splits.Length; i++)
            {
                if (!int.TryParse(splits[i].Trim(), out result[i]))
                {
                    return false;
                }
            }
            inputValues = result;
            return true;
        }
        

    }
}


