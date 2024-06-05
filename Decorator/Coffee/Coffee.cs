namespace DesignPatterns.Decorator.Coffee;

public class Coffee : ICoffee
{
  public string GetDescription()
  {
    return "coffee";
  }

  public double GetCost()
  {
    return 3.0;
  }
}
