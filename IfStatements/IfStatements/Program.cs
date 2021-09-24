//G Escandor MIS 3013
using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- If Statements ---\n");

            Console.WriteLine("What are we counting today?");
            string item = Console.ReadLine();

            Console.WriteLine($"How many {item} do you have?");
            uint quantity = Convert.ToUInt32(Console.ReadLine());

            if (quantity == 0)
            {
                Console.WriteLine($"Where can we find some {item} to count?");
            }
            else if (quantity == 1) 
            {
                Console.WriteLine("One doesn't always have to be the loneliest number!");
            }
            else if (quantity == 2)
            {
                Console.WriteLine($"A pair of {item} is just right!");
                    }
            else if (quantity == 3)
            {
                Console.WriteLine($"Three's a party!");
                    }
            else 
            {
                Console.WriteLine($"That's a lot of {item}!");
                    }
            Console.ReadKey();
                   
        }
    }
}
