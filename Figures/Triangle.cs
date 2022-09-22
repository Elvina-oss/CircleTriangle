using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double area()
        {
            double semiperimeter = (a + b + c) / 2;
            return Math.Pow(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c), 0.5);
        }
        //проверка треугольника на прямоугольность
        public Boolean isRightAngled()
        {
            double hypotenuse, cathet1, cathet2;
            if (a>b & a>c)
            {
                hypotenuse = a;
                cathet1 = b;
                cathet2 = c;
            }
            else if(b>a & b>c)
            {
                hypotenuse = b;
                cathet1 = a;
                cathet2 = c;
            }
            else
            {
                hypotenuse = c;
                cathet1 = a;
                cathet2 = b;
            }
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(cathet2, 2) + Math.Pow(cathet1, 2))) < double.Epsilon;
        }
    }
}
