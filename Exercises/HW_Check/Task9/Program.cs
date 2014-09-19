sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int member = 2;
            
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(member + i);
                }
                else
                {
                    Console.WriteLine(-(member + i));
                }

            }
        }
    }
}
