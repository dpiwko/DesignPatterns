namespace DesignPatterns.Builder.Pizza;

public class PizzaBuilder : IBuilder
{
  private Pizza _pizza = new Pizza();

  public void AddDough(string dough)
  {
    _pizza.dough = dough;
  }

  public void AddMeat(string meat)
  {
    _pizza.meat = meat;
  }

  public void AddCheese(string cheese)
  {
    _pizza.cheese = cheese;
  }

  public void AddVegetables(string vegetables)
  {
    _pizza.vegetables = vegetables;
  }

  public void AddSpices(string spices)
  {
    _pizza.spices = spices;
  }

  public Pizza GetPizza()
  {
    return _pizza;
  }
}
