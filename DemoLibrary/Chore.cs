using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        ILogger _logger;
        IMessage _message;

        public Chore(ILogger logger, IMessage message)
        {
            _logger = logger;
            _message = message;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed {ChoreName}");

            _message.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}
