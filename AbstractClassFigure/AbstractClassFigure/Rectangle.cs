using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassFigure
{
    public class Rectangle : Figure
    {
        private double sideOfTheRectangleA;
        private double sideOfTheRectangleB;
        public double SideOfTheRectangleA
        {
            get { return sideOfTheRectangleA; }
            set 
            {
                if (value > 0) sideOfTheRectangleA = value;
                else Console.WriteLine("Сторона не может быть меньше 0");
            }
        }
        public double SideOfTheRectangleB
        {
            get { return sideOfTheRectangleB; }
            set
            {
                if (value > 0) sideOfTheRectangleB = value;
                else Console.WriteLine("Сторона не может быть меньше 0");
            }
        }
        public Rectangle() { }
        public Rectangle(double sideA, double sideB) {
            sideOfTheRectangleA = sideA;
            sideOfTheRectangleB = sideB;
        }

        public override double Perimeter()
        {
            return 2 * (sideOfTheRectangleA + sideOfTheRectangleB);
        }
        public override double Square()
        {
            return sideOfTheRectangleA * sideOfTheRectangleB;
        }
    }
}
