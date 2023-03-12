using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork
{
    public class DaysOfTheWeekAndWeather
    {

        private event WeatherDelegate? Weahter = delegate (string weather) 
        {
            Console.Write(weather);
        };
        private int daysCount;
        private string[] weather = {"Ясно","Пасмурно","Дождь","Снег","Облачно" };
        private int DaysCount 
        {
            get { return daysCount; }
            set 
            {
                if(value <= 7)  daysCount = value;
                if (value > 7) daysCount = 1;
            }
        }
        public DaysOfTheWeekAndWeather() 
        {
            DaysCount = 1;
        }

        public  void WhatADay() 
        {
            Random rnd = new Random();
            switch (DaysCount)
            {
                case 1:
                    Console.Write("Понедельник - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]}\n");
                    DaysCount++;
                    break;
                case 2:
                    Console.Write("Вторник - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]}\n");
                    DaysCount++;
                    break;
                case 3:
                    Console.Write("Среда - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]} \n");
                    DaysCount++;
                    break;
                case 4:
                    Console.Write("Четверг - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]} \n");
                    DaysCount++;
                    break;
                case 5:
                    Console.Write("Пятница - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]} \n");
                    DaysCount++;
                    break;
                case 6:
                    Console.Write("Суббота - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]}  \n");
                    DaysCount++;
                    break;
                case 7:
                    Console.Write("Воскресенье - ");
                    Weahter?.Invoke($"{weather[rnd.Next(0, 5)]}  \n");
                    DaysCount++;
                    break;
            }

        }
    }
}
