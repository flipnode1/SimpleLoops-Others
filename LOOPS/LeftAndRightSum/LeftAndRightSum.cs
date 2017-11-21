using System;


namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()

        {
            //SOLUTION WITH 2 FOR LOOPS

            //int numbersToRead = int.Parse(Console.ReadLine());

            //int leftSum = 0;

            //for (int i = 0; i < numbersToRead; i++)
            //{
            //    int numberOne = int.Parse(Console.ReadLine());
            //    leftSum += numberOne;
            //}

            //int rightSum = 0;

            //for (int i = 0; i < numbersToRead; i++)
            //{
            //    int numberThree = int.Parse(Console.ReadLine());
            //    rightSum += numberThree;
            //}

            //if (leftSum == rightSum)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No " + Math.Abs(leftSum-rightSum));
            //}

            //SOLUTION WITH ONE FOR LOOP

            int numbersToRead = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int RightSum = 0;

            for (int i = 0; i < numbersToRead * 2; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (i < numbersToRead)
                {
                    leftSum += readNumber;
                }
                else
                {
                    RightSum += readNumber;
                }

            }

            if (leftSum == RightSum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No " + Math.Abs(leftSum - RightSum));
            }
        }
    }
}
