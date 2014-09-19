using System;
using System.Text;
    class ASCIITable
    {
        static void Main()
        {
          
            for (byte i = 0; i < 255; i++)
            {
                Console.WriteLine(i + " " + (char)i);
            }
        }
    }

