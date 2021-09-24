using System;

namespace Part4._1_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Guess a Number ---");

            Console.WriteLine("Pick a number from 1 to 10");

            bool isNumber = Int32.TryParse(Console.ReadLine(), out int guess);

            Random RandomNumber = new Random();
            int myRandomNumber = RandomNumber.Next(1, 10);

            string test = (myRandomNumber == guess) ? "true" : "false";

            if (isNumber)
            {
                do
                {
                    Console.WriteLine("You get one more try\nGuess again, 1 to 10!");
                    bool is2ndNumber = Int32.TryParse(Console.ReadLine(), out int nextguess);
                    test = (myRandomNumber == nextguess) ? "true" : "false";

                } while (test == "false");
                Console.WriteLine($"Great guess! {myRandomNumber} was correct!");
            }
            else
            {
                Console.WriteLine("Invaid Input: This is over");
            }

        }
    }
}
