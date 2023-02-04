namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 12:");
            int MonthNum = int.Parse(Console.ReadLine());
            switch (MonthNum) 
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine($"{MonthNum} соответствует Зиме");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"{MonthNum} соответствует Весне");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"{MonthNum} соответствует Лету");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"{MonthNum} соответствует Осени");
                    break;
            }

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите номер месяца от 1 до 12:");
            int SecMonthNum = Convert.ToInt32(Console.ReadLine());
            if (SecMonthNum <= 2 || SecMonthNum == 12)
            {
                Console.WriteLine($"{SecMonthNum} соответствует Зиме");
            }
            else if (SecMonthNum <= 5)
            {
                Console.WriteLine($"{SecMonthNum} соответствует Весне");
            }
            else if (SecMonthNum <= 8)
            {
                Console.WriteLine($"{SecMonthNum} соответствует Лету");
            }
            else if (SecMonthNum <= 11)
            {
                Console.WriteLine($"{SecMonthNum} соответствует Осени");
            }

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите число: ");
            int ParNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ParNum % 2 == 0 ? $"{ParNum} Четное" : $"{ParNum} Не четное");

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите Температуру:");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t > -5) { Console.WriteLine("Тепло"); }
            if (t <= -5 && t > -20) { Console.WriteLine("Нормально"); }
            if (t <= -20) { Console.WriteLine("Холодно"); }

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите число от 1 до 21 :");
            int Color = Convert.ToInt32(Console.ReadLine());
            if (Color <= 3) 
            {
                Console.WriteLine("Фиолетовый");
            }
            else if (Color <= 6)
            {
                Console.WriteLine("Синий");
            }
            else if(Color <= 9)
            {
                Console.WriteLine("Голубой");
            }
            else if (Color <= 12)
            {
                Console.WriteLine("Зеленый");
            }
            else if (Color <= 15)
            {
                Console.WriteLine("Желтый");
            }
            else if (Color <= 18)
            {
                Console.WriteLine("Оранжевый");
            }
            else if (Color <= 21)
            {
                Console.WriteLine("Красный");
            }
        }
    }
}