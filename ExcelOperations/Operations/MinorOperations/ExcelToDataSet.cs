using ExcelDataReader;
using ExcelOperations.Middlewares;
using System.Data;

namespace ExcelOperations.Operations.MinorOperations
{
    public class ExcelToDataSet : IExcelToDataSet
    {
        public async Task<DataSet> TakeExcelToDataset(string fileLocation, int rowCount, int tableNumber, CancellationToken cancellationToken)
        {
            DataSet ds = new DataSet();

            FileStream fileStream = File.Open(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);

            ds = reader.AsDataSet();

            var result = await FirstRowToColumnName(ds, rowCount, tableNumber, cancellationToken);

            return await Task.FromResult(result);
        }

        public async Task<DataSet> FirstRowToColumnName(DataSet dataSet, int rowCount, int tablenumber, CancellationToken CancellationToken)
        {
            DataRow row = dataSet.Tables[tablenumber].Rows[rowCount - 1];

            var columnCount = dataSet.Tables[tablenumber].Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                dataSet.Tables[tablenumber].Columns[i].ColumnName = row[i].ToString();  //same Column Name give exception
            }

            dataSet.AcceptChanges();

            for (int i = 0; i < rowCount; i++)
            {
                dataSet.Tables[tablenumber].Rows[i].Delete();
            }

            dataSet.AcceptChanges();

            return await Task.FromResult(dataSet);
        }
    }
}
