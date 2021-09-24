using System;

namespace HW2_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            double FTest;
            double BTest;
            Console.WriteLine("--- Fizz Buzz ---");
            //Prompt the user to input their lucky number.
            Console.WriteLine("Please type in your lucky number");
            //validate that the input is a valid number using Int32.TryParse
            bool isValid = Int32.TryParse(Console.ReadLine(), out Int32 luckynumber);
            if (isValid)
            {
                //If the input is valid, you are clear to start the FizzBuzz process.
                Console.WriteLine("You are clear to start the FizzBuzz process");
            }
            else
            {
                //If the input is not a valid number, output a message to the user stating that you are
                Console.WriteLine("Sorry but you are unable to run the FizzBuzz process due to the input not being a valid number.");
            }
            FTest = luckynumber / 3;
                string F = Convert.ToString(FTest);
            BTest = luckynumber / 5;
                string B = Convert.ToString(BTest);

            bool IfF = Int32.TryParse(F, out Int32 Fizz);
            bool IfB = Int32.TryParse(B, out Int32 Buzz);
            bool FB = IfF && IfB;

            if (FB)
            {
                Console.WriteLine($"{Buzz} FizzBuzz");
            }
            else if (IfF)
            {
                Console.WriteLine($"{luckynumber} Fizz");
            }
            else if (IfB)
            {
                Console.WriteLine($"{luckynumber} Buzz");
            }
            else
            {
                Console.WriteLine($"{luckynumber}");
            }
        }
    }
}
