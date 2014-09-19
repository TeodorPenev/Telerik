using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class CoffeeVendingMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] arr = new int[5];
        double[] coins = { 0.05, 0.10, 0.20, 0.50, 1.00 };
        double sumOfCoins = 0;
        double amount = 0;
        double price = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sumOfCoins += arr[i] * coins[i];
        }

        amount = double.Parse(Console.ReadLine());
        price = double.Parse(Console.ReadLine());


        double secondSum = sumOfCoins + price;

        double result = 0;
        if (price < amount)
        {
            if (price < amount && price < secondSum)
            {
                result = amount - secondSum;
                Console.WriteLine("No {0:F2}", result);
            }
            else if (price < amount )
            {
                double sum = sumOfCoins + price;
                result = sum - amount;
                Console.WriteLine("Yes {0:F2}", result);
            }
            
        }
        else if (price > amount)
        {
            result = price - amount;
            Console.WriteLine("More {0:F2}", result);
        }

    }
    /*
    4
    5
    4
    2
    1
    10.00
    2.00
    */
}