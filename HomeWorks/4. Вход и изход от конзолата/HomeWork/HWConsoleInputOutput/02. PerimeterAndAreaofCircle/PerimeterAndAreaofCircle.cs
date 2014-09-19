using System;
class PerimeterAndAreaofCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter the radius:");
            double r = double.Parse(Console.ReadLine());
            double p = Math.PI;
            double perimeter;
            double area;
            Console.WriteLine("The perimeter of a circle is:\n{0:0.000}",perimeter=2*p*r);
            Console.WriteLine("The area of a circle is:\n{0:0.000)",area=p*r*r);
        }
    }

