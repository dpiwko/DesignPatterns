namespace DesignPatterns.Builder.Pizza;

public class Pizza
{
  public string? dough { get; set; }

  public string? meat { get; set; }

  public string? cheese { get; set; }

  public string? vegetables { get; set; }

  public string? spices { get; set; }

  public override string ToString()
  {
    return "Dough: " + dough + ",\nMeat: " + meat + ",\nCheese: " + cheese + ",\nVegetables: " + vegetables + ",\nSpices: " + spices;
  }
}
