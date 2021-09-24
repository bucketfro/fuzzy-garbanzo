//G Escandor MIS 3013
using System;

namespace HW2
{
    class Program
    {
        //Ask for percent grade in Acc't, Mkt, Econ, MIS Courses
        //Output letter grade for each
        //Output GPA using formula given

        static void Main(string[] args)
        {
            Console.WriteLine("-- GPA --");
            string AcctL;
            double AcctGPV;
            string EconL;
            double EconGPV;
            string MktL;
            double MktGPV;
            string ProgL;
            double ProgGPV;
            double GPA;
            double CH = 3;

            Console.WriteLine("Please enter your overall percent grade in Accounting");
            int AcctP = Convert.ToInt32(Console.ReadLine());
            if (AcctP >= 90)
            {
                AcctL = "A";
                AcctGPV = 4.00;
            }
            else if (AcctP >= 80 && AcctP < 90)
            {
                AcctL = "B";
                AcctGPV = 3.00;
            }
            else if (AcctP >= 70 && AcctP < 80)
            {
                AcctL = "C";
                AcctGPV = 2.00;
            }
            else if (AcctP >= 60 && AcctP < 70)
            {
                AcctL = "D";
                AcctGPV = 1.00;
            }
            else
            {
                AcctL = "F";
                AcctGPV = 1.00;
            }
           
            Console.WriteLine("Please enter your overall percent grade in Marketing");
            int MktP = Convert.ToInt32(Console.ReadLine());
            if (MktP >= 90)
            {
                MktL = "A";
                MktGPV = 4.00;
            }
            else if (MktP >= 80 && MktP < 90)
            {
                MktL = "B";
                MktGPV = 3.00;
            }
            else if (MktP >= 70 && MktP < 80)
            {
                MktL = "C";
                MktGPV = 2.00;
            }
            else if (MktP >= 60 && MktP < 70)
            {
                MktL = "D";
                MktGPV = 1.00;
            }
            else
            {
                MktL = "F";
                MktGPV = 0;
            }
            Console.WriteLine("Please enter your overall percent grade in Economics");
            int EconP = Convert.ToInt32(Console.ReadLine());
            if (EconP >= 90)
            {
                EconL = "A";
                EconGPV = 4.00;
            }
            else if (EconP >= 80 && EconP < 90)
            {
                EconL = "B";
                EconGPV = 3.00;
            }
            else if (EconP >= 70 && EconP < 80)
            {
                EconL = "C";
                EconGPV = 2.00;
            }
            else if (EconP >= 60 && EconP < 70)
            {
                EconL = "D";
                EconGPV = 1.00;
            }
            else
            {
                EconL = "F";
                EconGPV = 00;
            }
            Console.WriteLine("Please enter your overall percent grade in Intro to Programming");
            int ProgP = Convert.ToInt32(Console.ReadLine());
            if (ProgP >= 90)
            {
                ProgL = "A";
                ProgGPV = 4.00;
            }
            else if (ProgP >= 80 && ProgP < 90)
            {
                ProgL = "B";
                ProgGPV = 3.00;
            }
            else if (ProgP >= 70 && ProgP < 80)
            {
                ProgL = "C";
                ProgGPV = 2.00;
            }
            else if (ProgP >= 60 && ProgP < 70)
            {
                ProgL = "D";
                ProgGPV = 1.00;
            }
            else
            {
                ProgL = "F";
                ProgGPV = 00;
            }

            GPA = (AcctGPV * CH + EconGPV * CH + MktGPV * CH + ProgGPV * CH) / (CH * 4);
            string FGPA = GPA.ToString("N2");

            Console.WriteLine($"Your letter grade in Accounting is {AcctL}");
            Console.WriteLine($"Your letter grade in Marketing is {MktL}");
            Console.WriteLine($"Your letter grade in Economics is {EconL}");
            Console.WriteLine($"Your letter grade in Intro to Programming is {ProgL}");
            Console.WriteLine($"Your overall GPA is {FGPA}");

        }
    }
}
