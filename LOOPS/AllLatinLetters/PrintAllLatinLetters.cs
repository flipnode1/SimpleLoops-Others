using System;


namespace AllLatinLetters
{
    class PrintAllLatinLetters
    {
        static void Main()
        {

            //write a program that prints all lowecase latin letters
            // here we are going to use the Dec value of the Symbols, it can be fount in the ASCII table online
            //a = 97 , z = 122

            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }

        }
    }
}
