using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointOnBorder
    {
    class isPointOnBorder

    {
        static void Main()
        {
            double x1 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            double x2 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());
            double x = int.Parse(Console.ReadLine());
            double y = int.Parse(Console.ReadLine());

            bool isOnRight = (x == x2) && y <= y2 && y >= y1;
            bool isOnLeft = (x == x1) && y <= y2 && y >= y1;
            bool isOnTop = (y == y1) && x >= x1 && x <= x2;
            bool isOnBottom = (y == y2) && x >= x1 && x <= x2;

            if(isOnRight || isOnLeft || isOnTop || isOnBottom)
            {
                Console.WriteLine("Border");
            }

            //if ((x == x2 || x == x1) && (y <= y2 && y >=y1) ||
            //    (y == y1 || y == y2) && (x >= x1 && x >= x2))
            //{
            //    Console.WriteLine("Border");
            //}

            //else
            //{
            //    Console.WriteLine("Inside/Outside");
            //}

        }
    }
}
