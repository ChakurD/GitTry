using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassFigure
{
    public class Triangle : Figure
    {
        private double sideOfTheTriangleA;
        private double sideOfTheTriangleB;
        private double sideOfTheTriangleC;
        private double halfPerimetr;

        public double SideOfTheTriangleA 
        { get 
            { return sideOfTheTriangleA; } 
            set 
            {
                if (value > 0) sideOfTheTriangleA = value;
                else  Console.WriteLine("Сторона не может быть меньше 0"); 
            }
        }
        public double SideOfTheTriangleB 
        { get 
            { return sideOfTheTriangleB; }
            set 
            { if (value > 0) sideOfTheTriangleB = value;
                else Console.WriteLine("Сторона не может быть меньше 0");
            }
        }
        public double SideOfTheTriangleC 
        {
            get 
            { return sideOfTheTriangleC; }
            set 
            {
                if (value > 0) sideOfTheTriangleC = value;
                else Console.WriteLine("Сторона не может быть меньше 0");
            } 
        }
     
        public Triangle() { }
        public Triangle(double sideA, double sideB, double sideC) 
        {
            sideOfTheTriangleA = sideA;
            sideOfTheTriangleB = sideB;
            sideOfTheTriangleC = sideC;
        }
        public override double Perimeter()
        {
            double perimetr = sideOfTheTriangleA + sideOfTheTriangleB + sideOfTheTriangleC;
            halfPerimetr = perimetr / 2;
            return perimetr;
        }
        public override double Square()
        {
            double square =  Math.Sqrt(halfPerimetr*(halfPerimetr - sideOfTheTriangleA)* (halfPerimetr - sideOfTheTriangleB)* (halfPerimetr - sideOfTheTriangleC));
            return square;
        }
    }
}
