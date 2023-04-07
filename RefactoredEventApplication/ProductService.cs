using RefactoredEventApplication.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredEventApplication
{
    public class ProductService
    {
        private IEvent RocaBerryFarm;
        public ProductService(IEvent _RocaBerryFarm) //this parameter varies from what is Inputed
        {
            RocaBerryFarm = _RocaBerryFarm;
        }
        public void PrintInfo()
        {
            RocaBerryFarm.printInfo();
        }

    }

    public class PriceService
    {
        private IEvent RocaBerryFarm;

        public PriceService(IEvent _RocaBerryFarm) //this parameter varies from what is Inputed
        {
            RocaBerryFarm = _RocaBerryFarm;
        }
        public void ChangePrice()
        {
            RocaBerryFarm.changePrice();
        }
    }

    public class ReturnService
    {
        private IEvent RocaBerryFarm;

        public ReturnService(IEvent _RocaBerryFarm) //this parameter varies from what is Inputed
        {
            RocaBerryFarm = _RocaBerryFarm;
        }
        public void AddReturnClause()
        {
            RocaBerryFarm.addReturnClause();
        }
    }
}
