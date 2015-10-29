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
    public void SendEmail(string address, string subject, string body)
    {
      var mail = new MailMessage();
      mail.To.Add(address);
      mail.Subject = subject;
      mail.Body = body;
      var client=new SmtpClient();
      // Setup client here
      client.Send(mail);
    }
  }
}
