namespace DesignPatterns.ChainOfResponsibility.Logger;

public interface ILogger
{
  void SetNext(ILogger nextLogger);
  void LogMessage(LoggerLevel loggerLevel, string message);
}
