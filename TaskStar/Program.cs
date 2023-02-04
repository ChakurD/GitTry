namespace TaskStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число соответсвующее желаемйо вам операции:\n" +
                        "1.Сложение\n" +
                        "2.Вычетание\n" +
                        "3.Умноженние\n" +
                        "4.Деление\n" +
                        "5.Процент от числа\n" +
                        "6.Квадратный корень числа\n" +
                        "7.Вывести результат");
            int func = Convert.ToInt32(Console.ReadLine());
            double result=0;
            double num1;
            double num2;
            switch (func) 
            {
                case 1:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        goto case 8;
                    }
                    else {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + result;
                        goto case 8;
                    }
                case 2:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        goto case 8;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - result;
                        goto case 8;
                    }
                case 3:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        goto case 8;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * result;
                        goto case 8;
                    }
                case 4:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 / num2;
                        goto case 8;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = num1 / result;
                        goto case 8;
                    }
                case 5:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num2 / 100 * num1;
                        goto case 8;
                    }
                    else
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = result / 100 * num1;
                        goto case 8;
                    }
                case 6:
                    if (result == 0)
                    {
                        num1 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Sqrt(num1);
                        goto case 8;
                    }
                    else
                    {
                        result = Math.Sqrt(result);
                        goto case 8;
                    }
                case 7:
                    Console.WriteLine($"{result}");
                    goto case 8;
                case 8:
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
                        if (reoperation == 7) { goto case 7; }
                    }
                    break;
                default:
                    break;
                   
            }
        }
    }
}