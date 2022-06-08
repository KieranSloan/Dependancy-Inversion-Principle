using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class DependancyFactory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreatedLogger(), CreateMessageSender());
        }

        public static ILogger CreatedLogger()
        {
            return new Logger();
        }

        public static IMessage CreateMessageSender()
        {
            return new SMSSender();
        }
    }
}
