using System.Diagnostics;

namespace DenpendencyInjection
{
  class EventLogger : ILogger
  {
    public void Log(string message)
    {
      EventLog.WriteEntry("MailService", message);
    }
  }
}
