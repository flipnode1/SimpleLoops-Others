using System;


namespace AddingNumbers
{
    class AddingNumbers
    {
        static void Main()
        {

            //User eneters 'n'- how many numbers to be added => if n = 2, the next two numbers entered in console will be added together without n
                        
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                sum += readNumber;
            }

            Console.WriteLine(sum);
        }
        
    }
}
