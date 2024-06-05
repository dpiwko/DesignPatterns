namespace DesignPatterns.ChainOfResponsibility.Logger;

public class WarningLogger : Logger
{
  public WarningLogger()
  {
    this.loggerLevel = LoggerLevel.WARNING;
  }

  protected override void Write(string message)
  {
    Console.WriteLine("WARNING: " + message);
  }
}
