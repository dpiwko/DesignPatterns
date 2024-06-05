namespace DesignPatterns.Decorator.Coffee;

public class Client
{
  // public static void Main()
  // {
  //   ICoffee coffee = new Coffee();
  //   Console.WriteLine("Order: " + coffee.GetDescription() + ", cost: $" + coffee.GetCost().ToString("0.00"));

  //   coffee = new MilkDecorator(coffee);
  //   Console.WriteLine("Order: " + coffee.GetDescription() + ", cost: $" + coffee.GetCost().ToString("0.00"));

  //   coffee = new SugarDecorator(coffee);
  //   Console.WriteLine("Order: " + coffee.GetDescription() + ", cost: $" + coffee.GetCost().ToString("0.00"));
  // }
}

//// OUTPUT: 
//// Order: coffee, cost: $3,00
//// Order: coffee + milk, cost: $4,00
//// Order: coffee + milk + sugar, cost: $4,50
