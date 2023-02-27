using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations.ExcelToFileModelOperations.PO
{
    public class ZTE_ExcelFileToModels
    {
        public async Task<List<ZTE_PO>> ZTEPOAsync(CancellationToken cancellationToken)
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\PO\DWM_Projeckt_2023-02-18.xlsx";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 1, cancellationToken);

            var dataList = new List<ZTE_PO>();

            var dataTypes = typeof(ZTE_PO);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Result.Tables[0].Rows)
            {
                var modelInstance = new ZTE_PO();

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
