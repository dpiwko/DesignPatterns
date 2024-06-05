namespace DesignPatterns.Adapter.Logger;

public class LoggingMessage : ILoggingMessage
{
  public void LogMessage(string message)
  {
    Console.WriteLine("Logging message: " + message);
  }
}
