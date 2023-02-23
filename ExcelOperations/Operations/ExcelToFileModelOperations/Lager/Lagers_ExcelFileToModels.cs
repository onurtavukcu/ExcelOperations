using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Lager;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations.ExcelToFileModelOperations.Lager
{
    public class Lagers_ExcelFileToModels
    {
        public async Task<List<DocEntity.Lager.LagerCentral>> LagerAsync(CancellationToken cancellationToken)
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\Lagers\Lager Central 2023-02-13.xlsm";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 1, cancellationToken);

            var dataList = new List<DocEntity.Lager.LagerCentral>();

            var dataTypes = typeof(DocEntity.Lager.LagerCentral);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Result.Tables[0].Rows)
            {
                var modelInstance = new DocEntity.Lager.LagerCentral();

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
    }
}
