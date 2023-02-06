namespace TaskStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double result = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число соответсвующее желаемйо вам операции:\n" +
                        "1.Сложение\n" +
                        "2.Вычетание\n" +
                        "3.Умноженние\n" +
                        "4.Деление\n" +
                        "5.Процент от числа\n" +
                        "6.Квадратный корень числа");
            int func = Convert.ToInt32(Console.ReadLine());
            double num1;
            switch (func) 
            {
                case 1:
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result + num1;
                    Console.WriteLine($"Результат: {result}");
                        goto case 7;
                case 2:
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result - num1;
                    Console.WriteLine($"Результат: {result}");
                    goto case 7;
                case 3:
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result * num1;
                    Console.WriteLine($"Результат: {result}");
                    goto case 7;
                case 4:
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result / num1;
                    Console.WriteLine($"Результат: {result}");
                    goto case 7;
                case 5:
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result / 100 * num1;
                    Console.WriteLine($"Результат: {result}");
                    goto case 7;
                case 6:
                        result = Math.Sqrt(result);
                    Console.WriteLine($"Результат: {result}");
                    goto case 7;
                case 7:
                    Console.WriteLine("Завершить программу: Y/N");
                    char symb = char.Parse(Console.ReadLine());
                    if (symb == 'Y')
                    {
                        goto default;
                    }
                    else 
                    {
                        Console.WriteLine("Выберите операцию:");
                        int reoperation = Convert.ToInt32(Console.ReadLine());
                        if (reoperation == 1) { goto case 1; }
                        if (reoperation == 2) { goto case 2; }
                        if (reoperation == 3) { goto case 3; }
                        if (reoperation == 4) { goto case 4; }
                        if (reoperation == 5) { goto case 5; }
                        if (reoperation == 6) { goto case 6; }
                    }
                    break;
                default:
                    break;
                   
            }
        }
    }
}