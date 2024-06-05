namespace DesignPatterns.ChainOfResponsibility.Tickets;

public interface ITicket
{
  void SetNext(ITicket nextHandler);
  void HandleTicket(TicketType ticketType, string description);
}
