using System;

namespace ObserverPattern {
    public class CurentConditionsDisplay : IObserver, IDisplayElement {
        private float Temperature;
        private float Humidity;

        public CurentConditionsDisplay(ISubject weatherData) {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }

        public void Display() {
            Console.WriteLine("Current conditions: {0} C degree and {1} %humidity", Temperature, Humidity);
        }
    }
}
