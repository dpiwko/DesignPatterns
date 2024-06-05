namespace DesignPatterns.Decorator.Coffee;

public class MilkDecorator : CoffeeDecorator
{
  public MilkDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return base.GetDescription() + " + milk";
  }

  public override double GetCost()
  {
    return base.GetCost() + 1.0;
  }
}
