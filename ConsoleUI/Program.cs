using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dependancies that low level functions use should be created at the high level (usually at application start)
             * Therefore we've removed all low level dependancies such as the emailer in Chore class to be created at the high level
             * rather than when we need to dependancy. This allows for We can make a change to our application in once peice where by (for example
             * we can change the Emailer to a TextMessager by only creating the new TextMessager class, implement the IMessage interface and 
             * change our Dependancy factory to create a TextMessager in the CreateMessageSender static method.
             * there is no new'ing of any dependancies outside of the dependancy factory class. 
             */

            IPerson owner = DependancyFactory.CreatePerson();
            owner.FirstName = "Kieran";
            owner.LastName = "Sloan";
            owner.EmailAddress = "noreply@sloany.com";
            owner.PhoneNumber = "07756625664";

            IChore chore = DependancyFactory.CreateChore();
            chore.ChoreName = "Take out the black bags";
            chore.Owner = owner;


            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            IChore chore2 = DependancyFactory.CreateChore();
            chore.ChoreName = "Wash the Dishes";
            chore.Owner = owner;


            chore.PerformedWork(2);
            chore.CompleteChore();


            Console.ReadLine();
        }
    }
}
