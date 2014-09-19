using System;
    class StringObjectDeclare
    {
        static void Main()
        {
            string test1 = "Hello";
            string test2 = "World";
            object assign = test1 +" "+ test2;
            string test3 = (string)assign;
        }
    }

