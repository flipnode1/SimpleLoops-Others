using System;


namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (ticketType == "Normal")
            {
                price = 7.50;
                Console.WriteLine("{0:f2} leva", ((row * column) * price));
            }else if (ticketType == "Premiere")
            {
                price = 12.00;
                Console.WriteLine("{0:f2} leva", ((row * column) * price));
            }else if (ticketType == "Discount")
            {
                price = 5.00;
                Console.WriteLine("{0:f2} leva", ((row * column) * price));
            }
        }
    }
}
