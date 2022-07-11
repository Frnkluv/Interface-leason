using Interface_leason;

IDataProcessor dataProcessor = new ConsoleDataProcessor();
dataProcessor.ProcessData(new DbDataProvider());
dataProcessor.ProcessData(new FileDataProvider());
dataProcessor.ProcessData(new APIDataProvider());