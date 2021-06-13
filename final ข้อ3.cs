using System;

namespace ข้อ3
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal number = 0M;
			bool valid = false;
			while (!valid)
			{
				Console.WriteLine("Enter a number");
				string inputnum = Console.ReadLine();
				if (decimal.TryParse(inputnum, out number))
				{
					number = Math.Round(number, 2);
					valid = true;
				}
				else
				{
					Console.WriteLine("End");
				}
			}
			string type;
			Console.WriteLine("What do you want to find: ");
			type = Console.ReadLine();

			if (type == "FindMax")
            {
				Console.WriteLine("The highest number is {0}");
			}


		}
	}
}
