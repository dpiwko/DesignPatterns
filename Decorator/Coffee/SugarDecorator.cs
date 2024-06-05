namespace DesignPatterns.Decorator.Coffee;

public class SugarDecorator : CoffeeDecorator
{
  public SugarDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return base.GetDescription() + " + sugar";
  }

  public override double GetCost()
  {
    return base.GetCost() + 0.5;
  }
}
