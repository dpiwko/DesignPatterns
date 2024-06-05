namespace DesignPatterns.ChainOfResponsibility.Tickets;

public class Client
{
  // public static void Main()
  // {
  //   ITicket technicalHandler = new TechnicalIssueTicket();
  //   ITicket billingHandler = new BillingQueryTicket();
  //   ITicket generalHandler = new GeneralQueryTicket();

  //   technicalHandler.SetNext(billingHandler);
  //   billingHandler.SetNext(generalHandler);

  //   technicalHandler.HandleTicket(TicketType.Technical, "System crash on login");
  //   technicalHandler.HandleTicket(TicketType.Billing, "Incorrect invoice amount");
  //   technicalHandler.HandleTicket(TicketType.General, "How to reset my password?");
  // }
}

//// OUTPUT:
//// Ticket::Technical issue: System crash on login
//// Ticket::Billing query: Incorrect invoice amount
//// Ticket::General query: How to reset my password?
