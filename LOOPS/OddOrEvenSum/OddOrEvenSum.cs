using System;

namespace OddOrEvenSum
{
    class OddOrEvenSum
    {
        static void Main()

        {   //MOETO GRESHNO RESHENIE
            //int numbersToRead = int.Parse(Console.ReadLine());

            //int evenSum = 0;
            //int oddSum = 0;

            //for (int i = 0; i < numbersToRead; i++)
            //{
            //    int readNumber = int.Parse(Console.ReadLine());

            //    if (i % 2 == 0)
            //    {
            //        evenSum += readNumber;
            //    }
            //    else
            //    {
            //        oddSum += readNumber;
            //    }
            // DO TUK E PRAVILNO!

            //    if (evenSum == oddSum)
            //    {
            //        Console.WriteLine($"Yes, sum = {evenSum}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No " + (Math.Abs(evenSum - oddSum)));
            //    }
            //}


            //PRAVILNO RESHENIE::

            int numbersToRead = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += readNumber;
                }
                else
                {
                    oddSum += readNumber;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes, sum = {evenSum}");
            }
            else
            {
                int difference = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
