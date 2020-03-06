using System;

namespace eToNth
{
    class Program
    {
        static void Main(string[] args)
        {
            const double e = Math.E;
            string digits;
            bool goodInput = true;
            bool goAgain = false;

            do
            {
                //test input
                do
                {
                    goodInput = true;
                    Console.WriteLine("How many digits of e do you want to see? [1, 15]");
                    digits = Console.ReadLine();
                    try
                    {
                        Convert.ToInt16(digits);
                        if (Convert.ToInt16(digits) < 1 || Convert.ToInt16(digits) > 15)
                        {
                            Console.WriteLine("Please enter an integer value between 1 and 15");
                            goodInput = false;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter an integer value between 1 and 15");
                        goodInput = false;
                    }
                } while (goodInput == false);

                //give result
                Console.WriteLine(Math.Round(e, Convert.ToInt16(digits) - 1));

                //go again?
                Console.WriteLine("Do you want to go again? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    goAgain = true;
                }
                else 
                {
                    goAgain = false;
                }
            } while (goAgain == true);

        }
    }
}
