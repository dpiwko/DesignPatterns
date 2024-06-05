namespace DesignPatterns.Builder.Pizza;

public class PizzaDirector
{
  private IBuilder? _builder;

  public void SetBuilder(IBuilder builder)
  {
    _builder = builder;
  }

  public void ConstructPizza()
  {
    _builder?.AddDough("Thin Crust");
    _builder?.AddMeat("Pepperoni");
    _builder?.AddCheese("Mozzarella");
    _builder?.AddVegetables("Onion");
    _builder?.AddSpices("Oregano");
  }
}
