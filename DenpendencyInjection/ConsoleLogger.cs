using System;

namespace DenpendencyInjection
{
  class ConsoleLogger:ILogger
  {
    public static readonly ConsoleLogger Instance = new ConsoleLogger();
    private  ConsoleLogger()
    {
      // hide constructor to use Singleton pattern
    }

    public void Log(string message)
    {
      Console.WriteLine("{0}: {1}", DateTime.Now, message);
    }
  }
}