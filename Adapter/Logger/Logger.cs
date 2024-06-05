namespace DesignPatterns.Adapter.Logger;

public class Logger : ILogger
{
  public void Log(string log)
  {
    Console.WriteLine("Log: " + log);
  }
}
