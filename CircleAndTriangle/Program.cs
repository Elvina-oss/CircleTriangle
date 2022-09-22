using System;
using Figures;
namespace CircleAndTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);
            Console.WriteLine("площадь круга  = " + circle.area());
            Triangle triangle = new Triangle(3, 5, 4);
            Console.WriteLine("площадь  треугольника = " + triangle.area());
            if (triangle.isRightAngled())
                Console.WriteLine("прямоугольный");
            else
                Console.WriteLine("непрямоугольный");
        }

    }
   
}
