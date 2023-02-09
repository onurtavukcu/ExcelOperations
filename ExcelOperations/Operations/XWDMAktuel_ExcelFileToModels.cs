using ExcelOperations.DocEntity;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations
{
    public class XWDMAktuel_ExcelFileToModels
    {
        public async Task<List<XWDMAktuell>> ExcelTablesAsync(CancellationToken cancellationToken)
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\New folder\xWDM_aktuell.xlsx";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 5);

            var dataList = new List<XWDMAktuell>();

            var dataTypes = typeof(XWDMAktuell);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Tables[0].Rows)
            {
                var modelInstance = new XWDMAktuell();

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
                        property.SetValue(modelInstance, data.ToString());
                    }
                }

                dataList.Add(modelInstance);
            }
            return await Task.FromResult(dataList);
        }
        public List<XWDMAktuell> ExcelTables()
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\New folder\xWDM_aktuell.xlsx";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 5);

            var dataList = new List<XWDMAktuell>();

            var dataTypes = typeof(XWDMAktuell);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Tables[0].Rows)
            {
                var modelInstance = new XWDMAktuell();

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
                        property.SetValue(modelInstance, data.ToString());
                    }
                }

                dataList.Add(modelInstance);
            }
            return dataList;
        }
    }
}
