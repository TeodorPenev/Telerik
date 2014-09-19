using System;
    class ChecksIsPointInTheCircle
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int radiusK = 5;
            if ((x * y) + (x * y) > (radiusK + radiusK))
            {
                Console.WriteLine("The point is out!");
            }
            else
            {
                Console.WriteLine("The Point is within!");
            }
        }
    }

