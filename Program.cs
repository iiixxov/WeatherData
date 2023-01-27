using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentCunditionsDisplay currentCunditionsDisplay = new CurrentCunditionsDisplay(weatherData);
            StatisticDisplay statisticDisplay = new StatisticDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.setMeasurements(-10, 81, 752);
            Console.WriteLine();
            weatherData.setMeasurements(-9, 80, 750);
            Console.WriteLine();
            weatherData.setMeasurements(-8, 84, 749);
            Console.WriteLine();
        }
    }
}
