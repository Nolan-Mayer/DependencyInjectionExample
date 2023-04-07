using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredEventApplication
{
    [TestClass]
    public class EventApplicationUnitTests
    {
        [TestMethod]
        public void TestChangePriceDiscount()
        {
            eventInformation discount = new eventInformation(101, "This is a test", 20.00, false);
            double unitPrice = discount.changePrice("d");
            Assert.AreEqual(unitPrice, 18.00);
        }

        [TestMethod]
        public void TestChangePriceLate()
        {
            eventInformation discount = new eventInformation(101, "This is a test", 20.00, false);
            double unitPrice = discount.changePrice("l");
            Assert.AreEqual(unitPrice, 22.00);
        }

        [TestMethod]
        public void TestChangePriceNoChange()
        {
            eventInformation discount = new eventInformation(101, "This is a test", 20.00, false);
            double unitPrice = discount.changePrice("DONOTHING");
            Assert.AreEqual(unitPrice, 20.00);
        }

        [TestMethod]
        public void TestChangePriceEmployee()
        {
            eventInformation discount = new eventInformation(101, "This is a test", 20.00, false);
            double unitPrice = discount.changePrice("e");
            Assert.AreEqual(unitPrice, 15.00);
        }

        [TestMethod]
        public void TestChangePriceFree()
        {
            eventInformation discount = new eventInformation(101, "This is a test", 20.00, false);
            double unitPrice = discount.changePrice("f");
            Assert.AreEqual(unitPrice, 0);
        }

        [TestMethod]
        public void TestTicketWithReturnability()
        {
            eventInformation ticket = new eventInformation(101, "This is a test", 20.00, false);
            bool result = ticket.addReturnClause("y");
            Assert.AreEqual(result, true);
        }

        [TestMethod]

        public void TestticketWithoutReturnability()
        {
            eventInformation ticket = new eventInformation(101, "This is a test", 20.00, false);
            bool result = ticket.addReturnClause("n");
            Assert.AreEqual(result, false);
        }
    }
}