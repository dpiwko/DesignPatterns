namespace DesignPatterns.Observer.WeatherStation;

public class ForecastDisplay : IObserver
{
  private int _currentPressure = 1000;

  private int _lastPressure;

  private readonly ISubject _weatherStation;

  public ForecastDisplay(ISubject weatherStation)
  {
    this._weatherStation = weatherStation;

    weatherStation.Attach(this);
  }

  public void Update(float temperature, float humidity, int pressure)
  {
    this._lastPressure = this._currentPressure;
    this._currentPressure = pressure;

    Display();
  }

  public void Display()
  {
    Console.Write("Forecast: ");

    if (_currentPressure > _lastPressure)
    {
      Console.WriteLine("Improving weather on the way!");
    }
    else if (_currentPressure == _lastPressure)
    {
      Console.WriteLine("More of the same.");
    }
    else if (_currentPressure < _lastPressure)
    {
      Console.WriteLine("Watch out for cooler, rainy weather.");
    }
  }
}
