using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DenpendencyInjection
{
  class MailService
  {
    private ConsoleLogger logger;
    public MailService()
    {
      logger = new ConsoleLogger();
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
