namespace DesignPatterns.Observer.GameResults;

public class Game : ISubject
{
  private List<IObserver> _observers;

  private Dictionary<Player, int> _playerScores;

  public Game()
  {
    _observers = new List<IObserver>();
    _playerScores = new Dictionary<Player, int>();
  }

  public void Attach(IObserver observer)
  {
    _observers.Add(observer);
  }

  public void Detach(IObserver observer)
  {
    _observers.Remove(observer);
  }

  public void NotifyObservers()
  {
    foreach (var observer in _observers)
    {
      observer.Update();
    }
  }

  public void UpdateScore(Player player, int newScore)
  {
    if (_playerScores.ContainsKey(player))
    {
      _playerScores[player] = newScore;
    }
    else
    {
      _playerScores.Add(player, newScore);
    }

    NotifyObservers();
  }

  public void DisplayScores()
  {
    foreach (var entry in _playerScores)
    {
      Console.WriteLine(entry.Key.name + ": " + entry.Value);
    }
  }
}
