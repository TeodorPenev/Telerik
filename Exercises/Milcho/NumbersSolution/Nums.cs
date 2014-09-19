using System;

class Nums
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        string input = Console.ReadLine();
        bool isString = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]) || char.IsPunctuation(input[i]) || char.IsSymbol(input[i]))
            // проверка дали в стринга има буква, точка запетая .. или някакъв друг символ
            {
                isString = false;
                break;
            }
        }
        if (isString == true)
        {
            int number = int.Parse(input);
            Console.WriteLine("Your number is: {0}", number);
        }
        else if (isString == false)
        {
            Console.WriteLine("Not a number !");
        }

        // стойност true по подразбиране ако намери буква в input се променя на false , прекъсва цикъла 
        // и се прави проверка ако стойността na isString e true = не е число остава си стринг , а ако е false 
        // означава че в input няма букви и се парсва към int 
    }
}