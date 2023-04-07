using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredEventApplication.Loggers
{
    public class NightPass : IEvent
    {
        private eventInformation currentApplication;

        public NightPass(int id, string description, double cost, bool returnable)
        {
            currentApplication = new eventInformation(id, description, cost, returnable);
        }

        public void printInfo()
        {
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
            Console.WriteLine("is this customers price correct? (Discount = D) (Late = L) (Employee = E) (Free = F)");
        }

        public void changePrice()
        {
            var choice = Console.ReadLine();
            currentApplication.changePrice(choice);
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
        }

        public void addReturnClause()
        {
            Console.WriteLine("Make this ticket Returnable (Y/N)");
            var choice = Console.ReadLine();
            bool result = currentApplication.addReturnClause(choice);
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost + " " + "Returnable: " + result);
        }
    }
}
