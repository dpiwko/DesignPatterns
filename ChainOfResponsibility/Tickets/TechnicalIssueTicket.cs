namespace DesignPatterns.ChainOfResponsibility.Tickets;

public class TechnicalIssueTicket : Ticket
{
  public TechnicalIssueTicket()
  {
    this.ticketType = TicketType.Technical;
  }

  protected override void Handle(string description)
  {
    Console.WriteLine("Ticket::Technical issue: " + description);
  }
}

