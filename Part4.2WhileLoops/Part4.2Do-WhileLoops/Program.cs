using System;

namespace Part4._2Do_WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Interest Calculator ---\n");

            Console.WriteLine("This program will give you your projected account balance\n");

            Console.WriteLine("What is your current balance >>>");
            bool isbalance = Double.TryParse(Console.ReadLine(), out double balance);

            Console.WriteLine("How many years will it be compounded >>>");
            bool isyears = Int32.TryParse(Console.ReadLine(), out Int32 years);

            Console.WriteLine("What is the interest rate >>>");
            bool isinterest = Double.TryParse(Console.ReadLine(), out double interestrate);

            if (isbalance & isyears & isinterest)
            {
                do
                {
                    string formbalance = balance.ToString("C2");
                    balance *= interestrate;
                    Console.WriteLine($"\nThe balance is {formbalance}\n");
                    years--;
                } while (years >= 0);
            }
            else Console.WriteLine("Invalid Input");

        }
    }
}
