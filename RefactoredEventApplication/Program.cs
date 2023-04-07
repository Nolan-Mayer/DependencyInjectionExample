using RefactoredEventApplication.Loggers;
using System;

namespace RefactoredEventApplication // Note: actual namespace depends on the project name.
{
    public interface IEvent
    {
        void printInfo();
        void changePrice();
        void addReturnClause();
    }

    public class eventInformation // event class
    {
        private int eventId;
        private string eventDescription;
        private double eventCost;
        private bool isReturnable; //if user can return event ticket

        public eventInformation(int eventId, string eventDescription, double eventCost, bool isReturnable) // constructor
        {
            EventId = eventId;
            EventDescription = eventDescription;
            EventCost = eventCost;
            IsReturnable = isReturnable;
        }

        public bool IsReturnable
        {
            get { return isReturnable; }
            set { isReturnable = value; }
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

        public bool addReturnClause(string choice) //new engine for execptional grade
        {
            if (choice.ToLower() == "y")
            {
                return true;
            }
            else if (choice.ToLower() == "n")
            {
                return false;
            }
            return false;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Event Application in C#");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            IEvent dayEvent = new DayPass(101, "Enjoy the pletora of activities such as tractor ride, rock band and corn maze!", 20.00, false);
            IEvent eveningEvent = new EveningPass(202, "Beware of spooky haunted houses and the notorious psycho path", 30.00, false);
            IEvent nightEvent = new NightPass(303, "Get premium access to the rock bands and enjoy all you can eat food at the hay bar", 50.00, false);

            ProductService dayService = new ProductService(dayEvent);
            ProductService eveningService = new ProductService(eveningEvent);
            ProductService nightService = new ProductService(nightEvent);

            PriceService dayPrice = new PriceService(dayEvent);
            PriceService eveningPrice = new PriceService(eveningEvent);
            PriceService nightPrice = new PriceService(nightEvent);

            ReturnService dayReturn = new ReturnService(dayEvent);
            ReturnService eveningReturn = new ReturnService(eveningEvent);
            ReturnService nightReturn = new ReturnService(nightEvent);

            dayService.PrintInfo();
            dayPrice.ChangePrice();
            dayReturn.AddReturnClause();
            Console.WriteLine("");
            eveningService.PrintInfo();
            eveningPrice.ChangePrice();
            eveningReturn.AddReturnClause();
            Console.WriteLine("");
            nightService.PrintInfo();
            nightPrice.ChangePrice();
            nightReturn.AddReturnClause();
        }
    }
}