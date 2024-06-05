namespace DesignPatterns.Observer.GameResults;

public class Player : IObserver
{
  public string name { get; }

  private Game _game;

  public Player(string name, Game game)
  {
    this.name = name;
    this._game = game;

    game.Attach(this);
  }

  public void Update()
  {
    Console.WriteLine("Player " + name + ", the score table has been updated:");

    _game.DisplayScores();
  }

  public void ChangeScore(int newScore)
  {
    _game.UpdateScore(this, newScore);
  }
}
