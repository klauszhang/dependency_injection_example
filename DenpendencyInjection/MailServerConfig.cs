using System;
using System.Configuration;

namespace DenpendencyInjection
{
  class MailServerConfig
  {
    public string SmtpServer
    {
      get
      {
        return ConfigurationManager.AppSettings["SmtpServer"];
      }
    }

    public int SmtpPort
    {
      get
      {
        var port = ConfigurationManager.AppSettings["SmtpPort"];
        return Convert.ToInt32(port);
      }
    }

    public string SenderEmail
    {
      get
      {
        return ConfigurationManager.AppSettings["SenderEmail"];
      }
    }

    public string SenderPassword
    {
      get
      {
        return ConfigurationManager.AppSettings["SenderPassword"];
      }
    }
  }
}
