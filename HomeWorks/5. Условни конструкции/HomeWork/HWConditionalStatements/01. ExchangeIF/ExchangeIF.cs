using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("First Number :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number :");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int tempA = a;
                a = b;
                b = tempA;
                Console.WriteLine("Exchange value of First Number is:\n{0} \nExchange value of Second Number is:\n{1}", a, b);
            }
        }
    }
/*Write an if statement that examines two integer variables and exchanges 
their values if the first one is greater than the second one.*/
