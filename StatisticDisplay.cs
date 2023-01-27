using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StatisticDisplay : Observer, DisplayElement
    {
        float maxTemp;
        float minTemp;
        float tempSum;
        float numReadings;
        Subject weatherData;
        public StatisticDisplay(Subject weatherData)
        {
            maxTemp = -200;
            minTemp = 200;
            tempSum = 0;
            numReadings = 0;
            
            this.weatherData = weatherData;
            weatherData.regObserver(this);
        }
        public void display()
        {
            float avgTemp = tempSum / numReadings;
            Console.WriteLine($"Средняя температура: {avgTemp} \nМакс температура: {maxTemp} \nМин температура {minTemp}");
        }

        public void update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings += 1;

            if (temperature > maxTemp)
                maxTemp = temperature;
            if (temperature < minTemp)
                minTemp = temperature;

            display();
        }
    }
}
