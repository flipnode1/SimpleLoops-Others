using System;


namespace MockExamTaks1BalancedNumbers
{
    class Startup
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int firstDig = (num / 100) % 10;
            int secondDig = (num / 10) % 10;
            int thirdDig = num % 10;

            while (firstDig + thirdDig == secondDig)
            {
                Console.WriteLine(num);
                continue;
            }
            Console.WriteLine(num);


            
          
            

            //int firsDigit = Math.Abs(number);
            //while (number >= 10)
            //{
            //    number /= 10;
            //}
            //Console.WriteLine(number);

            //int lastDigit = number % 10;


            
        }
    }
}
