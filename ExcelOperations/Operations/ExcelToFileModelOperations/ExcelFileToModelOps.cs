using ExcelOperations.DocEntity;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations.ExcelToFileModelOperations
{
    public class ExcelFileToModelOps<T> : IGetDataFromExcel<T> where T : new()
    {
        public async Task<List<T>> GetDataFromExcelAsync(int tableNumber, CancellationToken cancellationToken)
        {
            var thisName = typeof(T).Name;

            var fileLocator = new FileResourcePath();

            var (fileLocation, rowDataCount) = fileLocator.MatchLocation(thisName);

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, rowDataCount, tableNumber, cancellationToken);

            var dataList = new List<T>();

            var dataTypes = typeof(T);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Result.Tables[tableNumber].Rows)
            {
                T instance = new();

                foreach (var property in properties)
                {
                    var attribute = property.GetCustomAttribute<ColumnNameAttribute>();

                    var columnName = attribute is null
                        ? property.Name
                        : attribute.Name;

                    var data = row[columnName];

                    if (data is null || data == DBNull.Value)
                        continue;

                    if (property.CanWrite)
                    {
                        property.SetValue(instance, data.ToString());
                    }
                }

                dataList.Add(instance);
            }
            return await Task.FromResult(dataList);
        }
    }
}
