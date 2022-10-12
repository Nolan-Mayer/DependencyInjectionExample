using RefactoredEventApplication.Loggers;
using System;

namespace RefactoredEventApplication // Note: actual namespace depends on the project name.
{

    public interface ILogger
    {
        void Log(string message);
    }

    public interface IdayPass
    {
        void printEventInformation();
    }

    public interface IeveningPass
    {
        void printEventInformation();
    }

    public interface INightPass
    {
        void printEventInformation();
    }

    public class eventInformation // event class
    {
        private int eventId;
        private string eventDescription;
        private double eventCost;

        public eventInformation(int eventId, string eventDescription, double eventCost) // constructor
        {
            EventId = eventId;
            EventDescription = eventDescription;
            EventCost = eventCost;
        }

        public int EventId
        {
            get { return eventId; }
            set { eventId = value; }
        }

        public string EventDescription
        {
            get { return eventDescription; }
            set { eventDescription = value; }
        }

        public double EventCost
        {
            get { return eventCost; }
            set { eventCost = value; }
        }

        public double changePrice(string choice)
        {
            if (!String.IsNullOrEmpty(choice))
            {
                if (choice.ToLower() == "d")
                {
                    return eventCost *= 0.9;
                }
                else if (choice.ToLower() == "l")
                {
                    return eventCost *= 1.1;
                }
                else if (choice.ToLower() == "e")
                {
                    return eventCost *= 0.75;
                }
                else if (choice.ToLower() == "f")
                {
                    return eventCost = 0;
                }
            }
            return eventCost;
        }
    }

    public class eventApplication : IdayPass, IeveningPass, INightPass //event class
    {
        private eventInformation currentApplication;

        public eventApplication(int id, string description, double cost)
        {
            currentApplication = new eventInformation(id, description, cost);
        }

        void IdayPass.printEventInformation()
        {
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
            Console.WriteLine("is this customers price correct? (Discount = D) (Late = L) (Employee = E) (Free = F)");
            var choice = Console.ReadLine();
            currentApplication.changePrice(choice);
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
        }
        void IeveningPass.printEventInformation()
        {
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
            Console.WriteLine("is this customers price correct? (Discount = D) (Late = L) (Employee = E) (Free = F)");
            var choice = Console.ReadLine();
            currentApplication.changePrice(choice);
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
        }
        void INightPass.printEventInformation()
        {
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
            Console.WriteLine("is this customers price correct? (Discount = D) (Late = L) (Employee = E) (Free = F)");
            var choice = Console.ReadLine();
            currentApplication.changePrice(choice);
            Console.WriteLine("ID:" + currentApplication.EventId + " " + currentApplication.EventDescription + " Price: " + "$" + currentApplication.EventCost);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Event Application in C#");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            ILogger logger = new FileLogger();
            ProductService productService = new ProductService(logger);

            IdayPass newDayPass = new eventApplication(101, "Enjoy the pletora of activities such as tractor ride, rock band and corn maze!", 20.00);                
            newDayPass.printEventInformation();
            productService.Log("Day purchase has been recieved");
            Console.WriteLine("");

            IeveningPass newEveningPass = new eventApplication(202, "Prepare yourself for the spooky haunted houses and more!,", 30.00);
            newEveningPass.printEventInformation();
            productService.Log("Evening purchase has been recieved");
            Console.WriteLine("");
 
            INightPass newNightPass = new eventApplication(303, "Have fast passes to haunted houses and exclusive access to the rock bands!", 50.00);
            newNightPass.printEventInformation();
            productService.Log("Night purchase has been recieved");
            Console.WriteLine("");

        }
    }
}