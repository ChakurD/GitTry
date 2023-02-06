namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца от 1 до 12:");
            int monthNum = int.Parse(Console.ReadLine());
            switch (monthNum) 
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine($"{monthNum} соответствует Зиме");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"{monthNum} соответствует Весне");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine($"{monthNum} соответствует Лету");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine($"{monthNum} соответствует Осени");
                    break;
            }

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите номер месяца от 1 до 12:");
            int secMonthNum = Convert.ToInt32(Console.ReadLine());
            if (secMonthNum <= 2 || secMonthNum == 12)
            {
                Console.WriteLine($"{secMonthNum} соответствует Зиме");
            }
            else if (secMonthNum <= 5)
            {
                Console.WriteLine($"{secMonthNum} соответствует Весне");
            }
            else if (secMonthNum <= 8)
            {
                Console.WriteLine($"{secMonthNum} соответствует Лету");
            }
            else if (secMonthNum <= 11)
            {
                Console.WriteLine($"{secMonthNum} соответствует Осени");
            }

            //--------------------------------------------------------------------------------

            Console.WriteLine("Введите число: ");
            int parNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(parNum % 2 == 0 ? $"{parNum} Четное" : $"{parNum} Не четное");

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