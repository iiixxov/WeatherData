using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CurrentCunditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentCunditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.regObserver(this);
        }

        public void display()
        {
            Console.WriteLine($"Температура: {temperature} \nДавление: {pressure} \nВлажность: {humidity}");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            display();
        }
    }
}
