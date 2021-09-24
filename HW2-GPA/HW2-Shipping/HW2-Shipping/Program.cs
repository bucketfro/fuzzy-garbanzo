using System;

namespace HW2_Shipping
{
    class Program
    {
        /*we need to know the total weight in pounds, distance in miles and whether or not there are hazardous materials
        Quote = .55 * # of miles + .73 * # of pounds 
        If there is hazardous materials in the shipment, there is an extra cost of .15* # of pounds  
        If the distance is less than 150 miles and the total weight is greater than 500 pounds
            10% discount off of the total quote.

        Note: The hazardous upcharge should be calculated before the discount.*/

        static void Main(string[] args)
        {
            double HazC;

            Console.WriteLine("--- Shipping ---");

            Console.WriteLine("What is the weight (lbs) of the shipment?");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("What is the distance (mi) of the shipment?");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Are there hazardous materials? Y or N?");
            string Answer = Console.ReadLine();
            if (Answer == "Y")
            {
                HazC = 0.15;
            }
            else if (Answer == "N")
            {
                HazC = 1;
            }
            else
            {
                Console.WriteLine("Please enter Y or N.");
                HazC = 0;
            }

            double Quote = 0.55 * distance + 0.73 * weight;
                string FQuote = Quote.ToString("C2");  

            double ExQuote = 0.55 * distance + 0.73 * weight * HazC;
                string FExQuote = Quote.ToString("C2");

            string TQuote = ExQuote.ToString("C2");

            if (weight > 500 && distance < 150)
            {
                double disQuote = ExQuote * 0.90;
                string FdisQuote = disQuote.ToString("C2");
                Console.WriteLine($"Your original Quote was {FQuote}");
                Console.WriteLine($"Your cost after hazardous materials is {FExQuote}");
                Console.WriteLine($"Your final quote after discounts is {FdisQuote}");
            }
            else
            {
                Console.WriteLine($"Your original Quote was {FQuote}");
                Console.WriteLine($"Your cost after hazardous materials is {FExQuote}");
            }
        }
    }
}
