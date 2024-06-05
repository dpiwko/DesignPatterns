namespace DesignPatterns.Singleton.MessageRegistry;

class MessageRegistry
{
  private static MessageRegistry? _instance;

  private readonly List<string> _messages = [];

  private MessageRegistry() { }

  public static MessageRegistry Instance
  {
    get
    {
      if (_instance is null)
      {
        _instance = new MessageRegistry();
      }

      return _instance;
    }
  }

  public void AddMessage(string message)
  {
    _messages.Add(message);
  }

  public List<string> GetMessagesList()
  {
    return _messages;
  }
}
