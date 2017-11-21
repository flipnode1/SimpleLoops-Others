using System;

namespace OddEvenPositions
{
    class OddEvenPosition
    {

        static void Main()

        //Дадени са 2*n-на брой числа. Първото и второто формират двойка, третото и четвъртото също и т.н. 
        //Всяка двойка има стойност – сумата от съставящите я числа. Напишете програма, която проверява дали 
        //всички двойки имат еднаква стойност или печата максималната разлика между две последователни двойки. 
        //Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value={Value}" + стойността.
        //В противен случай отпечатайте "No, maxdiff={Difference}" + максималната разлика. 
        {
            double n = double.Parse(Console.ReadLine());

            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;

            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;

            for (int i = 1; i <= n; i++)
            {

                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                     if (num < evenMin)
                    {
                        evenMin = num; 
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                   
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    
                }

            }

            if (n == 0)
            {
                Console.WriteLine("OddSum = 0, OddMin = No, OddMax = No, EvenSum = 0, EvenMin = No, EvenMax = No");
            }else if (n == 1)
            {
                Console.WriteLine($"OddSum = {oddSum}, OddMin = {oddMin}, OddMax = {oddMax}, EvenSum = 0, EvenMin = No, EvenMax = No");
            }
            else
            {
                Console.WriteLine($"OddSum = {oddSum}, OddMin = {oddMin}, OddMax = {oddMax}, EvenSum = {evenSum}, EvenMin = {evenMin}, EvenMax = {evenMax}");
            }

            
        }
    }
}
