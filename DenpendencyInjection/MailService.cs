using System;
using System.Net.Mail;

namespace DenpendencyInjection
{
  class MailService
  {
    private ILogger logger;
    public MailService(ILogger logger)
    {
      this.logger = logger;
    }

    public void SendEmail(string address, string subject, string body)
    {
      Console.WriteLine("Creating mail message...");
      var mail = new MailMessage();
      mail.To.Add(address);
      mail.Subject = subject;
      mail.Body = body;
      var client=new SmtpClient();
      // Setup client here
      Console.WriteLine("Sending message...");
      client.Send(mail);
      Console.WriteLine("Message sent successfully.");
    }
  }
}
