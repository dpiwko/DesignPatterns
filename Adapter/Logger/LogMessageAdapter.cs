namespace DesignPatterns.Adapter.Logger;

public class LogMessageAdapter : ILoggingMessage
{
  private ILogger _logger;

  public LogMessageAdapter(ILogger logger)
  {
    _logger = logger;
  }

  public void LogMessage(string message)
  {
    _logger.Log(message);
  }
}
