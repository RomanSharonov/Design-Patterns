using System;
using System.Collections.Generic;

namespace ObserverPattern {
    public class WeatherData : ISubject {
        private List<IObserver> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public WeatherData() {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer) {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) {
            int i = Observers.IndexOf(observer);
            if (i >= 0) {
                Observers.Remove(observer);
            }
        }

        public void NotifyObservers() {
            foreach (var observer in Observers) {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        private void MeasurementsChanged() {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
