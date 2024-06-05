namespace DesignPatterns.ChainOfResponsibility.Logger;

public class InfoLogger : Logger
{
  public InfoLogger()
  {
    this.loggerLevel = LoggerLevel.INFO;
  }

  protected override void Write(string message)
  {
    Console.WriteLine("INFO: " + message);
  }
}
