using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ForecastDisplay : Observer, DisplayElement
    {
        float currentPressure;
        float lastPressure;
        Subject weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            currentPressure = 0;
            lastPressure = 0;
            
            this.weatherData = weatherData;
            weatherData.regObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Прогноз:");
            if (currentPressure > lastPressure)
                Console.WriteLine("Погода улучшается.");
            else if(currentPressure == lastPressure)
                Console.WriteLine("Изменения не прогнозируются.");
            else
                Console.WriteLine("Похода ухудшается.");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            display();
        }
    }
}
