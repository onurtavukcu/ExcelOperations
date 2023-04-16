using System.Data;

namespace ExcelOperations.Operations.MinorOperations
{
    public interface IExcelToDataSet
    {
        Task<DataSet> TakeExcelToDataset(string fileLocation, int rowCount, int tableNumber, CancellationToken cancellationToken);

        Task<DataSet> FirstRowToColumnName(DataSet dataSet, int rowCount, int tablenumber, CancellationToken CancellationToken);
    }
}
