using System;


namespace FindBiggestNumbner
{
    class FindBiggestNumber
    {
        static void Main()

        {
            // !!!!! PONEJE ZAPOCHVAME OT 0, NASHATA PROGRAMA NQMA DA RABOTI S OTRICATELNI CHISLA!!!-- Tova mojem da go izbegnem, kato nakarame numbersToRead
            // da prieme nai- malkata stoinost za tipa int.-> int.MinValue
            //numbersToRead- kolko chisla shte budat vuvedeni ot potrebitelq
            //biggestNumber = 0 - prosto inicializirame promenlivata, koqto shte polzvame vuv for loop
            //readNumber- chislata se vuvejdat ot potrebitelq, dokato ne vuvede numbersToRead broi chisla
            //sled tova pravim proverka, dali biggestNumber (purvonachalno 0) e po malko ot readNumber, i ako e, to priema negovata stoinost!!!


            int numbersToRead = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;

            for (int i = 0; i < numbersToRead; i++)
            {
                int readNumber = int.Parse(Console.ReadLine());

                if (readNumber > biggestNumber)
                {
                    biggestNumber = readNumber;
                }

            }

            Console.WriteLine(biggestNumber);
        }
       
    }
}
