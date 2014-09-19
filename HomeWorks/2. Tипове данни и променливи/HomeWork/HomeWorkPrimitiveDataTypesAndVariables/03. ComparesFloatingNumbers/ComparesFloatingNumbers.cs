using System;
    class ComparesFloatingNumbers
    {
        static void Main()
        {
            float n1 = 5.00000001f;
            float n2 = 5.00000003f;
            bool compare = (n1 == n2);
            Console.WriteLine(compare);
        }
    }

