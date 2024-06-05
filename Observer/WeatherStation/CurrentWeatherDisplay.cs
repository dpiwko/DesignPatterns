namespace DesignPatterns.Observer.WeatherStation;

public class CurrentWeatherDisplay : IObserver
{
  private float _temperature;

  private float _humidity;

  private readonly ISubject _weatherStation;

  public CurrentWeatherDisplay(ISubject weatherStation)
  {
    this._weatherStation = weatherStation;

    weatherStation.Attach(this);
  }

  public void Update(float temperature, float humidity, int pressure)
  {
    this._temperature = temperature;
    this._humidity = humidity;

    Display();
  }

  public void Display()
  {
    Console.WriteLine("Current weather: " + _temperature + "C degrees and " + _humidity + "% humidity.");
  }
}
