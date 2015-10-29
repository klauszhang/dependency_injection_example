using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenpendencyInjection
{
  class Program
  {
    static void Main(string[] args)
    {
      var mailService = new MailService(new EventLogger());
      mailService.SendEmail("someone@somewhere.com", "the first DI app", "Hello World!");
    }
  }
}