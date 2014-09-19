using System;
class ChecksPointWithinCircleOutRectangle
{
    static void Main()
    {
        {
            Console.Write("Enter coordinate x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinate y= ");
            int y = int.Parse(Console.ReadLine());
            {
                if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9)
                {
                    Console.WriteLine("The point is in the circle");
                    if ((x < (-1)) || (x > 5))
                    {
                        Console.WriteLine("The point is outside the rectangle");
                    }
                    else
                        if (y > 1 || y < (-1))
                        {
                            Console.WriteLine("The point is outside the rectangle");
                        }
                        else
                            if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))
                            {
                                Console.WriteLine("The point is in the rectangle");
                            }

                }
                else
                {
                    Console.WriteLine("The point is outside the circle");
                    if ((x < (-1)) || (x > 5))
                    {
                        Console.WriteLine("The point is outside the rectangle");
                    }
                    else
                        if (y > 1 || y < (-1))
                        {
                            Console.WriteLine("The point is outside the rectangle");
                        }
                        else
                            if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))
                            {
                                Console.WriteLine("The point is in the rectangle");
                            }
                }
            }
        }
    }
}

    
        

            

        
    
