namespace DesignPatterns.Observer.WeatherStation;

public class WeatherStation : ISubject
{
  private List<IObserver> _observers;

  private float _temperature;

  private float _humidity;

  private int _pressure;

  public WeatherStation()
  {
    _observers = new List<IObserver>();
  }

  public void Attach(IObserver observer)
  {
    _observers.Add(observer);
  }

  public void Detach(IObserver observer)
  {
    _observers.Remove(observer);
  }

  public void NotifyObservers()
  {
    foreach (IObserver observer in _observers)
    {
      observer.Update(_temperature, _humidity, _pressure);
    }
  }

  public void SetMeasurements(float temperature, float humidity, int pressure)
  {
    this._temperature = temperature;
    this._humidity = humidity;
    this._pressure = pressure;

    NotifyObservers();
  }
}
