namespace DesignPatterns.ChainOfResponsibility.Tickets;

public abstract class Ticket : ITicket
{
  protected TicketType ticketType;

  private ITicket? _nextHandler;

  public void SetNext(ITicket nextHandler)
  {
    this._nextHandler = nextHandler;
  }

  public void HandleTicket(TicketType ticketType, string description)
  {
    if (this.ticketType == ticketType)
    {
      Handle(description);
    }

    if (_nextHandler != null)
    {
      _nextHandler.HandleTicket(ticketType, description);
    }
  }

  protected abstract void Handle(string description);
}
