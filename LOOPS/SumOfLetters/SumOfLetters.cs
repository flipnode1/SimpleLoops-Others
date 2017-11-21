using System;


namespace SumOfLetters
{
    class SumOfLetters
    {
        static void Main()

        {
            //Sumirane na GLASNI bukvi

            string text = Console.ReadLine();

            var sum = 0;

            for (int index = 0; index <= text.Length - 1; index++)
            {
                char symbol = text[index];

                switch (symbol)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                    default:
                        break;
                }
                
            }
            Console.WriteLine(sum);

        }
    }
}
