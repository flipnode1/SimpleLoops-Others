using System;


namespace Volleyball
{
    class Volley
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int praznik = int.Parse(Console.ReadLine());
            int homeWeekend = int.Parse(Console.ReadLine());

            double playsInSofia = (48 - homeWeekend) * (3.0 / 4);
            double playsAtHome = homeWeekend;
            double playsOnHolidays = praznik * (2.0 / 3);

            double allGames = playsAtHome + playsInSofia + playsOnHolidays;

            if (year == "leap")
            {
                allGames += allGames * 0.15;
            }

            Console.WriteLine(Math.Truncate(allGames));
        }
    }
}
