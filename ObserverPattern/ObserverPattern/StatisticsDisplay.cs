using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern {
    class StatisticsDisplay : IObserver, IDisplayElement {
        private List<float> History;
        public StatisticsDisplay(WeatherData weatherData) {
            weatherData.RegisterObserver(this);
            History = new List<float>();
        }

        public void Update(float temp, float humidity, float pressure) {
            History.Add(temp);
            Display();
        }

        public void Display() {
            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", History.Average(), History.Max(), History.Min());
        }
    }
}