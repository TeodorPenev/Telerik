using System;
using System.Collections.Generic;

class Subset
{
    static void Main()
    {
        Console.Write("Define the set size: ");
        int setSize = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        for (int i = 0; i < setSize; i++) 
        {
            Console.WriteLine("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        List<int> sum = new List<int>();
        sum.Add(0);

        List<string> subset = new List<string>();
        subset.Add("Subset {");

        int length = sum.Count;

        foreach (var element in numbers) 
        {                                               
            for (int i = 0; i < length; i++)            
            {                                          
                sum.Add(sum[i] + element);              
                subset.Add(subset[i] + "  " + element); 
            }                                           
            length = sum.Count;                         
        }                                

        for (int i = 1; i < length; i++) 
        {                                                      
            if (sum[i] == 0)                                   
            {                                                  
                Console.Write("{0,-40} {1}", subset[i], "}");  
                Console.WriteLine("{0}{1}", " = ", sum[i]);    
            }                                                  
        }                                
    }
}
/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
Example: 3, -2, 1, 1, 8 пѓ  1+1-2=0.*/