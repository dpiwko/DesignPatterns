namespace DesignPatterns.Adapter.Square;

public class SquareAdapter : IShape
{
  private Square _square;

  public SquareAdapter(Square square)
  {
    _square = square;
  }

  public double GetArea()
  {
    return _square.width * _square.width;
  }
}
