namespace DesignPatterns.ChainOfResponsibility.Tickets;

public class GeneralQueryTicket : Ticket
{
  public GeneralQueryTicket()
  {
    this.ticketType = TicketType.General;
  }

  protected override void Handle(string description)
  {
    Console.WriteLine("Ticket::General query: " + description);
  }
}
