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
        private readonly ILogger _logger;
        public ProductService(ILogger logger)
        {
            _logger = logger;
        }
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
