namespace DesignPatterns.ChainOfResponsibility.Tickets;

public class BillingQueryTicket : Ticket
{
  public BillingQueryTicket()
  {
    this.ticketType = TicketType.Billing;
  }

  protected override void Handle(string description)
  {
    Console.WriteLine("Ticket::Billing query: " + description);
  }
}
