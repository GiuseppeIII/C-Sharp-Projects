using System;

namespace ConsoleCoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
						Random coin = new Random();
						int heads=0;
						int tails=0;
            Console.WriteLine("Welcome to the Console Coint Flip simulator! \nTo flip a coin press any key, to see this sessions stats press enter, to stop press escape.");
						while (true){
							System.ConsoleKey Key = Console.ReadKey().Key;
							if (Key == ConsoleKey.Enter){
								Console.WriteLine("There have been {0} heads and {1} tails!", heads, tails);
							}
							else if (Key == ConsoleKey.Escape){
								break;
							}
							else{
								int flip = coin.Next(0,2);
								if (flip==0){
									Console.WriteLine("\nYou got heads!");
									heads++;
								}
								else{
									Console.WriteLine("\nYou got tails!");
									tails++;
								}
							}
						}
        }
    }
}