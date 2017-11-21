using System;


namespace FindSmallestNumber
{
    class FindMinNumber
    {
        static void Main()
        {
            int numbersToRead = int.Parse(Console.ReadLine());

            int smallestNumber = int.MaxValue;

            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (readNumber < smallestNumber)
                {
                    smallestNumber = readNumber;
                }

             }

            Console.WriteLine(smallestNumber);
        }
    }
}
