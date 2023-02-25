using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassFigure
{
    public class Circle : Rectangle
    {
        private double radius;
        private double pi;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0) radius = value;
                else Console.WriteLine("Радиус не может быть меньше 0");
            }
        }
        public double Pi
        {
            get { return pi; }
            set { pi = value; }
        } 
        public Circle(double radius)
        {
            this.radius = radius;
            pi = 3.14;
        }
        public override double Perimeter()
        {
            double perimetr = 2 * pi * radius;
            return perimetr;
        }
        public override double Square()
        {
            double square = pi * radius * radius;
        return square;
        }
    }
}
