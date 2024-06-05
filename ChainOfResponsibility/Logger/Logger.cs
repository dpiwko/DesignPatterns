namespace DesignPatterns.ChainOfResponsibility.Logger;

public abstract class Logger : ILogger
{
  protected LoggerLevel loggerLevel;

  protected ILogger? _nextLogger;

  public void SetNext(ILogger nextLogger)
  {
    _nextLogger = nextLogger;
  }

  public void LogMessage(LoggerLevel loggerLevel, string message)
  {
    if (this.loggerLevel == loggerLevel)
    {
      Write(message);
    }

    if (_nextLogger != null)
    {
      _nextLogger.LogMessage(loggerLevel, message);
    }
  }

  protected abstract void Write(string message);
}
