using ExcelDataReader;
using System.Data;

namespace ExcelOperations.Operations.MinorOperations
{
    public class ExcelToDataSet
    {
        public async Task<DataSet> TakeExcelToDataset(string fileLocation, int rowCount, CancellationToken cancellationToken)
        {
            DataSet ds = new DataSet();

            FileStream fileStream = File.Open(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);

            ds = reader.AsDataSet();

            var result = await FirstRowToColumnName(ds, rowCount, cancellationToken);

            return await Task.FromResult(result);
        }

        public async Task<DataSet> FirstRowToColumnName(DataSet dataSet, int rowCount, CancellationToken CancellationToken)
        {
            DataRow row = dataSet.Tables[0].Rows[rowCount - 1];

            var columnCount = dataSet.Tables[0].Columns.Count;
            
            for (int i = 0; i < columnCount; i++)
            {
                dataSet.Tables[0].Columns[i].ColumnName = row[i].ToString();  //same Column Name give exception
            }

            dataSet.AcceptChanges();

            for (int i = 0; i < rowCount; i++)
            {
                dataSet.Tables[0].Rows[i].Delete();
            }

            dataSet.AcceptChanges();

            return await Task.FromResult(dataSet);
        }
    }
}
