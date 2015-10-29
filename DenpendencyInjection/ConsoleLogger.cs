using System;

namespace DenpendencyInjection
{
  class ConsoleLogger
  {
    public void Log(string message)
    {
      Console.WriteLine("{0}: {1}", DateTime.Now, message);
    }
  }
}