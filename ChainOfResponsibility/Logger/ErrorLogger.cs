namespace DesignPatterns.ChainOfResponsibility.Logger;

public class ErrorLogger : Logger
{
  public ErrorLogger()
  {
    this.loggerLevel = LoggerLevel.ERROR;
  }

  protected override void Write(string message)
  {
    Console.WriteLine("ERROR: " + message);
  }
}
