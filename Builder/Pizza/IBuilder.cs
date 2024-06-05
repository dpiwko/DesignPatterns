namespace DesignPatterns.Builder.Pizza;

public interface IBuilder
{
  void AddDough(string dough);
  void AddMeat(string meat);
  void AddCheese(string cheese);
  void AddVegetables(string vegetables);
  void AddSpices(string spices);
  Pizza GetPizza();
}
