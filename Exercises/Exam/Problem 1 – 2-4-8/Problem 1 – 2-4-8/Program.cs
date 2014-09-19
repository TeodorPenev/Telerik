using System;
namespace Problem_1___2_4_8
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            if (B==2)
            {
                s1 = A % C; 
            }
            else if (B==4)
            {
                s2 = A + C; 
            }
            else if (B==8)
	        {
                s3 = A * C;
	        }
            double R = (s1 + s2 + s3);
            if (R%4==0)
            {
                Console.WriteLine(R / 4);
                Console.WriteLine(R);
            }
            else if (R%4<4)
            {
                Console.WriteLine(R%4);
                Console.WriteLine(R);
            }
            else 
            {
                double remainder = R % 4;
                double findDev = 4 / remainder;
                Console.WriteLine(findDev);
                Console.WriteLine(R);
            }
        }

    }
}
