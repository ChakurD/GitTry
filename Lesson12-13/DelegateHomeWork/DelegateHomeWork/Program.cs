namespace DelegateHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeekAndWeather days= new DaysOfTheWeekAndWeather();
            DaysOfTheWeekAndWeatherDelegate week = days.WhatADay;
            week();
            week();
            week();
            week();
            week();
            week();
            week();
            week();
            week();
            week();
            week();
            week();

        }
    }
}