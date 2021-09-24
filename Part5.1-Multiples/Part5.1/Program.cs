using System;

namespace Part5._1
{
    class Program
    {
        /*1. Ask the user to provide input for what number they want to count by
          2. Ask the user to provide input for a number to count up to  (e.g. I wish to count by 3 up to 10)
          3. If a number was not entered,  use a loop to give an appropriate message and the opportunity to enter a number again
          4. Use the count by and the count up to numbers and output to the console each time they divide evenly 
          5. Compress and save the folder, and submit to Canvas*/

        static void Main(string[] args)
        {
            //puts the title in the middle of the console

            string title = "--- Multiples ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            bool isNumber = false;
            int countby = 0;

            while (!isNumber)       /*isNumber was set to false, while runs, 
                                    if number is input, isNumber = true, moves on,
                                    if letter, loops*/
            {
                Console.WriteLine("What number would you like to count by?");
                isNumber = Int32.TryParse(Console.ReadLine(), out countby);
            }

            isNumber = false;
            int upto = 0;

            while (!isNumber)
            {
                Console.WriteLine("What number would you like to count up to?");
                isNumber = Int32.TryParse(Console.ReadLine(), out upto);
            }

            for (int i = 1; i < upto; i++) //initialization, condition, operation
            {
                if (i % countby == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /*int counter = 1;

            while (counter < upto)
            {
                //want to see if it divides evenly, '% is modulus, looks at REMAINDER
                if (counter % countby == 0)
                {
                    Console.WriteLine(counter);
                }

                counter++;

                /*if 3/10, counter % countby adds (counter++) until R = 0, 
                outputs 3, loops (counter++), 6, etc 9),
                after 9, counter > upto*/
            }
        }
    }