using System;
class AreaOfRectangle
    {
        static void Main()
    {
        Console.WriteLine("Write Rectangle Widthin in inches:");
            string str1 = Console.ReadLine();
        Console.WriteLine("Write Rectangle Height in inches:");  
            string str2 = Console.ReadLine();
            int width = int.Parse(str1);
            int height = int.Parse(str2);
            int recArea = width * height;
        Console.WriteLine("Rectangle area is:\n{0} inches  ",recArea);
        }
    }

