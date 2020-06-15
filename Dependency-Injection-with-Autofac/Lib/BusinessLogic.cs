using System;
using Lib.Utilities;

namespace Lib
{

    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;


        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processed the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
