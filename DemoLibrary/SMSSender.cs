using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SMSSender : IMessage
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an SMS to {person.PhoneNumber}");
        }
    }
}
