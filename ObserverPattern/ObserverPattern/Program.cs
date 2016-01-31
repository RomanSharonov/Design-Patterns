using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Schema;

namespace ObserverPattern {
    class Program {
        static void Main(string[] args) {

            var weatherData = new WeatherData();
            new CurentConditionsDisplay(weatherData);
            new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }

    class StatisticsDisplay : IObserver, IDisplayElement {
        private List<float> history;
        public StatisticsDisplay(WeatherData weatherData) {
            weatherData.RegisterObserver(this);
            history = new List<float>();
        }

        public void Update(float temp, float humidity, float pressure) {
            history.Add(temp);
            Display();
        }

        public void Display() {
            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", history.Average(), history.Max(), history.Min());
        }
    }
}
