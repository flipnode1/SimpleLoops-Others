using System;


namespace SoftUni_If
{
    class Program
    {
        static void Main()
        {
            var Score = int.Parse(Console.ReadLine());

            var BonusScore = 0.0;

            if (Score <= 100)
            {
                BonusScore += 5;
            }

            else if (Score <= 1000)
            {
                BonusScore += Score * 1.2;
            }

            else if (Score >1000)
            {
                BonusScore = Score * 1.1;
            }

            if (Score % 2 == 0)
            {
                BonusScore += 1;
            }

            else if (Score % 10 == 5)
            {
                BonusScore += 2;
            }

            Console.WriteLine(BonusScore);
            Console.WriteLine(Score + BonusScore);
        }
    }
}
