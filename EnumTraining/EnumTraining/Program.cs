namespace EnumTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                switch (i) 
                {
                    case (int)DaysOfTheWeek.Monday:
                        Console.WriteLine($"Сейчас: Понедельник ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Tuesday:
                        Console.WriteLine($"Сейчас: Вторник ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Wednesday:
                        Console.WriteLine($"Сейчас: Среда ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Thursday:
                        Console.WriteLine($"Сейчас: Четверг ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Friday:
                        Console.WriteLine($"Сейчас: Пятница ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Saturday:
                        Console.WriteLine($"Сейчас: Суббота ");
                        Thread.Sleep(400);
                        break;
                    case (int)DaysOfTheWeek.Sunday:
                        Console.WriteLine($"Сейчас: Воскресенье ");
                        break;
                }
            }
        }
    }
}