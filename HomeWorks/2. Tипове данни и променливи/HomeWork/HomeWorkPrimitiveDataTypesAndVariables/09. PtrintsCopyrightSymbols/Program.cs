using System;

    class PtrintsCopyrightSymbols
    {
        static void Main()
        {
            char symbol = '\u00a9';
            Console.WriteLine(new String(' ', 3) + symbol);
            Console.WriteLine(new String(' ', 2) + symbol + new String(' ', 1) + symbol);
            Console.WriteLine(new String(' ', 1) + symbol + new String(' ', 3) + symbol);
            Console.WriteLine(" " + new String(symbol, 4));

        }
    }

