using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Game
{
    static void Main()
    {
        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight = 27;
        Console.ForegroundColor = ConsoleColor.White;
        string figur = "***(0)***";
        int position = 36;
        int verticalPosition = 25;



        while (true)
        {
            Console.SetCursorPosition(position, verticalPosition);
            Console.Write(figur);
            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.LeftArrow)
            {
                if (position > 0)
                {
                    position--;
                }
            }
            else if (input.Key == ConsoleKey.RightArrow)
            {
                if (position < 70)
                {
                    position++;
                }

            }
            else if (input.Key == ConsoleKey.Escape)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nExit !");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;
            }

            Thread.Sleep(20);
            Console.Clear();

        }
    }

    private static void Rocks()
    {
        int vertical = 2;
        int horizontal = 0;
        Console.SetCursorPosition(vertical, horizontal);
        Console.WriteLine('$');

        Thread.Sleep(150);
        // Console.Clear();

    }
}