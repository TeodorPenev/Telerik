using System;

class IntDoubleStringInput
{
    static void Main()
    {
        Console.WriteLine("int (1), double (2), string (3)");
        Console.Write(": ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter integer number: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 2:
                Console.Write("Enter double number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Enter string: ");
                string text = Console.ReadLine();
                text += '*';
                Console.WriteLine(text);
                break;
            default:
                break;
        }
    }
}

//Write a program that, depending on the user's 
//choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. 
//If the variable is string, appends "*" at its end. 
//The program must show the value of that variable as a console output. Use switch statement.