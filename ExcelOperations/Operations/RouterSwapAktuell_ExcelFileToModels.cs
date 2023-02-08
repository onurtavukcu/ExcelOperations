using ExcelOperations.DocEntity;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations
{
    public class RouterSwapAktuell_ExcelFileToModels
    {
        public List<RouterSwapAktuell> ExcelTables()
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\ROUTER_Swap_aktuell.xlsm";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 5);

            var dataList = new List<RouterSwapAktuell>();

            var routerAktuellType = typeof(RouterSwapAktuell);

            var properties = routerAktuellType.GetProperties();

            foreach (DataRow row in datasets.Tables[0].Rows)
            {
                var routerAktuellInstance = new RouterSwapAktuell();

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
                        property.SetValue(routerAktuellInstance, data.ToString());
                    }
                }

                dataList.Add(routerAktuellInstance);
            }
            return dataList;
        }
    }
}
