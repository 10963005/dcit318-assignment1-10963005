using System;

namespace GradeCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            char GradeA = 'A';
            char GradeB = 'B';
            char GradeC = 'C';
            char GradeD = 'D';
            char GradeF = 'F';
            string YouGot = "You got an ";

            //Type Score 
            Console.WriteLine("Enter your score: ");
            double Score = Convert.ToDouble(Console.ReadLine());
            if (Score >= 90) {
                Console.WriteLine(YouGot + GradeA);
            }
            if (Score >= 80)
            {
                Console.WriteLine(YouGot + GradeB);
            }
            if (Score >= 70)
            {
                Console.WriteLine(YouGot + GradeC);
            }
            if (Score >= 60)
            {
                Console.WriteLine(YouGot + GradeD);
            }
            if (Score < 60)
            {
                Console.WriteLine(YouGot + GradeF);
            }
        }
    }
}
