using System;
class SignOfTheProduct
{
    static void Main()
    {

        int[] n = { 10, 5, 0 };
        int sign = 1;

        foreach (int x in n)
        {
            sign *= x < 0 ? -1 : x > 0 ? 1 : 0;
            Console.WriteLine(sign);

        }
    }
}
/*Write a program that shows the sign (+ or -) of the product of 
three real numbers without calculating it. Use a sequence of if statements.*/
 
          
            
        
    

