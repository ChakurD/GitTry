namespace AbstractClassFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(15.2,5.6 );
            Rectangle rectangle2 = new Rectangle(11.2, 3.4);
            Triangle triangle1 = new Triangle(5.4, 3.2, 6.1);
            Circle circle1 = new Circle(4.0);
            Circle circle2 = new Circle(7.1);
            Figure[] figuresArr = new Figure[5] ;
            figuresArr[0] = rectangle1;
            figuresArr[1] = rectangle2;
            figuresArr[2] = triangle1;
            figuresArr[3] = circle1;
            figuresArr[4] = circle2;

            double perimetrSum = 0.0;

            for (int i = 0; i<figuresArr.Length;i++)
            {
                perimetrSum = perimetrSum + figuresArr[i].Perimeter();
            }
            Console.WriteLine($"Сумма периметра всех фигур: {perimetrSum}");
        }
    }
}