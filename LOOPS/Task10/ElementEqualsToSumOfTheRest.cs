using System;


namespace Task10
{
    class ElementEqualsToSumOfTheRest
    {
        static void Main()

        {
            int numbersToRead = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;

            int sumAllNumbers = 0;

            for (int i = 0; i < numbersToRead; i++)

            {
                int readNumber = int.Parse(Console.ReadLine());
                sumAllNumbers += readNumber;

                if (readNumber > biggestNumber)
                {
                    biggestNumber = readNumber;
                }

            }

            int sumOfTheRest = sumAllNumbers - biggestNumber;

            if (biggestNumber == sumOfTheRest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                int difference = Math.Abs(biggestNumber - sumOfTheRest);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
                 
            }

           
        }
    }
}
