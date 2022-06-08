using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Emailer : IMessage
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }
}
