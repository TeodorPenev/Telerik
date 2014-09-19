using System;
using System.Globalization;
using System.Threading;

class GreatestValue
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Value 1: ");
        double firstValue = double.Parse(Console.ReadLine());
        Console.Write("Value 2: ");
        double secondValue = double.Parse(Console.ReadLine());
        Console.Write("Value 3: ");
        double thirdValue = double.Parse(Console.ReadLine());
        Console.Write("Value 4: ");
        double fourthValue = double.Parse(Console.ReadLine());
        Console.Write("Value 5: ");
        double fifthValue = double.Parse(Console.ReadLine());

        double currentGreatestValue = firstValue;
        int maxIndex = 0;
        for (int index = 1; index < 5; index++)
        {
            if (secondValue > currentGreatestValue)
            {
                currentGreatestValue = secondValue;
                maxIndex = index;
            }
            else if (thirdValue > currentGreatestValue)
            {
                currentGreatestValue = thirdValue;
                maxIndex = index;
            }
            else if (fourthValue > currentGreatestValue)
            {
                currentGreatestValue = fourthValue;
                maxIndex = index;
            }
            else if (fifthValue > currentGreatestValue)
            {
                currentGreatestValue = fifthValue;
                maxIndex = index;
            }
        }

        Console.WriteLine("Greatest value is: {0} on index {1}", currentGreatestValue, maxIndex + 1);

        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //double[] array = new double[5];
        //double maxIndex = 0;

        //// записваме стойностите в масива 
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write("Value {0}: ", i + 1);
        //    array[i] = double.Parse(Console.ReadLine());
        //}

        //// търсим най - голямата стойност
        //double maxValue = array[0]; // приемаме като за начало, че най-голямата стойност е първата стойност на индекс 0 
        //for (int i = 1; i < 5; i++) // започваме да сравняваме от индекс 1
        //{
        //    if (array[i] > maxValue)
        //    {
        //        maxValue = array[i];
        //        maxIndex = i;
        //    }
        //}
        //Console.WriteLine("Greatest value is: {0} on index {1}", maxValue, maxIndex + 1);
    }
}

// Write a program that finds the greatest of given 5 variables.