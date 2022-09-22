using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        private double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
