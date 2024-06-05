namespace DesignPatterns.Singleton.PrintBuffer;

public class PrintBuffer
{
  private static PrintBuffer? _instance;

  private readonly Queue<string> _buffer = new Queue<string>();

  private PrintBuffer() { }

  public static PrintBuffer Instance
  {
    get
    {
      if (_instance is null)
      {
        _instance = new PrintBuffer();
      }

      return _instance;
    }
  }

  public void AddToBuffer(string content)
  {
    _buffer.Enqueue(content);
  }

  public void PrintContent()
  {
    while (_buffer.Count > 0)
    {
      Console.WriteLine(_buffer.Dequeue());
    }
  }
}
