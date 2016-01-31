using System;
using System.Collections.Generic;

namespace ObserverPattern {
    public class WeatherData : ISubject {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData() {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer) {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer) {
            int i = _observers.IndexOf(observer);
            if (i >= 0) {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers() {
            foreach (var observer in _observers) {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        private void MeasurementsChanged() {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
