using System;
using System.Linq;

namespace currencyConversion
{
	class Program
	{
		public static void Main()
		{
			double x = 0;
			double y = 0;
			double z = 0;



			Console.WriteLine("Hello! I'm here to add up some currency for you!" +
				"\nJust type in an amount and hit enter, I will do 3 for you! (Numbers only please!)");

			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);
			double.TryParse(Console.ReadLine(), out z);

			double avg = (x + y + z) / 3;
			Console.WriteLine("\n\nSo your average of those three numbers will come up to " + avg);

			double[] numbers = new[] { x, y, z };

			double lowest = numbers.Min();
			double highest = numbers.Max();

			Console.WriteLine("\nYour highest is " + highest + 
								"\nYour lowest is " + lowest);

			double total = (x + y + z);

			double jpnTotal = Math.Round((double)total, 0);
			double usdTotal = Math.Round((double)total, 2);
			double sekTotal = Math.Round((double)total, 2);
			double bahtTotal = Math.Round((double)total, 2);

			Console.WriteLine("\n\nYour totals will show up below. " +
				
				"\n¥ " + jpnTotal +
				"\n$ " + usdTotal +
				"\n" + sekTotal + " kr" +
				"\n฿ " + bahtTotal);



			
			Console.WriteLine("\n\nThank you for using my program! Have a great day!");

			Console.ReadKey();

		}
	}
}
