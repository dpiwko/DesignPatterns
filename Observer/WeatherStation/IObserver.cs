namespace DesignPatterns.Observer.WeatherStation;

public interface IObserver
{
  void Update(float temperature, float humidity, int pressure);
}
