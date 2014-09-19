using System;
    class ChecksDividedBy7and5
    {
        static void Main()
        {
            // Read the input number
            int inputNumber = int.Parse(Console.ReadLine());

            // Get the third bit (counting from 0)
            int mask = 0x8;
            Console.WriteLine(0 != (inputNumber & mask) ? 1 : 0);

             //int n = int.Parse(Console.ReadLine());
            //if (n % 7 == 0 && n % 5 == 0 )
            //Console.WriteLine("Division is possible!");
            //else
            //Console.WriteLine("Division is impossible!");
        }
    }

