using System;
/*Write a program that reads the coefficients a, b and c of a quadratic 
equation ax2+bx+c=0 and solves it (prints its real roots).*/
class SolveQuadraticEquation
{
    static void Main()
    {
        double x, x1, x2;
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("This isn't a quadratic equation, \"a\" can't be 0.");
        }
        else
        {
            double discriminant = b * b - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            if (discriminant == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine("The equation has one real root: {x}", x);
            }
            if (discriminant > 0)
            {
                x1 = ((-b) + Math.Sqrt(discriminant)) / 2 * a;
                x2 = ((-b) - Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine("The equation has 2 real roots: x1 = {0}, x2 = {1}", x1, x2);
            }
        }
    }
}

