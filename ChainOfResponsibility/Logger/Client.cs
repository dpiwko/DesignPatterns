namespace DesignPatterns.ChainOfResponsibility.Logger;

public class Client
{
  // public static void Main()
  // {
  //   ILogger infoLogger = new InfoLogger();
  //   ILogger warningLogger = new WarningLogger();
  //   ILogger errorLogger = new ErrorLogger();

  //   infoLogger.SetNext(warningLogger);
  //   warningLogger.SetNext(errorLogger);

  //   infoLogger.LogMessage(LoggerLevel.INFO, "This is an informational message");
  //   infoLogger.LogMessage(LoggerLevel.WARNING, "This is a warning message");
  //   infoLogger.LogMessage(LoggerLevel.ERROR, "This is an error message");
  // }
}

//// OUTPUT:
//// INFO: This is an informational message
//// WARNING: This is a warning message
//// ERROR: This is an error message
