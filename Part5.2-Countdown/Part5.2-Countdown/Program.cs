using System;

namespace Part5._2_Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Countdown ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            bool isNumber = false;
            int countby = 0;

            while (!isNumber)
            {
                Console.WriteLine("What number would you like to count down by?");
                isNumber = Int32.TryParse(Console.ReadLine(), out countby);
            }

            isNumber = false;
            int start = 0;

            while (!isNumber)
            {
                Console.WriteLine("What number would you like to start with?");
                isNumber = Int32.TryParse(Console.ReadLine(), out start);
            }

            while (countby <= start)
            {
                if (start % countby == 0)
                {
                    Console.WriteLine(start);
                }
                start--;
            }

        }
    }
}
