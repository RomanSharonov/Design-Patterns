using System;

namespace ObserverPattern {
    public class CurentConditionsDisplay : IObserver, IDisplayElement {
        private float _temperature;
        private float _humidity;

        public CurentConditionsDisplay(ISubject weatherData) {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display() {
            Console.WriteLine("Current conditions: {0} C degree and {1} %humidity", _temperature, _humidity);
        }
    }
}
