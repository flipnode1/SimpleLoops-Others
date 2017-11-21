using System;


namespace AddingSeconds
{
    class SumofSeconds

    {
        static void Main()
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var total = sec1 + sec2 + sec3;

            var minutes = total / 60;

            var sec = total % 60;
            if (sec < 10)
            { Console.WriteLine(minutes + ":0" + sec); }
            else
            {
                Console.WriteLine(minutes + ":" + sec);
            }
        
        }
    }
}
