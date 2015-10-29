using System;
using System.Net;
using System.Net.Mail;

namespace DenpendencyInjection
{
  class MailService
  {
    private ILogger logger;
    private SmtpClient client;
    private string sender;

    public MailService(MailServerConfig config, ILogger logger)
    {
      this.logger = logger;
      InitializeClient(config);
      sender = config.SenderEmail;
    }

    public void SendEmail(string address, string subject, string body)
    {
      logger.Log("initializing...");
      var mail = new MailMessage(sender,address);
      mail.Subject = subject;
      mail.Body = body;
      logger.Log("Sending message...");
      client.Send(mail);
      logger.Log("Message sent successfully.");
    }

    private void InitializeClient(MailServerConfig config)
    {
      client = new SmtpClient();
      client.Host = config.SmtpServer;
      client.Port = config.SmtpPort;
      client.EnableSsl = true;
      var credentials = new NetworkCredential();
      credentials.UserName = config.SenderEmail;
      credentials.Password = config.SenderEmail;
      client.Credentials = credentials;
    }
  }
}
